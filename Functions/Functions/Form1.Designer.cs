namespace Functions
{
    partial class frmMain
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
            this.btnDay = new System.Windows.Forms.Button();
            this.txtdaynumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(394, 62);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(75, 23);
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "روز هفته";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // txtdaynumber
            // 
            this.txtdaynumber.Location = new System.Drawing.Point(272, 65);
            this.txtdaynumber.Name = "txtdaynumber";
            this.txtdaynumber.Size = new System.Drawing.Size(100, 20);
            this.txtdaynumber.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 230);
            this.Controls.Add(this.txtdaynumber);
            this.Controls.Add(this.btnDay);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.TextBox txtdaynumber;
    }
}

