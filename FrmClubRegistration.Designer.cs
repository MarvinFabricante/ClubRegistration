namespace ClubRegistration
{
    partial class FrmClubRegistration
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
            fieldsPanel = new Panel();
            programCombobox = new ComboBox();
            programLbl = new Label();
            genderCombobox = new ComboBox();
            genderLbl = new Label();
            middlenameTxtbox = new TextBox();
            middlenameLbl = new Label();
            firstnameTxtbox = new TextBox();
            firstnameLbl = new Label();
            ageTxtbox = new TextBox();
            ageLbl = new Label();
            lastnameTxtbox = new TextBox();
            lastnameLbl = new Label();
            studentIDTextbox = new TextBox();
            studentIDLbl = new Label();
            listOfClubMembersPanel = new Panel();
            refreshBtn = new Button();
            table = new DataGridView();
            listOfClubMembersLbl = new Label();
            registerBtn = new Button();
            updateBtn = new Button();
            fieldsPanel.SuspendLayout();
            listOfClubMembersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // fieldsPanel
            // 
            fieldsPanel.BorderStyle = BorderStyle.FixedSingle;
            fieldsPanel.Controls.Add(programCombobox);
            fieldsPanel.Controls.Add(programLbl);
            fieldsPanel.Controls.Add(genderCombobox);
            fieldsPanel.Controls.Add(genderLbl);
            fieldsPanel.Controls.Add(middlenameTxtbox);
            fieldsPanel.Controls.Add(middlenameLbl);
            fieldsPanel.Controls.Add(firstnameTxtbox);
            fieldsPanel.Controls.Add(firstnameLbl);
            fieldsPanel.Controls.Add(ageTxtbox);
            fieldsPanel.Controls.Add(ageLbl);
            fieldsPanel.Controls.Add(lastnameTxtbox);
            fieldsPanel.Controls.Add(lastnameLbl);
            fieldsPanel.Controls.Add(studentIDTextbox);
            fieldsPanel.Controls.Add(studentIDLbl);
            fieldsPanel.Location = new Point(12, 12);
            fieldsPanel.Name = "fieldsPanel";
            fieldsPanel.Size = new Size(845, 222);
            fieldsPanel.TabIndex = 0;
            // 
            // programCombobox
            // 
            programCombobox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCombobox.FormattingEnabled = true;
            programCombobox.Location = new Point(577, 27);
            programCombobox.Name = "programCombobox";
            programCombobox.Size = new Size(247, 28);
            programCombobox.TabIndex = 13;
            // 
            // programLbl
            // 
            programLbl.AutoSize = true;
            programLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programLbl.Location = new Point(577, 0);
            programLbl.Name = "programLbl";
            programLbl.Size = new Size(69, 20);
            programLbl.TabIndex = 12;
            programLbl.Text = "Program:";
            // 
            // genderCombobox
            // 
            genderCombobox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderCombobox.FormattingEnabled = true;
            genderCombobox.Location = new Point(309, 158);
            genderCombobox.Name = "genderCombobox";
            genderCombobox.Size = new Size(204, 28);
            genderCombobox.TabIndex = 11;
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderLbl.Location = new Point(309, 131);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(60, 20);
            genderLbl.TabIndex = 10;
            genderLbl.Text = "Gender:";
            // 
            // middlenameTxtbox
            // 
            middlenameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middlenameTxtbox.Location = new Point(577, 86);
            middlenameTxtbox.Name = "middlenameTxtbox";
            middlenameTxtbox.Size = new Size(204, 27);
            middlenameTxtbox.TabIndex = 9;
            // 
            // middlenameLbl
            // 
            middlenameLbl.AutoSize = true;
            middlenameLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middlenameLbl.Location = new Point(577, 63);
            middlenameLbl.Name = "middlenameLbl";
            middlenameLbl.Size = new Size(100, 20);
            middlenameLbl.TabIndex = 8;
            middlenameLbl.Text = "Middle name:";
            // 
            // firstnameTxtbox
            // 
            firstnameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnameTxtbox.Location = new Point(309, 86);
            firstnameTxtbox.Name = "firstnameTxtbox";
            firstnameTxtbox.Size = new Size(244, 27);
            firstnameTxtbox.TabIndex = 7;
            // 
            // firstnameLbl
            // 
            firstnameLbl.AutoSize = true;
            firstnameLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnameLbl.Location = new Point(309, 63);
            firstnameLbl.Name = "firstnameLbl";
            firstnameLbl.Size = new Size(80, 20);
            firstnameLbl.TabIndex = 6;
            firstnameLbl.Text = "First name:";
            // 
            // ageTxtbox
            // 
            ageTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageTxtbox.Location = new Point(3, 154);
            ageTxtbox.Name = "ageTxtbox";
            ageTxtbox.Size = new Size(187, 27);
            ageTxtbox.TabIndex = 5;
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageLbl.Location = new Point(3, 131);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(39, 20);
            ageLbl.TabIndex = 4;
            ageLbl.Text = "Age:";
            // 
            // lastnameTxtbox
            // 
            lastnameTxtbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnameTxtbox.Location = new Point(3, 86);
            lastnameTxtbox.Name = "lastnameTxtbox";
            lastnameTxtbox.Size = new Size(278, 27);
            lastnameTxtbox.TabIndex = 3;
            // 
            // lastnameLbl
            // 
            lastnameLbl.AutoSize = true;
            lastnameLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnameLbl.Location = new Point(3, 63);
            lastnameLbl.Name = "lastnameLbl";
            lastnameLbl.Size = new Size(79, 20);
            lastnameLbl.TabIndex = 2;
            lastnameLbl.Text = "Last name:";
            // 
            // studentIDTextbox
            // 
            studentIDTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentIDTextbox.Location = new Point(3, 23);
            studentIDTextbox.Name = "studentIDTextbox";
            studentIDTextbox.Size = new Size(244, 27);
            studentIDTextbox.TabIndex = 1;
            // 
            // studentIDLbl
            // 
            studentIDLbl.AutoSize = true;
            studentIDLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentIDLbl.Location = new Point(3, 0);
            studentIDLbl.Name = "studentIDLbl";
            studentIDLbl.Size = new Size(82, 20);
            studentIDLbl.TabIndex = 0;
            studentIDLbl.Text = "Student ID:";
            // 
            // listOfClubMembersPanel
            // 
            listOfClubMembersPanel.BorderStyle = BorderStyle.FixedSingle;
            listOfClubMembersPanel.Controls.Add(refreshBtn);
            listOfClubMembersPanel.Controls.Add(table);
            listOfClubMembersPanel.Controls.Add(listOfClubMembersLbl);
            listOfClubMembersPanel.Location = new Point(12, 240);
            listOfClubMembersPanel.Name = "listOfClubMembersPanel";
            listOfClubMembersPanel.Size = new Size(942, 250);
            listOfClubMembersPanel.TabIndex = 1;
            // 
            // refreshBtn
            // 
            refreshBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.Location = new Point(848, 23);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(94, 34);
            refreshBtn.TabIndex = 4;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(4, 23);
            table.Name = "table";
            table.Size = new Size(829, 223);
            table.TabIndex = 3;
            // 
            // listOfClubMembersLbl
            // 
            listOfClubMembersLbl.AutoSize = true;
            listOfClubMembersLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listOfClubMembersLbl.Location = new Point(3, 0);
            listOfClubMembersLbl.Name = "listOfClubMembersLbl";
            listOfClubMembersLbl.Size = new Size(151, 20);
            listOfClubMembersLbl.TabIndex = 2;
            listOfClubMembersLbl.Text = "List Of Club Members";
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.Location = new Point(863, 12);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(94, 34);
            registerBtn.TabIndex = 2;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(863, 52);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 34);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 499);
            Controls.Add(updateBtn);
            Controls.Add(registerBtn);
            Controls.Add(listOfClubMembersPanel);
            Controls.Add(fieldsPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClubRegistration";
            fieldsPanel.ResumeLayout(false);
            fieldsPanel.PerformLayout();
            listOfClubMembersPanel.ResumeLayout(false);
            listOfClubMembersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel fieldsPanel;
        private TextBox studentIDTextbox;
        private Label studentIDLbl;
        private Label genderLbl;
        private TextBox middlenameTxtbox;
        private Label middlenameLbl;
        private TextBox firstnameTxtbox;
        private Label firstnameLbl;
        private TextBox ageTxtbox;
        private Label ageLbl;
        private TextBox lastnameTxtbox;
        private Label lastnameLbl;
        private ComboBox programCombobox;
        private Label programLbl;
        private ComboBox genderCombobox;
        private Panel listOfClubMembersPanel;
        private Button refreshBtn;
        private DataGridView table;
        private Label listOfClubMembersLbl;
        private Button registerBtn;
        private Button updateBtn;
    }
}
