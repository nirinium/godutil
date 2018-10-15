namespace godutil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblIncrease = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStep = new MetroFramework.Controls.MetroTrackBar();
            this.tbIncrease = new MetroFramework.Controls.MetroTrackBar();
            this.tbMax = new MetroFramework.Controls.MetroTrackBar();
            this.tbDelay = new MetroFramework.Controls.MetroTrackBar();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.lblState = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(135, 92);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(51, 13);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "MAX INC";
            // 
            // lblIncrease
            // 
            this.lblIncrease.AutoSize = true;
            this.lblIncrease.Location = new System.Drawing.Point(6, 96);
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.Size = new System.Drawing.Size(57, 13);
            this.lblIncrease.TabIndex = 1;
            this.lblIncrease.Text = "INCREASE";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(135, 28);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(37, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "DELAY";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(6, 28);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(30, 13);
            this.lblStep.TabIndex = 3;
            this.lblStep.Text = "STEP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDelay);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.tbIncrease);
            this.groupBox1.Controls.Add(this.tbStep);
            this.groupBox1.Controls.Add(this.lblStep);
            this.groupBox1.Controls.Add(this.lblDelay);
            this.groupBox1.Controls.Add(this.lblMax);
            this.groupBox1.Controls.Add(this.lblIncrease);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 398);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECOIL CONFIG";
            // 
            // tbStep
            // 
            this.tbStep.BackColor = System.Drawing.Color.Transparent;
            this.tbStep.Location = new System.Drawing.Point(9, 44);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(85, 23);
            this.tbStep.TabIndex = 17;
            this.tbStep.Text = "metroTrackBar1";
            // 
            // tbIncrease
            // 
            this.tbIncrease.BackColor = System.Drawing.Color.Transparent;
            this.tbIncrease.Location = new System.Drawing.Point(12, 128);
            this.tbIncrease.Name = "tbIncrease";
            this.tbIncrease.Size = new System.Drawing.Size(75, 23);
            this.tbIncrease.TabIndex = 18;
            this.tbIncrease.Text = "metroTrackBar1";
            // 
            // tbMax
            // 
            this.tbMax.BackColor = System.Drawing.Color.Transparent;
            this.tbMax.Location = new System.Drawing.Point(138, 127);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(75, 23);
            this.tbMax.TabIndex = 19;
            this.tbMax.Text = "metroTrackBar1";
            // 
            // tbDelay
            // 
            this.tbDelay.BackColor = System.Drawing.Color.Transparent;
            this.tbDelay.Location = new System.Drawing.Point(138, 43);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(75, 23);
            this.tbDelay.TabIndex = 20;
            this.tbDelay.Text = "metroTrackBar1";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(182, 428);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(81, 19);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "metroLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(320, 456);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "nirinium : godutil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblIncrease;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTrackBar tbStep;
        private MetroFramework.Controls.MetroTrackBar tbDelay;
        private MetroFramework.Controls.MetroTrackBar tbMax;
        private MetroFramework.Controls.MetroTrackBar tbIncrease;
        private MetroFramework.Controls.MetroLabel lblState;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}

