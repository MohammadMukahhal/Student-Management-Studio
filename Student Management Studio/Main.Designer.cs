
namespace Student_Management_Studio
{
    partial class Main
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.addGradeBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.registrationBtn);
            this.flowLayoutPanel1.Controls.Add(this.addGradeBtn);
            this.flowLayoutPanel1.Controls.Add(this.reportBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(257, 703);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management_Studio.Properties.Resources.SMS_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // registrationBtn
            // 
            this.registrationBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.registrationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationBtn.Image = global::Student_Management_Studio.Properties.Resources.add_96px;
            this.registrationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrationBtn.Location = new System.Drawing.Point(3, 274);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(254, 73);
            this.registrationBtn.TabIndex = 1;
            this.registrationBtn.Text = "Registration";
            this.registrationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrationBtn.UseVisualStyleBackColor = false;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // addGradeBtn
            // 
            this.addGradeBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.addGradeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradeBtn.Image = global::Student_Management_Studio.Properties.Resources.edit_property_96px;
            this.addGradeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGradeBtn.Location = new System.Drawing.Point(3, 353);
            this.addGradeBtn.Name = "addGradeBtn";
            this.addGradeBtn.Size = new System.Drawing.Size(254, 73);
            this.addGradeBtn.TabIndex = 2;
            this.addGradeBtn.Text = "Add Grades";
            this.addGradeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addGradeBtn.UseVisualStyleBackColor = false;
            this.addGradeBtn.Click += new System.EventHandler(this.gradeBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Image = global::Student_Management_Studio.Properties.Resources.report_card_96px;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(3, 432);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(254, 73);
            this.reportBtn.TabIndex = 4;
            this.reportBtn.Text = "Report Card";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(257, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(875, 703);
            this.mainPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Snow;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Student_Management_Studio.Properties.Resources.school_g1893d4128_1920;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(875, 703);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 703);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Management_Studio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button addGradeBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

