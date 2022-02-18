
namespace Student_Management_Studio
{
    partial class Registration
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.guardianNameBox = new System.Windows.Forms.TextBox();
            this.guardianNumberBox = new System.Windows.Forms.TextBox();
            this.gpaBox = new System.Windows.Forms.TextBox();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Image = global::Student_Management_Studio.Properties.Resources.add_96px;
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
            this.dataGridViewRegistration.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistration_CellDoubleClick);
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.updateBtn);
            this.infoGroup.Controls.Add(this.deleteBtn);
            this.infoGroup.Controls.Add(this.saveBtn);
            this.infoGroup.Controls.Add(this.addressBox);
            this.infoGroup.Controls.Add(this.phoneBox);
            this.infoGroup.Controls.Add(this.guardianNameBox);
            this.infoGroup.Controls.Add(this.guardianNumberBox);
            this.infoGroup.Controls.Add(this.gpaBox);
            this.infoGroup.Controls.Add(this.dateTimeBox);
            this.infoGroup.Controls.Add(this.nameBox);
            this.infoGroup.Controls.Add(this.label7);
            this.infoGroup.Controls.Add(this.label6);
            this.infoGroup.Controls.Add(this.label5);
            this.infoGroup.Controls.Add(this.label4);
            this.infoGroup.Controls.Add(this.label3);
            this.infoGroup.Controls.Add(this.label2);
            this.infoGroup.Controls.Add(this.label1);
            this.infoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGroup.Location = new System.Drawing.Point(0, 0);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(982, 390);
            this.infoGroup.TabIndex = 2;
            this.infoGroup.TabStop = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(685, 158);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(129, 36);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(820, 158);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(129, 36);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Yellow;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(550, 158);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 36);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(165, 109);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(255, 22);
            this.addressBox.TabIndex = 13;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(165, 160);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(255, 22);
            this.phoneBox.TabIndex = 12;
            // 
            // guardianNameBox
            // 
            this.guardianNameBox.Location = new System.Drawing.Point(607, 18);
            this.guardianNameBox.Name = "guardianNameBox";
            this.guardianNameBox.Size = new System.Drawing.Size(255, 22);
            this.guardianNameBox.TabIndex = 11;
            // 
            // guardianNumberBox
            // 
            this.guardianNumberBox.Location = new System.Drawing.Point(607, 68);
            this.guardianNumberBox.Name = "guardianNumberBox";
            this.guardianNumberBox.Size = new System.Drawing.Size(255, 22);
            this.guardianNumberBox.TabIndex = 10;
            // 
            // gpaBox
            // 
            this.gpaBox.Location = new System.Drawing.Point(607, 109);
            this.gpaBox.Name = "gpaBox";
            this.gpaBox.Size = new System.Drawing.Size(255, 22);
            this.gpaBox.TabIndex = 9;
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.CustomFormat = "mm/dd/yyyy";
            this.dateTimeBox.Location = new System.Drawing.Point(165, 66);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(255, 22);
            this.dateTimeBox.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(165, 18);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(255, 22);
            this.nameBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Overall GPA: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone #: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guardian #: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guardian Name: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
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
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
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
            // Registration
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
            this.Name = "Registration";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.RadioButton nameBtn;
        private System.Windows.Forms.RadioButton addressBtn;
        private System.Windows.Forms.RadioButton dobBtn;
        private System.Windows.Forms.RadioButton phoneNumberBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox guardianNameBox;
        private System.Windows.Forms.TextBox guardianNumberBox;
        private System.Windows.Forms.TextBox gpaBox;
        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.TextBox nameBox;

    }
}