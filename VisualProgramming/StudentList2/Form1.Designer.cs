namespace Student8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNumber = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtAge = new TextBox();
            txtDepartment = new TextBox();
            btnSave = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            lblRecordCount = new Label();
            btnBack = new Button();
            btnForw = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 62);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 109);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 157);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 206);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Age :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 251);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Department :";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(261, 59);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(291, 23);
            txtNumber.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(261, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(291, 23);
            txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(261, 149);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(291, 23);
            txtSurname.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(261, 198);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(291, 23);
            txtAge.TabIndex = 8;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(261, 243);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(291, 23);
            txtDepartment.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(294, 293);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(370, 293);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 11;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(446, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordCount.Location = new Point(752, 9);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(24, 30);
            lblRecordCount.TabIndex = 13;
            lblRecordCount.Text = "0";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(261, 293);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(27, 23);
            btnBack.TabIndex = 14;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnForw
            // 
            btnForw.Location = new Point(527, 293);
            btnForw.Name = "btnForw";
            btnForw.Size = new Size(25, 23);
            btnForw.TabIndex = 15;
            btnForw.Text = ">";
            btnForw.UseVisualStyleBackColor = true;
            btnForw.Click += btnForw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForw);
            Controls.Add(btnBack);
            Controls.Add(lblRecordCount);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);
            Controls.Add(btnSave);
            Controls.Add(txtDepartment);
            Controls.Add(txtAge);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNumber;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtAge;
        private TextBox txtDepartment;
        private Button btnSave;
        private Button btnFind;
        private Button btnDelete;
        private Label lblRecordCount;
        private Button btnBack;
        private Button btnForw;
    }
}
