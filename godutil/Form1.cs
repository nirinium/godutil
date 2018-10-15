using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using MetroFramework;


namespace godutil
{
    public partial class Form1 : MetroFramework.Forms.MetroForm

    {
        readonly bool appRunning = true;
#pragma warning disable CC0034 // Redundant field assignment
        bool _ENABLED = false;
#pragma warning restore CC0034 // Redundant field assignment
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            var MoveMouseThread = new Thread(_MoveMouse);
            var UpdateThread = new Thread(_Update);
            MoveMouseThread.Start();
            UpdateThread.Start();
        }

        private void _MoveMouse()
        {
            int i = 0;
            while (appRunning)
            {
                if (MagicMouse.BGetAsyncKeyState(Keys.LButton) && _ENABLED && tbIncrease.Value != 0)
                {
                    MagicMouse.Move(0, tbStep.Value + (tbIncrease.Value * i));
                    Thread.Sleep(tbDelay.Value);
                    if ((tbStep.Value + (tbIncrease.Value * i)) < tbMax.Value)
                        i++;
                }
                else if (MagicMouse.BGetAsyncKeyState(Keys.LButton) && _ENABLED)
                {
                    MagicMouse.Move(0, tbStep.Value);
                    Thread.Sleep(tbDelay.Value);
                }
                else
                {
                    i = 0;
                }
            }
        }
        private void _Update()
        {
            while (appRunning)
            {
                lblStep.Text = "Step[" + tbStep.Value+ "]:";
                lblDelay.Text = "Delay[" + tbDelay.Value+ "]:";
                lblIncrease.Text = "Increase[" + tbIncrease.Value+ "]:";
                lblMax.Text = "Max Inc.[" + tbMax.Value+ "]:";

                var buffer = true;

                while (MagicMouse.BGetAsyncKeyState(Keys.XButton1))
                {
                    if (buffer)
                    {
                        _ENABLED = !_ENABLED;
                        buffer = false;
                    }
                }

                if (_ENABLED)
                {
                    lblState.Text = "ENABLED [Mouse 4]";
                    lblState.ForeColor = Color.Green;
                    tbStep.Enabled = false;
                    tbDelay.Enabled = false;
                    tbIncrease.Enabled = false;
                    tbMax.Enabled = false;
                }
                else
                {
                    lblState.Text = "DISABLED [Mouse 4]";
                    lblState.ForeColor = Color.Red;
                    tbStep.Enabled = true;
                    tbDelay.Enabled = true;
                    tbIncrease.Enabled = true;
                    tbMax.Enabled = true;
                }

                Thread.Sleep(1);
                buffer = true;
            }
        }
    }
}
