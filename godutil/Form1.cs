using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MaterialSkin.Animations;
using EO.WinForm;
using EO.Base;
using EO.WebEngine;

namespace godutil
{
    public partial class Form1 : MaterialForm
    {
        readonly bool appRunning = true;
#pragma warning disable CC0034 // Redundant field assignment
        bool _ENABLED = false;
#pragma warning restore CC0034 // Redundant field assignment
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Red900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);
            CheckForIllegalCrossThreadCalls = false;
            //var MoveMouseThread = new Thread(_MoveMouse);
            //var UpdateThread = new Thread(_Update);
            //MoveMouseThread.Start();
            //UpdateThread.Start();
        }

        //private void _MoveMouse()
        //{
        //    int i = 0;
        //    while (appRunning)
        //    {
        //        if (MagicMouse.BGetAsyncKeyState(Keys.LButton) && _ENABLED && tbIncrease.Value != 0)
        //        {
        //            MagicMouse.Move(0, tbStep.Value + (tbIncrease.Value * i));
        //            Thread.Sleep(tbDelay.Value);
        //            if ((tbStep.Value + (tbIncrease.Value * i)) < tbMax.Value)
        //                i++;
        //        }
        //        else if (MagicMouse.BGetAsyncKeyState(Keys.LButton) && _ENABLED)
        //        {
        //            MagicMouse.Move(0, tbStep.Value);
        //            Thread.Sleep(tbDelay.Value);
        //        }
        //        else
        //        {
        //            i = 0;
        //        }
        //    }
        //}
        //private void _Update()
        //{
        //    while (appRunning)
        //    {
        //        lblStep.Text = "Step[" + tbStep.Value + "]:";
        //        lblDelay.Text = "Delay[" + tbDelay.Value + "]:";
        //        lblIncrease.Text = "Increase[" + tbIncrease.Value + "]:";
        //        lblMax.Text = "Max Inc.[" + tbMax.Value + "]:";

        //        var buffer = true;

        //        while (MagicMouse.BGetAsyncKeyState(Keys.XButton1))
        //        {
        //            if (buffer)
        //            {
        //                _ENABLED = !_ENABLED;
        //                buffer = false;
        //            }
        //        }

        //        if (_ENABLED)
        //        {
        //            metroToggle1.Checked = true;
        //            tbStep.Enabled = false;
        //            tbDelay.Enabled = false;
        //            tbIncrease.Enabled = false;
        //            tbMax.Enabled = false;
        //        }
        //        else
        //        {
        //            metroToggle1.Checked = false;
        //            tbStep.Enabled = true;
        //            tbDelay.Enabled = true;
        //            tbIncrease.Enabled = true;
        //            tbMax.Enabled = true;
        //        }

        //        Thread.Sleep(1);
        //        buffer = true;
        //    }
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    metroTabControl1.SelectedTab = metroTabPage2;
        //}

        //private void lblState_Click(object sender, EventArgs e)
        //{

        //}
    }
}
    

