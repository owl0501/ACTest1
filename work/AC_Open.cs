using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ACTest1.work
{
    public partial class AC_Open : UserControl
    {
        public enum WorkStep : int
        {
            StepIdle = 0,
            Start,
            MoveOpenPos,
            MoveUsePos,
            MoveAddPos,
            MoveEnterPos,
            WaitNext,
            ActionDone
        }
        public enum WorkData
        {
            Unknow = 0,
            OpenPos,
            UsePos,
            AddPos,
            EnterPos,
        }

        GlobalKeyboardHook gHook;
        int kv;//將keyValue轉成整數用的變數
        bool ctrl, alt, shift;//按下功能鍵時就改為true
        private int TeachingStep = 0;
        private int step = 0;
        private int NextDelayTime = 0;

        private int OpenPosX = 0;
        private int OpenPosY = 0;
        private int UsePosX = 0;
        private int UsePosY = 0;
        private int AddPosX = 0;
        private int AddPosY = 0;
        private int EnterPosX = 0;
        private int EnterPosY = 0;



        private bool followCursorFlag = false;
        public MTimmer DoDelayTimer;
        public MTimmer NextDelayTimer;
        private int count = 0;
        private int repeatTimes = 0;
        private int waitTimes = 2000;

        

        public AC_Open()
        {
            InitializeComponent();
            DoDelayTimer = new MTimmer(2000);
            NextDelayTimer = new MTimmer(5000);

            gHook = new GlobalKeyboardHook(); //根據作者的程式碼(class)創造一個新物件

            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);// 連結KeyDown事件
            gHook.KeyUp += new KeyEventHandler(gHook_KeyUp);// 連結KeyDown事件


            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);

            gHook.hook();//開始監控
        }
        #region--設定位置--
        private void lbSetPos_Click(object sender, EventArgs e)
        {
            Label st = (Label)sender;
            switch (st.Text)
            {
                case "開啟位置:":
                    if (TeachingStep == (int)WorkData.Unknow)
                    {
                        TeachingStep = (int)WorkData.OpenPos;
                        lbOpenPos.ForeColor = Color.Red;
                        lbUsePos.ForeColor = Color.Black;
                        lbAddPos.ForeColor = Color.Black;
                        lbEnterPos.ForeColor = Color.Black;
                    }
                    else
                    {
                        TeachingStep = (int)WorkData.Unknow;
                        lbOpenPos.ForeColor = Color.Black;
                    }
                    break;
                case "使用位置:":
                    if (TeachingStep == (int)WorkData.Unknow)
                    {
                        TeachingStep = (int)WorkData.UsePos;
                        lbOpenPos.ForeColor = Color.Black;
                        lbUsePos.ForeColor = Color.Red;
                        lbAddPos.ForeColor = Color.Black;
                        lbEnterPos.ForeColor = Color.Black;
                    }
                    else
                    {
                        TeachingStep = (int)WorkData.Unknow;
                        lbUsePos.ForeColor = Color.Black;
                    }
                    break;
                case "加號位置:":
                    if (TeachingStep == (int)WorkData.Unknow)
                    {
                        TeachingStep = (int)WorkData.AddPos;
                        lbOpenPos.ForeColor = Color.Black;
                        lbUsePos.ForeColor = Color.Black;
                        lbAddPos.ForeColor = Color.Red;
                        lbEnterPos.ForeColor = Color.Black;
                    }
                    else
                    {
                        TeachingStep = (int)WorkData.Unknow;
                        lbAddPos.ForeColor = Color.Black;
                    }
                    break;
                case "確定位置:":
                    if (TeachingStep == (int)WorkData.Unknow)
                    {
                        TeachingStep = (int)WorkData.EnterPos;
                        lbOpenPos.ForeColor = Color.Black;
                        lbUsePos.ForeColor = Color.Black;
                        lbAddPos.ForeColor = Color.Black;
                        lbEnterPos.ForeColor = Color.Red;
                    }
                    else
                    {
                        TeachingStep = (int)WorkData.Unknow;
                        lbEnterPos.ForeColor = Color.Black;
                    }
                    break;
            }
        }
        #endregion

        #region  -- Ctrl+F1 事件 --
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            kv = (int)e.KeyValue;//把按下的按鍵號碼轉成整數存在kv中

            switch (kv)
            {
                case 27:                    //當按下ESC的時候強制停止
                    ScanTimer.Stop();
                    step = (int)WorkStep.ActionDone;
                    break;

                case 162: ctrl = true; break;//當按下左ctrl的時候布林值為真
                case 163: ctrl = true; break;//當按下右ctrl的時候布林值為真
                case 112:                                 //F1:112  F9:120
                    if (ctrl == true)
                    {
                        int x = MousePosition.X;
                        int y = MousePosition.Y;
                        switch ((int)TeachingStep)
                        {
                            case (int)WorkData.Unknow:
                                break;
                            case (int)WorkData.OpenPos:
                                lbOpenPosX.Text = x.ToString();
                                lbOpenPosY.Text = y.ToString();
                                break;
                            case (int)WorkData.UsePos:
                                lbUsePosX.Text = x.ToString();
                                lbUsePosY.Text = y.ToString();
                                break;
                            case (int)WorkData.AddPos:
                                lbAddPosX.Text = x.ToString();
                                lbAddPosY.Text = y.ToString();
                                break;
                            case (int)WorkData.EnterPos:
                                lbEnterPosX.Text = x.ToString();
                                lbEnterPosY.Text = y.ToString();
                                break;
                        }
                    }
                    break;//按下A之後要怎樣怎樣  
            }
        }
        public void gHook_KeyUp(object sender, KeyEventArgs e)
        {
            kv = (int)e.KeyValue;//把按下的按鍵號碼轉成整數存在kv中
            switch (kv)
            {
                case 162:
                    ctrl = false;//當放開左ctrl的時候布林值為假
                    break;
                case 163:
                    ctrl = false;//當放開右ctrl的時候布林值為假
                    break;
            }
        }
        #endregion
        #region--資料處理--
        private void GetInfo()
        {
            if ((int.TryParse(lbOpenPosX.Text, out OpenPosX)) == false) Error();
            if ((int.TryParse(lbOpenPosY.Text, out OpenPosY)) == false) Error();
            if ((int.TryParse(lbUsePosX.Text, out UsePosX)) == false) Error();
            if ((int.TryParse(lbUsePosY.Text, out UsePosY)) == false) Error();
            if ((int.TryParse(lbAddPosX.Text, out AddPosX)) == false) Error();
            if ((int.TryParse(lbAddPosY.Text, out AddPosY)) == false) Error();
            if ((int.TryParse(lbEnterPosX.Text, out EnterPosX)) == false) Error();
            if ((int.TryParse(lbEnterPosY.Text, out EnterPosY)) == false) Error();
            repeatTimes = (int)nupRepeatTimes.Value;
            NextDelayTime = (int)nupRunDelayTime.Value;
        }
        private void Error()
        {

        }
        #endregion
        #region--動作流程--
        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (followCursorFlag)
            {
                //CursorPixelColor();
            }
            else
            {
                switch ((int)step)
                {
                    case (int)WorkStep.StepIdle:
                        break;

                    case (int)WorkStep.Start:
                        {
                            GetInfo();
                            count = 0;
                            step = (int)WorkStep.MoveOpenPos;
                        }
                        break;
                    //1
                    case (int)WorkStep.MoveOpenPos:
                        {
                            MouseUnit.Move(OpenPosX, OpenPosY);
                            MouseUnit.LeftClick();
                            step = (int)WorkStep.MoveUsePos;
                            DoDelayTimer.SetTimmer(waitTimes);
                            DoDelayTimer.Start();
                        }
                        break;
                    case (int)WorkStep.MoveUsePos:
                        {
                            MouseUnit.Move(UsePosX, UsePosY);
                            MouseUnit.LeftClick();
                            step = (int)WorkStep.MoveAddPos;
                            DoDelayTimer.SetTimmer(waitTimes);
                            DoDelayTimer.Start();
                        }
                        break;
                    case (int)WorkStep.MoveAddPos:
                        {
                            MouseUnit.Move(AddPosX, AddPosY);
                            MouseUnit.LeftClick();
                            step = (int)WorkStep.MoveEnterPos;
                            DoDelayTimer.SetTimmer(waitTimes);
                            DoDelayTimer.Start();
                        }
                        break;
                    case (int)WorkStep.MoveEnterPos:
                        {
                            MouseUnit.Move(EnterPosX, EnterPosY);
                            MouseUnit.LeftClick();//按一下
                            //等1秒
                            DoDelayTimer.SetTimmer(waitTimes);
                            DoDelayTimer.Start();
                            //
                            MouseUnit.Move(EnterPosX, EnterPosY);
                            MouseUnit.LeftClick();//按一下
                            NextDelayTimer.SetTimmer(NextDelayTime);
                            NextDelayTimer.Start();
                            step = (int)WorkStep.WaitNext;
                        }
                        break;
                    case (int)WorkStep.WaitNext:
                        if (NextDelayTimer.IsTimeOut())
                        {
                            count++;
                            if (count >= repeatTimes)
                            {
                                step = (int)WorkStep.ActionDone;
                            }
                            else
                            {
                                step = (int)WorkStep.MoveOpenPos;
                            }
                        }
                        break;
                    case (int)WorkStep.ActionDone:
                        break;
                }
            }
            //lbJudgeResult.BackColor = (GetPixelFromScreen(judgePosX, judgePosY) == OKColor) ? Color.Green : Color.White;
            lbRepeatTimes.Text = count.ToString();
            txbFlow.Text = ((WorkStep)step).ToString();
        }
        #endregion
        
        private void btnStopRun_Click(object sender, EventArgs e)
        {
            ScanTimer.Stop();
            step = (int)WorkStep.ActionDone;
        }
        private void btnStepRun_Click(object sender, EventArgs e)
        {
            ScanTimer.Start();
            step = (int)WorkStep.Start;
        }
    }
}