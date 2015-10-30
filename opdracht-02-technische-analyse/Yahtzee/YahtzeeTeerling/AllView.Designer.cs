using System;
using System.Collections.Generic;

namespace YahtzeeTeerling
{
    partial class AllView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttn_all = new System.Windows.Forms.Button();
            this.btnn_start_again = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_all
            // 
            this.bttn_all.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttn_all.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttn_all.Location = new System.Drawing.Point(37, 233);
            this.bttn_all.Name = "bttn_all";
            this.bttn_all.Size = new System.Drawing.Size(75, 23);
            this.bttn_all.TabIndex = 0;
            this.bttn_all.Text = "Throw All";
            this.bttn_all.UseVisualStyleBackColor = false;
            this.bttn_all.Click += new System.EventHandler(this.bttn_all_Click);
            // 
            // btnn_start_again
            // 
            this.btnn_start_again.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnn_start_again.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnn_start_again.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnn_start_again.Location = new System.Drawing.Point(164, 233);
            this.btnn_start_again.Name = "btnn_start_again";
            this.btnn_start_again.Size = new System.Drawing.Size(75, 23);
            this.btnn_start_again.TabIndex = 1;
            this.btnn_start_again.Text = "Start Again";
            this.btnn_start_again.UseVisualStyleBackColor = false;
            this.btnn_start_again.Click += new System.EventHandler(this.btnn_start_again_Click);
            // 
            // AllView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnn_start_again);
            this.Controls.Add(this.bttn_all);
            this.Name = "AllView";
            this.Size = new System.Drawing.Size(612, 451);
            this.Load += new System.EventHandler(this.AllView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_all;

        public static implicit operator AllView(List<AllView> v)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Button btnn_start_again;
    }
}
