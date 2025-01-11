namespace Student7
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
            txtNo = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtAge = new TextBox();
            txtDept = new TextBox();
            btnRecord = new Button();
            lblStuCount = new Label();
            btnDelete = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 46);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 126);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 173);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 220);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Department";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(205, 44);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(216, 23);
            txtNo.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(205, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(205, 123);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(216, 23);
            txtSurname.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(205, 165);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(216, 23);
            txtAge.TabIndex = 8;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(205, 212);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(216, 23);
            txtDept.TabIndex = 9;
            // 
            // btnRecord
            // 
            btnRecord.Location = new Point(205, 254);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(75, 23);
            btnRecord.TabIndex = 10;
            btnRecord.Text = "Save";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // lblStuCount
            // 
            lblStuCount.AutoSize = true;
            lblStuCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStuCount.Location = new Point(531, 9);
            lblStuCount.Name = "lblStuCount";
            lblStuCount.Size = new Size(22, 25);
            lblStuCount.TabIndex = 11;
            lblStuCount.Text = "0";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(286, 254);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(367, 254);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 13;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 450);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(lblStuCount);
            Controls.Add(btnRecord);
            Controls.Add(txtDept);
            Controls.Add(txtAge);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Öğrenci Formu";
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
        private TextBox txtNo;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtAge;
        private TextBox txtDept;
        private Button btnRecord;
        private Label lblStuCount;
        private Button btnDelete;
        private Button btnFind;
    }
}
