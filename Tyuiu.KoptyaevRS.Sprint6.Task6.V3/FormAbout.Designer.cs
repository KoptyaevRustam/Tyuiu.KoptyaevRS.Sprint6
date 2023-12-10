
namespace Tyuiu.KoptyaevRS.Sprint6.Task6.V3
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_KRS = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_KRS = new System.Windows.Forms.PictureBox();
            this.buttonOk_KRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KRS
            // 
            this.labelInfo_KRS.AutoSize = true;
            this.labelInfo_KRS.Location = new System.Drawing.Point(222, 13);
            this.labelInfo_KRS.Name = "labelInfo_KRS";
            this.labelInfo_KRS.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_KRS.TabIndex = 1;
            this.labelInfo_KRS.Text = resources.GetString("labelInfo_KRS.Text");
            // 
            // pictureBoxAvatar_KRS
            // 
            this.pictureBoxAvatar_KRS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_KRS.Image")));
            this.pictureBoxAvatar_KRS.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_KRS.Name = "pictureBoxAvatar_KRS";
            this.pictureBoxAvatar_KRS.Size = new System.Drawing.Size(202, 212);
            this.pictureBoxAvatar_KRS.TabIndex = 0;
            this.pictureBoxAvatar_KRS.TabStop = false;
            // 
            // buttonOk_KRS
            // 
            this.buttonOk_KRS.Location = new System.Drawing.Point(429, 191);
            this.buttonOk_KRS.Name = "buttonOk_KRS";
            this.buttonOk_KRS.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_KRS.TabIndex = 2;
            this.buttonOk_KRS.Text = "Ок";
            this.buttonOk_KRS.UseVisualStyleBackColor = true;
            this.buttonOk_KRS.Click += new System.EventHandler(this.buttonOk_KRS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 226);
            this.Controls.Add(this.buttonOk_KRS);
            this.Controls.Add(this.labelInfo_KRS);
            this.Controls.Add(this.pictureBoxAvatar_KRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KRS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInfo_KRS;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_KRS;
        private System.Windows.Forms.Button buttonOk_KRS;
    }
}