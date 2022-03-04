namespace Student_Management_Studio
{
    partial class ReportCardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewRegistration = new System.Windows.Forms.DataGridView();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.nameBtn = new System.Windows.Forms.RadioButton();
            this.addressBtn = new System.Windows.Forms.RadioButton();
            this.dobBtn = new System.Windows.Forms.RadioButton();
            this.phoneNumberBtn = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).BeginInit();
            this.infoGroup.SuspendLayout();
            this.searchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(982, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 800);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Student_Management_Studio.Properties.Resources.report_card_96px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewRegistration
            // 
            this.dataGridViewRegistration.AllowUserToOrderColumns = true;
            this.dataGridViewRegistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRegistration.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRegistration.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridViewRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRegistration.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewRegistration.Location = new System.Drawing.Point(0, 390);
            this.dataGridViewRegistration.Name = "dataGridViewRegistration";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistration.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegistration.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewRegistration.RowTemplate.Height = 24;
            this.dataGridViewRegistration.Size = new System.Drawing.Size(982, 410);
            this.dataGridViewRegistration.TabIndex = 1;
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.idBox);
            this.infoGroup.Controls.Add(this.label1);
            this.infoGroup.Controls.Add(this.NextBtn);
            this.infoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGroup.Location = new System.Drawing.Point(0, 0);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(982, 390);
            this.infoGroup.TabIndex = 2;
            this.infoGroup.TabStop = false;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(215, 51);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(234, 22);
            this.idBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student ID:";
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(668, 158);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(216, 36);
            this.NextBtn.TabIndex = 14;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.searchBox);
            this.searchGroup.Controls.Add(this.nameBtn);
            this.searchGroup.Controls.Add(this.addressBtn);
            this.searchGroup.Controls.Add(this.dobBtn);
            this.searchGroup.Controls.Add(this.phoneNumberBtn);
            this.searchGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchGroup.Location = new System.Drawing.Point(0, 219);
            this.searchGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchGroup.Size = new System.Drawing.Size(982, 171);
            this.searchGroup.TabIndex = 33;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search By";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(19, 125);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(957, 22);
            this.searchBox.TabIndex = 1;
            // 
            // nameBtn
            // 
            this.nameBtn.AutoSize = true;
            this.nameBtn.Checked = true;
            this.nameBtn.Location = new System.Drawing.Point(19, 29);
            this.nameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(66, 21);
            this.nameBtn.TabIndex = 32;
            this.nameBtn.TabStop = true;
            this.nameBtn.Text = "Name";
            this.nameBtn.UseVisualStyleBackColor = true;
            // 
            // addressBtn
            // 
            this.addressBtn.AutoSize = true;
            this.addressBtn.Location = new System.Drawing.Point(19, 101);
            this.addressBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressBtn.Name = "addressBtn";
            this.addressBtn.Size = new System.Drawing.Size(81, 21);
            this.addressBtn.TabIndex = 31;
            this.addressBtn.Text = "Address";
            this.addressBtn.UseVisualStyleBackColor = true;
            // 
            // dobBtn
            // 
            this.dobBtn.AutoSize = true;
            this.dobBtn.Location = new System.Drawing.Point(19, 77);
            this.dobBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobBtn.Name = "dobBtn";
            this.dobBtn.Size = new System.Drawing.Size(107, 21);
            this.dobBtn.TabIndex = 29;
            this.dobBtn.Text = "Date of birth";
            this.dobBtn.UseVisualStyleBackColor = true;
            // 
            // phoneNumberBtn
            // 
            this.phoneNumberBtn.AutoSize = true;
            this.phoneNumberBtn.Location = new System.Drawing.Point(19, 53);
            this.phoneNumberBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumberBtn.Name = "phoneNumberBtn";
            this.phoneNumberBtn.Size = new System.Drawing.Size(124, 21);
            this.phoneNumberBtn.TabIndex = 30;
            this.phoneNumberBtn.Text = "Phone Number";
            this.phoneNumberBtn.UseVisualStyleBackColor = true;
            // 
            // ReportCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.searchGroup);
            this.Controls.Add(this.infoGroup);
            this.Controls.Add(this.dataGridViewRegistration);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportCardForm";
            this.Text = "Registration";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).EndInit();
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewRegistration;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.RadioButton nameBtn;
        private System.Windows.Forms.RadioButton addressBtn;
        private System.Windows.Forms.RadioButton dobBtn;
        private System.Windows.Forms.RadioButton phoneNumberBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
    }
}