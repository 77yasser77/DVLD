namespace FullRealProgect
{
    partial class FormAdd_EditPersonInfo
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
            this.labTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.Red;
            this.labTitle.Location = new System.Drawing.Point(457, 54);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(292, 49);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Update Perons";
            // 
            // FormAdd_EditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 715);
            this.Controls.Add(this.labTitle);
            this.Name = "FormAdd_EditPersonInfo";
            this.Text = "Add/Edit Person Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labTitle;
    }
}