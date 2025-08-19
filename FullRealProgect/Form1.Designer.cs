namespace FullRealProgect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butApplications = new FullRealProgect.Button();
            this.button2 = new FullRealProgect.Button();
            this.button3 = new FullRealProgect.Button();
            this.button4 = new FullRealProgect.Button();
            this.button5 = new FullRealProgect.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.butApplications);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1458, 80);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // butApplications
            // 
            this.butApplications.Image = global::FullRealProgect.Properties.Resources.Date;
            this.butApplications.Location = new System.Drawing.Point(3, 3);
            this.butApplications.Name = "butApplications";
            this.butApplications.Size = new System.Drawing.Size(227, 77);
            this.butApplications.TabIndex = 0;
            this.butApplications.text = "button1";
            this.butApplications.Load += new System.EventHandler(this.button1_Load);
            // 
            // button2
            // 
            this.button2.Image = global::FullRealProgect.Properties.Resources.man;
            this.button2.Location = new System.Drawing.Point(236, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 77);
            this.button2.TabIndex = 1;
            this.button2.text = "button1";
            this.button2.Load += new System.EventHandler(this.button2_Load);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(469, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 77);
            this.button3.TabIndex = 2;
            this.button3.text = "button1";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(702, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 77);
            this.button4.TabIndex = 3;
            this.button4.text = "button1";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(935, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 77);
            this.button5.TabIndex = 4;
            this.button5.text = "button1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1448, 501);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button butApplications;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

