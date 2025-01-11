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
            txtNumber = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            btnCreate = new Button();
            btnFind = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 141);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(145, 43);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(275, 23);
            txtNumber.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 23);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(145, 133);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(275, 23);
            txtSurname.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(145, 178);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(59, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(210, 178);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(59, 23);
            btnFind.TabIndex = 7;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(275, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(59, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(340, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(59, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 260);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnFind);
            Controls.Add(btnCreate);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtNumber);
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
        private TextBox txtNumber;
        private TextBox txtName;
        private TextBox txtSurname;
        private Button btnCreate;
        private Button btnFind;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
