namespace FullRealProgect
{
    partial class ucFilter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdF = new System.Windows.Forms.RadioButton();
            this.rdM = new System.Windows.Forms.RadioButton();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Perons ID",
            "Nationsl No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationslty",
            "Gender",
            "Phone",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(111, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.59649F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.40351F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rdF
            // 
            this.rdF.AutoSize = true;
            this.rdF.Location = new System.Drawing.Point(399, 7);
            this.rdF.Name = "rdF";
            this.rdF.Size = new System.Drawing.Size(55, 21);
            this.rdF.TabIndex = 3;
            this.rdF.TabStop = true;
            this.rdF.Text = "انثى";
            this.rdF.UseVisualStyleBackColor = true;
            this.rdF.CheckedChanged += new System.EventHandler(this.rdF_CheckedChanged);
            // 
            // rdM
            // 
            this.rdM.AutoSize = true;
            this.rdM.Location = new System.Drawing.Point(284, 6);
            this.rdM.Name = "rdM";
            this.rdM.Size = new System.Drawing.Size(49, 21);
            this.rdM.TabIndex = 4;
            this.rdM.TabStop = true;
            this.rdM.Text = "ذكر";
            this.rdM.UseVisualStyleBackColor = true;
            this.rdM.CheckedChanged += new System.EventHandler(this.rdM_CheckedChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(284, 3);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(224, 24);
            this.txtBox.TabIndex = 5;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            this.txtBox.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBox_Validating);
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(281, 3);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(227, 24);
            this.cmbBox.TabIndex = 7;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            this.cmbBox.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBox_Validating);
            // 
            // ucFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.rdM);
            this.Controls.Add(this.rdF);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucFilter";
            this.Size = new System.Drawing.Size(511, 35);
            this.Load += new System.EventHandler(this.ucFilter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rdM;
        private System.Windows.Forms.RadioButton rdF;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.TextBox txtBox;
    }
}
