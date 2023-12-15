
namespace Tyuiu.KoptyaevRS.Sprint6.TaskReview.V30
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
            this.pictureBoxMe_KRS = new System.Windows.Forms.PictureBox();
            this.labelInf_KRS = new System.Windows.Forms.Label();
            this.buttonOK_KRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_KRS
            // 
            this.pictureBoxMe_KRS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_KRS.Image")));
            this.pictureBoxMe_KRS.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxMe_KRS.Name = "pictureBoxMe_KRS";
            this.pictureBoxMe_KRS.Size = new System.Drawing.Size(206, 212);
            this.pictureBoxMe_KRS.TabIndex = 0;
            this.pictureBoxMe_KRS.TabStop = false;
            // 
            // labelInf_KRS
            // 
            this.labelInf_KRS.AutoSize = true;
            this.labelInf_KRS.Location = new System.Drawing.Point(225, 13);
            this.labelInf_KRS.Name = "labelInf_KRS";
            this.labelInf_KRS.Size = new System.Drawing.Size(308, 169);
            this.labelInf_KRS.TabIndex = 1;
            this.labelInf_KRS.Text = resources.GetString("labelInf_KRS.Text");
            // 
            // buttonOK_KRS
            // 
            this.buttonOK_KRS.Location = new System.Drawing.Point(449, 201);
            this.buttonOK_KRS.Name = "buttonOK_KRS";
            this.buttonOK_KRS.Size = new System.Drawing.Size(83, 24);
            this.buttonOK_KRS.TabIndex = 2;
            this.buttonOK_KRS.Text = "Ок";
            this.buttonOK_KRS.UseVisualStyleBackColor = true;
            this.buttonOK_KRS.Click += new System.EventHandler(this.buttonOK_KRS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 230);
            this.Controls.Add(this.buttonOK_KRS);
            this.Controls.Add(this.labelInf_KRS);
            this.Controls.Add(this.pictureBoxMe_KRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_KRS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_KRS;
        private System.Windows.Forms.Label labelInf_KRS;
        private System.Windows.Forms.Button buttonOK_KRS;
    }
}