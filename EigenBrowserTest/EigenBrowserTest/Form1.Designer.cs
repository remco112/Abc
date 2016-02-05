namespace EigenBrowserTest
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
            this.btnGo = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.myBrowser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Image = global::EigenBrowserTest.Properties.Resources.Capture;
            this.btnGo.Location = new System.Drawing.Point(772, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(85, 58);
            this.btnGo.TabIndex = 0;
            this.btnGo.Tag = "";
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(27, 32);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(728, 20);
            this.tbURL.TabIndex = 1;
            // 
            // myBrowser
            // 
            this.myBrowser.Location = new System.Drawing.Point(12, 76);
            this.myBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myBrowser.Name = "myBrowser";
            this.myBrowser.Size = new System.Drawing.Size(922, 553);
            this.myBrowser.TabIndex = 2;
            this.myBrowser.Url = new System.Uri("http://www.tweakers.net", System.UriKind.Absolute);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Typ hier de URL ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(946, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.myBrowser);
            this.Controls.Add(this.tbURL);
            this.Name = "Form1";
            this.Text = "EigenWeBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.WebBrowser myBrowser;
        private System.Windows.Forms.Label label1;
    }
}

