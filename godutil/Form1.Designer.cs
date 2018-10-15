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
            this.webView1 = new EO.WebBrowser.WebView();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView2 = new EO.WebBrowser.WebView();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.ObjectForScripting = null;
            this.webView1.Url = "https://www.google.com";
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Location = new System.Drawing.Point(12, 71);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(776, 367);
            this.webControl1.TabIndex = 0;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView2;
            // 
            // webView2
            // 
            this.webView2.ObjectForScripting = null;
            this.webView2.Url = "google.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webControl1);
            this.Name = "Form1";
            this.Text = "GODUtil - BETA";
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WebBrowser.WebView webView1;
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView2;
    }
}