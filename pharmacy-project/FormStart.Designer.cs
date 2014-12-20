namespace cs322_projekat_pharmacy
{
    partial class form_dashboard
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
            this.l_response = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.pnl_userInfo = new System.Windows.Forms.Panel();
            this.pb_systemLogo = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_license = new System.Windows.Forms.Label();
            this.lbl_loggedAs = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.pnl_userLogin = new System.Windows.Forms.Panel();
            this.pnl_userDashboard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_porudzbine = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_dobavljaci = new System.Windows.Forms.Button();
            this.btn_lekovi = new System.Windows.Forms.Button();
            this.btn_employeeRemove = new System.Windows.Forms.Button();
            this.btn_radnici = new System.Windows.Forms.Button();
            this.btn_employeeAdd = new System.Windows.Forms.Button();
            this.pnl_userInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_systemLogo)).BeginInit();
            this.pnl_userLogin.SuspendLayout();
            this.pnl_userDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_response
            // 
            this.l_response.AutoSize = true;
            this.l_response.BackColor = System.Drawing.Color.Transparent;
            this.l_response.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_response.Location = new System.Drawing.Point(69, 153);
            this.l_response.Name = "l_response";
            this.l_response.Size = new System.Drawing.Size(0, 16);
            this.l_response.TabIndex = 5;
            // 
            // l_password
            // 
            this.l_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_password.AutoSize = true;
            this.l_password.BackColor = System.Drawing.Color.Transparent;
            this.l_password.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password.Location = new System.Drawing.Point(69, 78);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(51, 16);
            this.l_password.TabIndex = 4;
            this.l_password.Text = "Lozinka:";
            // 
            // l_username
            // 
            this.l_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_username.AutoSize = true;
            this.l_username.BackColor = System.Drawing.Color.Transparent;
            this.l_username.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_username.Location = new System.Drawing.Point(69, 34);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(84, 16);
            this.l_username.TabIndex = 3;
            this.l_username.Text = "Korisničko ime:";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(72, 124);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(138, 26);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Uloguj se";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.login);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_password.Location = new System.Drawing.Point(72, 94);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(138, 20);
            this.tb_password.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_username.Location = new System.Drawing.Point(72, 50);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(138, 20);
            this.tb_username.TabIndex = 0;
            // 
            // pnl_userInfo
            // 
            this.pnl_userInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnl_userInfo.Controls.Add(this.pb_systemLogo);
            this.pnl_userInfo.Controls.Add(this.lbl_date);
            this.pnl_userInfo.Controls.Add(this.lbl_license);
            this.pnl_userInfo.Controls.Add(this.lbl_loggedAs);
            this.pnl_userInfo.Controls.Add(this.lbl_fullname);
            this.pnl_userInfo.Location = new System.Drawing.Point(12, 12);
            this.pnl_userInfo.Name = "pnl_userInfo";
            this.pnl_userInfo.Size = new System.Drawing.Size(760, 144);
            this.pnl_userInfo.TabIndex = 6;
            this.pnl_userInfo.Visible = false;
            // 
            // pb_systemLogo
            // 
            this.pb_systemLogo.BackgroundImage = global::cs322_projekat_pharmacy.Properties.Resources.snelaxys_logo;
            this.pb_systemLogo.Image = global::cs322_projekat_pharmacy.Properties.Resources.snelaxys_logo;
            this.pb_systemLogo.Location = new System.Drawing.Point(415, 30);
            this.pb_systemLogo.Name = "pb_systemLogo";
            this.pb_systemLogo.Size = new System.Drawing.Size(317, 90);
            this.pb_systemLogo.TabIndex = 4;
            this.pb_systemLogo.TabStop = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Trebuchet MS", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_date.Location = new System.Drawing.Point(26, 74);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(122, 18);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Datum logovanja: ";
            // 
            // lbl_license
            // 
            this.lbl_license.AutoSize = true;
            this.lbl_license.Font = new System.Drawing.Font("Trebuchet MS", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_license.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_license.Location = new System.Drawing.Point(26, 110);
            this.lbl_license.Name = "lbl_license";
            this.lbl_license.Size = new System.Drawing.Size(92, 18);
            this.lbl_license.TabIndex = 2;
            this.lbl_license.Text = "Broj licence: ";
            // 
            // lbl_loggedAs
            // 
            this.lbl_loggedAs.AutoSize = true;
            this.lbl_loggedAs.Font = new System.Drawing.Font("Trebuchet MS", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedAs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_loggedAs.Location = new System.Drawing.Point(26, 92);
            this.lbl_loggedAs.Name = "lbl_loggedAs";
            this.lbl_loggedAs.Size = new System.Drawing.Size(100, 18);
            this.lbl_loggedAs.TabIndex = 1;
            this.lbl_loggedAs.Text = "Ulogovan kao: ";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Trebuchet MS", 32.25F);
            this.lbl_fullname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_fullname.Location = new System.Drawing.Point(20, 20);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(0, 54);
            this.lbl_fullname.TabIndex = 0;
            // 
            // pnl_userLogin
            // 
            this.pnl_userLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnl_userLogin.Controls.Add(this.l_username);
            this.pnl_userLogin.Controls.Add(this.tb_username);
            this.pnl_userLogin.Controls.Add(this.l_response);
            this.pnl_userLogin.Controls.Add(this.tb_password);
            this.pnl_userLogin.Controls.Add(this.l_password);
            this.pnl_userLogin.Controls.Add(this.btn_login);
            this.pnl_userLogin.Location = new System.Drawing.Point(253, 162);
            this.pnl_userLogin.Name = "pnl_userLogin";
            this.pnl_userLogin.Size = new System.Drawing.Size(279, 182);
            this.pnl_userLogin.TabIndex = 7;
            // 
            // pnl_userDashboard
            // 
            this.pnl_userDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnl_userDashboard.Controls.Add(this.button1);
            this.pnl_userDashboard.Controls.Add(this.btn_porudzbine);
            this.pnl_userDashboard.Controls.Add(this.btn_exit);
            this.pnl_userDashboard.Controls.Add(this.btn_dobavljaci);
            this.pnl_userDashboard.Controls.Add(this.btn_lekovi);
            this.pnl_userDashboard.Controls.Add(this.btn_employeeRemove);
            this.pnl_userDashboard.Controls.Add(this.btn_radnici);
            this.pnl_userDashboard.Controls.Add(this.btn_employeeAdd);
            this.pnl_userDashboard.Location = new System.Drawing.Point(12, 165);
            this.pnl_userDashboard.Name = "pnl_userDashboard";
            this.pnl_userDashboard.Size = new System.Drawing.Size(760, 328);
            this.pnl_userDashboard.TabIndex = 8;
            this.pnl_userDashboard.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(29, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "RAČUNI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.manageFrames);
            // 
            // btn_porudzbine
            // 
            this.btn_porudzbine.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_porudzbine.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_porudzbine.Location = new System.Drawing.Point(526, 112);
            this.btn_porudzbine.Name = "btn_porudzbine";
            this.btn_porudzbine.Size = new System.Drawing.Size(206, 114);
            this.btn_porudzbine.TabIndex = 6;
            this.btn_porudzbine.Text = "PORUDŽBINE";
            this.btn_porudzbine.UseVisualStyleBackColor = true;
            this.btn_porudzbine.Click += new System.EventHandler(this.manageFrames);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_exit.Location = new System.Drawing.Point(526, 232);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(206, 65);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "IZLAZ >";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.manageFrames);
            // 
            // btn_dobavljaci
            // 
            this.btn_dobavljaci.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dobavljaci.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_dobavljaci.Location = new System.Drawing.Point(526, 41);
            this.btn_dobavljaci.Name = "btn_dobavljaci";
            this.btn_dobavljaci.Size = new System.Drawing.Size(206, 65);
            this.btn_dobavljaci.TabIndex = 4;
            this.btn_dobavljaci.Text = "DOBAVLJAČI";
            this.btn_dobavljaci.UseVisualStyleBackColor = true;
            this.btn_dobavljaci.Click += new System.EventHandler(this.manageFrames);
            // 
            // btn_lekovi
            // 
            this.btn_lekovi.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lekovi.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_lekovi.Location = new System.Drawing.Point(241, 41);
            this.btn_lekovi.Name = "btn_lekovi";
            this.btn_lekovi.Size = new System.Drawing.Size(279, 185);
            this.btn_lekovi.TabIndex = 3;
            this.btn_lekovi.Text = "PRIKAŽI LEKOVE";
            this.btn_lekovi.UseVisualStyleBackColor = true;
            this.btn_lekovi.Click += new System.EventHandler(this.manageFrames);
            // 
            // btn_employeeRemove
            // 
            this.btn_employeeRemove.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employeeRemove.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_employeeRemove.Location = new System.Drawing.Point(134, 41);
            this.btn_employeeRemove.Name = "btn_employeeRemove";
            this.btn_employeeRemove.Size = new System.Drawing.Size(101, 65);
            this.btn_employeeRemove.TabIndex = 2;
            this.btn_employeeRemove.Text = "UKLONI RADNIKA";
            this.btn_employeeRemove.UseVisualStyleBackColor = true;
            this.btn_employeeRemove.Click += new System.EventHandler(this.manageFrames);
            // 
            // btn_radnici
            // 
            this.btn_radnici.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_radnici.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_radnici.Location = new System.Drawing.Point(29, 112);
            this.btn_radnici.Name = "btn_radnici";
            this.btn_radnici.Size = new System.Drawing.Size(206, 114);
            this.btn_radnici.TabIndex = 1;
            this.btn_radnici.Text = "PRIKAŽI RADNIKE";
            this.btn_radnici.UseVisualStyleBackColor = true;
            this.btn_radnici.Click += new System.EventHandler(this.manageFrames);
            // 
            // btn_employeeAdd
            // 
            this.btn_employeeAdd.Font = new System.Drawing.Font("Trebuchet MS", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employeeAdd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_employeeAdd.Location = new System.Drawing.Point(29, 41);
            this.btn_employeeAdd.Name = "btn_employeeAdd";
            this.btn_employeeAdd.Size = new System.Drawing.Size(99, 65);
            this.btn_employeeAdd.TabIndex = 0;
            this.btn_employeeAdd.Text = "DODAJ RADNIKA";
            this.btn_employeeAdd.UseVisualStyleBackColor = true;
            this.btn_employeeAdd.Click += new System.EventHandler(this.manageFrames);
            // 
            // form_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cs322_projekat_pharmacy.Properties.Resources.gray_background;
            this.ClientSize = new System.Drawing.Size(784, 505);
            this.Controls.Add(this.pnl_userLogin);
            this.Controls.Add(this.pnl_userDashboard);
            this.Controls.Add(this.pnl_userInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy App";
            this.pnl_userInfo.ResumeLayout(false);
            this.pnl_userInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_systemLogo)).EndInit();
            this.pnl_userLogin.ResumeLayout(false);
            this.pnl_userLogin.PerformLayout();
            this.pnl_userDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.Label l_response;
        private System.Windows.Forms.Panel pnl_userInfo;
        private System.Windows.Forms.Label lbl_license;
        private System.Windows.Forms.Label lbl_loggedAs;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel pnl_userLogin;
        private System.Windows.Forms.PictureBox pb_systemLogo;
        private System.Windows.Forms.Panel pnl_userDashboard;
        private System.Windows.Forms.Button btn_employeeAdd;
        private System.Windows.Forms.Button btn_radnici;
        private System.Windows.Forms.Button btn_employeeRemove;
        private System.Windows.Forms.Button btn_dobavljaci;
        private System.Windows.Forms.Button btn_lekovi;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_porudzbine;
        private System.Windows.Forms.Button button1;

    }
}

