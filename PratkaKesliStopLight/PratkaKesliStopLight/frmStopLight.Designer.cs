namespace PratkaKesliStopLight
{
    partial class frmStopLight
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
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.SystemColors.Window;
            this.txtRed.Location = new System.Drawing.Point(43, 26);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 20);
            this.txtRed.TabIndex = 0;
            this.txtRed.Enter += new System.EventHandler(this.txtRed_Enter);
            // 
            // txtYellow
            // 
            this.txtYellow.BackColor = System.Drawing.SystemColors.Window;
            this.txtYellow.Location = new System.Drawing.Point(43, 67);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(100, 20);
            this.txtYellow.TabIndex = 1;
            this.txtYellow.Enter += new System.EventHandler(this.txtYellow_Enter);
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.SystemColors.Window;
            this.txtGreen.Location = new System.Drawing.Point(43, 108);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(100, 20);
            this.txtGreen.TabIndex = 2;
            this.txtGreen.Enter += new System.EventHandler(this.txtGreen_Enter);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(55, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPratkaKesliStopLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(190, 198);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtYellow);
            this.Controls.Add(this.txtRed);
            this.Name = "frmPratkaKesliStopLight";
            this.Text = "Stop Light";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Button btnExit;
    }
}

