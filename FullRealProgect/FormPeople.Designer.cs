namespace FullRealProgect
{
    partial class FormPeople
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
            this.components = new System.ComponentModel.Container();
            this.dgvPeole = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.اظهارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةعميلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ارسالرسالةنصيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اتصالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butClose = new System.Windows.Forms.Button();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.ucFilter1 = new FullRealProgect.ucFilter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeole)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeole
            // 
            this.dgvPeole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeole.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeole.Location = new System.Drawing.Point(12, 256);
            this.dgvPeole.Name = "dgvPeole";
            this.dgvPeole.RowHeadersWidth = 51;
            this.dgvPeole.RowTemplate.Height = 26;
            this.dgvPeole.Size = new System.Drawing.Size(1321, 367);
            this.dgvPeole.TabIndex = 0;
            this.dgvPeole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeole_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اظهارToolStripMenuItem,
            this.اضافةعميلToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.ارسالرسالةنصيةToolStripMenuItem,
            this.اتصالToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 160);
            // 
            // اظهارToolStripMenuItem
            // 
            this.اظهارToolStripMenuItem.Image = global::FullRealProgect.Properties.Resources.PersonalCard;
            this.اظهارToolStripMenuItem.Name = "اظهارToolStripMenuItem";
            this.اظهارToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.اظهارToolStripMenuItem.Text = "اظهار البيانات";
            this.اظهارToolStripMenuItem.Click += new System.EventHandler(this.اظهارToolStripMenuItem_Click);
            // 
            // اضافةعميلToolStripMenuItem
            // 
            this.اضافةعميلToolStripMenuItem.Image = global::FullRealProgect.Properties.Resources.ManPicture;
            this.اضافةعميلToolStripMenuItem.Name = "اضافةعميلToolStripMenuItem";
            this.اضافةعميلToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.اضافةعميلToolStripMenuItem.Text = "اضافة عميل";
            this.اضافةعميلToolStripMenuItem.Click += new System.EventHandler(this.اضافةعميلToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::FullRealProgect.Properties.Resources.letter_x_Amg;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // ارسالرسالةنصيةToolStripMenuItem
            // 
            this.ارسالرسالةنصيةToolStripMenuItem.Name = "ارسالرسالةنصيةToolStripMenuItem";
            this.ارسالرسالةنصيةToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.ارسالرسالةنصيةToolStripMenuItem.Text = "ارسال رسالة نصية";
            // 
            // اتصالToolStripMenuItem
            // 
            this.اتصالToolStripMenuItem.Name = "اتصالToolStripMenuItem";
            this.اتصالToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.اتصالToolStripMenuItem.Text = "اتصال ";
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(1227, 629);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(106, 45);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "الغاء";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // picAdd
            // 
            this.picAdd.Image = global::FullRealProgect.Properties.Resources.man1;
            this.picAdd.Location = new System.Drawing.Point(1227, 165);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(104, 85);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 3;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "# Records:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(128, 638);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(21, 22);
            this.lblRecords.TabIndex = 5;
            this.lblRecords.Text = "0";
            // 
            // ucFilter1
            // 
            this.ucFilter1.DGV = null;
            this.ucFilter1.Location = new System.Drawing.Point(16, 215);
            this.ucFilter1.Name = "ucFilter1";
            this.ucFilter1.Size = new System.Drawing.Size(618, 35);
            this.ucFilter1.TabIndex = 6;
            this.ucFilter1.Click += new System.EventHandler(this.ucFilter1_Click);
            // 
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 683);
            this.Controls.Add(this.ucFilter1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.dgvPeole);
            this.Name = "FormPeople";
            this.Text = "FormPeople";
            this.Load += new System.EventHandler(this.FormPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeole)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeole;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اظهارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةعميلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ارسالرسالةنصيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اتصالToolStripMenuItem;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
        private ucFilter ucFilter1;
    }
}