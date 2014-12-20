namespace cs322_projekat_pharmacy
{
    partial class FormEmployee
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_parahraph = new System.Windows.Forms.Label();
            this.pnl_userAdd = new System.Windows.Forms.Panel();
            this.lbl_response = new System.Windows.Forms.Label();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.tb_licenseNu = new System.Windows.Forms.TextBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_licenseNo = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_userDel = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_removeEmployee = new System.Windows.Forms.Button();
            this.lbl_response2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.cbl_employees = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_employeeList = new System.Windows.Forms.Panel();
            this.btn_exit2 = new System.Windows.Forms.Button();
            this.dgv_employeesList = new System.Windows.Forms.DataGridView();
            this.pnl_userAdd.SuspendLayout();
            this.pnl_userDel.SuspendLayout();
            this.pnl_employeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeesList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Trebuchet MS", 28.25F);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(290, 49);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Korisnički panel";
            // 
            // lbl_parahraph
            // 
            this.lbl_parahraph.AutoSize = true;
            this.lbl_parahraph.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parahraph.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parahraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_parahraph.Location = new System.Drawing.Point(18, 58);
            this.lbl_parahraph.Name = "lbl_parahraph";
            this.lbl_parahraph.Size = new System.Drawing.Size(191, 18);
            this.lbl_parahraph.TabIndex = 4;
            this.lbl_parahraph.Text = "Dodavanje/uklanjanje radnika ";
            // 
            // pnl_userAdd
            // 
            this.pnl_userAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnl_userAdd.Controls.Add(this.lbl_response);
            this.pnl_userAdd.Controls.Add(this.btn_addEmployee);
            this.pnl_userAdd.Controls.Add(this.tb_licenseNu);
            this.pnl_userAdd.Controls.Add(this.tb_userName);
            this.pnl_userAdd.Controls.Add(this.tb_lastName);
            this.pnl_userAdd.Controls.Add(this.tb_name);
            this.pnl_userAdd.Controls.Add(this.lbl_licenseNo);
            this.pnl_userAdd.Controls.Add(this.lbl_userName);
            this.pnl_userAdd.Controls.Add(this.lbl_lastName);
            this.pnl_userAdd.Controls.Add(this.lbl_name);
            this.pnl_userAdd.Location = new System.Drawing.Point(21, 89);
            this.pnl_userAdd.Name = "pnl_userAdd";
            this.pnl_userAdd.Size = new System.Drawing.Size(441, 334);
            this.pnl_userAdd.TabIndex = 5;
            this.pnl_userAdd.Visible = false;
            // 
            // lbl_response
            // 
            this.lbl_response.AutoSize = true;
            this.lbl_response.BackColor = System.Drawing.Color.Transparent;
            this.lbl_response.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.lbl_response.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_response.Location = new System.Drawing.Point(9, 238);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(0, 16);
            this.lbl_response.TabIndex = 14;
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_addEmployee.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmployee.Location = new System.Drawing.Point(6, 279);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(135, 55);
            this.btn_addEmployee.TabIndex = 13;
            this.btn_addEmployee.Text = "Dodaj novog radnika";
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.employeeAdd);
            // 
            // tb_licenseNu
            // 
            this.tb_licenseNu.Location = new System.Drawing.Point(6, 202);
            this.tb_licenseNu.Name = "tb_licenseNu";
            this.tb_licenseNu.Size = new System.Drawing.Size(81, 20);
            this.tb_licenseNu.TabIndex = 12;
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(6, 160);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(151, 20);
            this.tb_userName.TabIndex = 11;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(6, 118);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(151, 20);
            this.tb_lastName.TabIndex = 10;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(6, 77);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(151, 20);
            this.tb_name.TabIndex = 9;
            // 
            // lbl_licenseNo
            // 
            this.lbl_licenseNo.AutoSize = true;
            this.lbl_licenseNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_licenseNo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.lbl_licenseNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_licenseNo.Location = new System.Drawing.Point(3, 183);
            this.lbl_licenseNo.Name = "lbl_licenseNo";
            this.lbl_licenseNo.Size = new System.Drawing.Size(71, 16);
            this.lbl_licenseNo.TabIndex = 8;
            this.lbl_licenseNo.Text = "Broj licence:";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.lbl_userName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_userName.Location = new System.Drawing.Point(3, 141);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(84, 16);
            this.lbl_userName.TabIndex = 7;
            this.lbl_userName.Text = "Korisničko ime:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.lbl_lastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_lastName.Location = new System.Drawing.Point(3, 100);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(47, 16);
            this.lbl_lastName.TabIndex = 6;
            this.lbl_lastName.Text = "Prezime";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_name.Location = new System.Drawing.Point(3, 58);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(30, 16);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Ime:";
            // 
            // pnl_userDel
            // 
            this.pnl_userDel.BackColor = System.Drawing.Color.Transparent;
            this.pnl_userDel.Controls.Add(this.btn_exit);
            this.pnl_userDel.Controls.Add(this.btn_removeEmployee);
            this.pnl_userDel.Controls.Add(this.lbl_response2);
            this.pnl_userDel.Controls.Add(this.label1);
            this.pnl_userDel.Controls.Add(this.lbl_lista);
            this.pnl_userDel.Controls.Add(this.cbl_employees);
            this.pnl_userDel.Location = new System.Drawing.Point(27, 91);
            this.pnl_userDel.Name = "pnl_userDel";
            this.pnl_userDel.Size = new System.Drawing.Size(573, 335);
            this.pnl_userDel.TabIndex = 6;
            this.pnl_userDel.Visible = false;
            this.pnl_userDel.Click += new System.EventHandler(this.employeeRemove);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(441, 286);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(138, 52);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "< Nazad";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.exitForm);
            // 
            // btn_removeEmployee
            // 
            this.btn_removeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_removeEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_removeEmployee.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeEmployee.Location = new System.Drawing.Point(-3, 283);
            this.btn_removeEmployee.Name = "btn_removeEmployee";
            this.btn_removeEmployee.Size = new System.Drawing.Size(138, 52);
            this.btn_removeEmployee.TabIndex = 18;
            this.btn_removeEmployee.Text = "Uklonite radnike";
            this.btn_removeEmployee.UseVisualStyleBackColor = false;
            this.btn_removeEmployee.Click += new System.EventHandler(this.employeeRemove);
            // 
            // lbl_response2
            // 
            this.lbl_response2.AutoSize = true;
            this.lbl_response2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_response2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.lbl_response2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_response2.Location = new System.Drawing.Point(3, 261);
            this.lbl_response2.Name = "lbl_response2";
            this.lbl_response2.Size = new System.Drawing.Size(0, 16);
            this.lbl_response2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(140, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 16;
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lista.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.lbl_lista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_lista.Location = new System.Drawing.Point(-3, 4);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(235, 16);
            this.lbl_lista.TabIndex = 15;
            this.lbl_lista.Text = "Odaberite radnike koji trebaju biti uklonjeni:";
            // 
            // cbl_employees
            // 
            this.cbl_employees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbl_employees.FormattingEnabled = true;
            this.cbl_employees.Location = new System.Drawing.Point(-3, 23);
            this.cbl_employees.Name = "cbl_employees";
            this.cbl_employees.ScrollAlwaysVisible = true;
            this.cbl_employees.Size = new System.Drawing.Size(432, 229);
            this.cbl_employees.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(465, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "< Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.exitForm);
            // 
            // pnl_employeeList
            // 
            this.pnl_employeeList.BackColor = System.Drawing.Color.Transparent;
            this.pnl_employeeList.Controls.Add(this.btn_exit2);
            this.pnl_employeeList.Controls.Add(this.dgv_employeesList);
            this.pnl_employeeList.Location = new System.Drawing.Point(21, 91);
            this.pnl_employeeList.Name = "pnl_employeeList";
            this.pnl_employeeList.Size = new System.Drawing.Size(582, 338);
            this.pnl_employeeList.TabIndex = 16;
            this.pnl_employeeList.Visible = false;
            // 
            // btn_exit2
            // 
            this.btn_exit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit2.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit2.Location = new System.Drawing.Point(447, 286);
            this.btn_exit2.Name = "btn_exit2";
            this.btn_exit2.Size = new System.Drawing.Size(135, 52);
            this.btn_exit2.TabIndex = 20;
            this.btn_exit2.Text = "< Nazad";
            this.btn_exit2.UseVisualStyleBackColor = false;
            this.btn_exit2.Click += new System.EventHandler(this.exitForm);
            // 
            // dgv_employeesList
            // 
            this.dgv_employeesList.AllowUserToAddRows = false;
            this.dgv_employeesList.AllowUserToDeleteRows = false;
            this.dgv_employeesList.AllowUserToResizeColumns = false;
            this.dgv_employeesList.AllowUserToResizeRows = false;
            this.dgv_employeesList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_employeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeesList.Location = new System.Drawing.Point(6, 4);
            this.dgv_employeesList.Name = "dgv_employeesList";
            this.dgv_employeesList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_employeesList.RowTemplate.DefaultCellStyle.NullValue = "Lista je prazna.";
            this.dgv_employeesList.Size = new System.Drawing.Size(573, 276);
            this.dgv_employeesList.TabIndex = 17;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cs322_projekat_pharmacy.Properties.Resources.gray_background_640x480;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pnl_userAdd);
            this.Controls.Add(this.pnl_userDel);
            this.Controls.Add(this.pnl_employeeList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_parahraph);
            this.Controls.Add(this.lbl_title);
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_userAdd.ResumeLayout(false);
            this.pnl_userAdd.PerformLayout();
            this.pnl_userDel.ResumeLayout(false);
            this.pnl_userDel.PerformLayout();
            this.pnl_employeeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_parahraph;
        private System.Windows.Forms.Panel pnl_userAdd;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_userDel;
        private System.Windows.Forms.Label lbl_licenseNo;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox tb_licenseNu;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Label lbl_response;
        private System.Windows.Forms.CheckedListBox cbl_employees;
        private System.Windows.Forms.Label lbl_response2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_employeeList;
        private System.Windows.Forms.DataGridView dgv_employeesList;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_removeEmployee;
        private System.Windows.Forms.Button btn_exit2;
    }
}