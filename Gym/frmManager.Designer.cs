namespace Gym
{
    partial class frmManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGoToFrmActivities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ניהול מתאמנים";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "ניהול מדריכים";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGoToFrmActivities
            // 
            this.btnGoToFrmActivities.Location = new System.Drawing.Point(120, 61);
            this.btnGoToFrmActivities.Name = "btnGoToFrmActivities";
            this.btnGoToFrmActivities.Size = new System.Drawing.Size(136, 23);
            this.btnGoToFrmActivities.TabIndex = 2;
            this.btnGoToFrmActivities.Text = "ניהול פעילויות";
            this.btnGoToFrmActivities.UseVisualStyleBackColor = true;
            this.btnGoToFrmActivities.Click += new System.EventHandler(this.btnGoToFrmActivities_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 433);
            this.Controls.Add(this.btnGoToFrmActivities);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGoToFrmActivities;
    }
}