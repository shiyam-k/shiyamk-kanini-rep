namespace Window_Froms_18_04_2023
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
            this.entryPanel = new System.Windows.Forms.Panel();
            this.entryOp = new System.Windows.Forms.Label();
            this.loginRegisterRadio = new System.Windows.Forms.Panel();
            this.loginRadio = new System.Windows.Forms.RadioButton();
            this.registerRadio = new System.Windows.Forms.RadioButton();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.Label();
            this.registerUserName = new System.Windows.Forms.TextBox();
            this.registerUserNameLabel = new System.Windows.Forms.Label();
            this.registerEmailLabel = new System.Windows.Forms.Label();
            this.registerEmailPassword = new System.Windows.Forms.Label();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Label();
            this.loginEmailPassword = new System.Windows.Forms.Label();
            this.loginpasswordPanel = new System.Windows.Forms.Label();
            this.loginEmail = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.updateStatus = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.profileUpdate = new System.Windows.Forms.Button();
            this.updateProfile = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.profilePassword = new System.Windows.Forms.Label();
            this.profileUserName = new System.Windows.Forms.Label();
            this.viewProfile = new System.Windows.Forms.Button();
            this.profileSessionId = new System.Windows.Forms.Label();
            this.profileEmail = new System.Windows.Forms.Label();
            this.moviePanel = new System.Windows.Forms.Panel();
            this.movieDirector = new System.Windows.Forms.Label();
            this.movieCast = new System.Windows.Forms.Label();
            this.moviePlot = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.moviePlotLabel = new System.Windows.Forms.Label();
            this.movieCastLabel = new System.Windows.Forms.Label();
            this.movieDirectorLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.entryPanel.SuspendLayout();
            this.loginRegisterRadio.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.profilePanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.moviePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryOp);
            this.entryPanel.Controls.Add(this.loginRegisterRadio);
            this.entryPanel.Controls.Add(this.registerPanel);
            this.entryPanel.Controls.Add(this.loginPanel);
            this.entryPanel.Location = new System.Drawing.Point(321, 1);
            this.entryPanel.Name = "entryPanel";
            this.entryPanel.Size = new System.Drawing.Size(564, 273);
            this.entryPanel.TabIndex = 18;
            this.entryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.entryPanel_Paint);
            // 
            // entryOp
            // 
            this.entryOp.AutoSize = true;
            this.entryOp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryOp.ForeColor = System.Drawing.SystemColors.Control;
            this.entryOp.Location = new System.Drawing.Point(222, 240);
            this.entryOp.Name = "entryOp";
            this.entryOp.Size = new System.Drawing.Size(0, 16);
            this.entryOp.TabIndex = 17;
            // 
            // loginRegisterRadio
            // 
            this.loginRegisterRadio.Controls.Add(this.loginRadio);
            this.loginRegisterRadio.Controls.Add(this.registerRadio);
            this.loginRegisterRadio.Location = new System.Drawing.Point(94, 15);
            this.loginRegisterRadio.Name = "loginRegisterRadio";
            this.loginRegisterRadio.Size = new System.Drawing.Size(355, 38);
            this.loginRegisterRadio.TabIndex = 16;
            // 
            // loginRadio
            // 
            this.loginRadio.AutoSize = true;
            this.loginRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginRadio.Location = new System.Drawing.Point(24, 11);
            this.loginRadio.Name = "loginRadio";
            this.loginRadio.Size = new System.Drawing.Size(61, 20);
            this.loginRadio.TabIndex = 14;
            this.loginRadio.TabStop = true;
            this.loginRadio.Text = "Login";
            this.loginRadio.UseVisualStyleBackColor = true;
            this.loginRadio.CheckedChanged += new System.EventHandler(this.loginRadio_CheckedChanged);
            // 
            // registerRadio
            // 
            this.registerRadio.AutoSize = true;
            this.registerRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerRadio.Location = new System.Drawing.Point(244, 11);
            this.registerRadio.Name = "registerRadio";
            this.registerRadio.Size = new System.Drawing.Size(79, 20);
            this.registerRadio.TabIndex = 15;
            this.registerRadio.TabStop = true;
            this.registerRadio.Text = "Register";
            this.registerRadio.UseVisualStyleBackColor = true;
            this.registerRadio.CheckedChanged += new System.EventHandler(this.RegisterRadio_CheckedChanged);
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.register);
            this.registerPanel.Controls.Add(this.registerUserName);
            this.registerPanel.Controls.Add(this.registerUserNameLabel);
            this.registerPanel.Controls.Add(this.registerEmailLabel);
            this.registerPanel.Controls.Add(this.registerEmailPassword);
            this.registerPanel.Controls.Add(this.registerEmail);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Controls.Add(this.registerPassword);
            this.registerPanel.Location = new System.Drawing.Point(273, 59);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(288, 172);
            this.registerPanel.TabIndex = 11;
            this.registerPanel.Visible = false;
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register.Location = new System.Drawing.Point(83, 0);
            this.register.Name = "register";
            this.register.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.register.Size = new System.Drawing.Size(88, 22);
            this.register.TabIndex = 13;
            this.register.Text = "Register";
            // 
            // registerUserName
            // 
            this.registerUserName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.registerUserName.Location = new System.Drawing.Point(103, 97);
            this.registerUserName.Name = "registerUserName";
            this.registerUserName.Size = new System.Drawing.Size(170, 22);
            this.registerUserName.TabIndex = 12;
            this.registerUserName.UseSystemPasswordChar = true;
            this.registerUserName.TextChanged += new System.EventHandler(this.registerUserName_TextChanged);
            // 
            // registerUserNameLabel
            // 
            this.registerUserNameLabel.AutoSize = true;
            this.registerUserNameLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registerUserNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerUserNameLabel.Location = new System.Drawing.Point(21, 97);
            this.registerUserNameLabel.Name = "registerUserNameLabel";
            this.registerUserNameLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.registerUserNameLabel.Size = new System.Drawing.Size(76, 22);
            this.registerUserNameLabel.TabIndex = 11;
            this.registerUserNameLabel.Text = "User Name";
            // 
            // registerEmailLabel
            // 
            this.registerEmailLabel.AutoSize = true;
            this.registerEmailLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registerEmailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerEmailLabel.Location = new System.Drawing.Point(31, 31);
            this.registerEmailLabel.Name = "registerEmailLabel";
            this.registerEmailLabel.Padding = new System.Windows.Forms.Padding(0, 3, 25, 3);
            this.registerEmailLabel.Size = new System.Drawing.Size(66, 22);
            this.registerEmailLabel.TabIndex = 8;
            this.registerEmailLabel.Text = "Email";
            // 
            // registerEmailPassword
            // 
            this.registerEmailPassword.AutoSize = true;
            this.registerEmailPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registerEmailPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerEmailPassword.Location = new System.Drawing.Point(30, 65);
            this.registerEmailPassword.Name = "registerEmailPassword";
            this.registerEmailPassword.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.registerEmailPassword.Size = new System.Drawing.Size(67, 22);
            this.registerEmailPassword.TabIndex = 10;
            this.registerEmailPassword.Text = "Password";
            // 
            // registerEmail
            // 
            this.registerEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.registerEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.registerEmail.Location = new System.Drawing.Point(103, 31);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(170, 22);
            this.registerEmail.TabIndex = 1;
            this.registerEmail.UseWaitCursor = true;
            this.registerEmail.TextChanged += new System.EventHandler(this.registerEmail_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.AccessibleName = "";
            this.registerButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.registerButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerButton.Location = new System.Drawing.Point(77, 125);
            this.registerButton.Name = "registerButton";
            this.registerButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.registerButton.Size = new System.Drawing.Size(94, 32);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerPassword
            // 
            this.registerPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.registerPassword.Location = new System.Drawing.Point(103, 65);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(170, 22);
            this.registerPassword.TabIndex = 4;
            this.registerPassword.UseSystemPasswordChar = true;
            this.registerPassword.TextChanged += new System.EventHandler(this.registerPassword_TextChanged);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Controls.Add(this.loginEmailPassword);
            this.loginPanel.Controls.Add(this.loginpasswordPanel);
            this.loginPanel.Controls.Add(this.loginEmail);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginPassword);
            this.loginPanel.Location = new System.Drawing.Point(3, 59);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(264, 136);
            this.loginPanel.TabIndex = 12;
            this.loginPanel.Visible = false;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Location = new System.Drawing.Point(117, 0);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.login.Size = new System.Drawing.Size(60, 22);
            this.login.TabIndex = 11;
            this.login.Text = "Login";
            // 
            // loginEmailPassword
            // 
            this.loginEmailPassword.AutoSize = true;
            this.loginEmailPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginEmailPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginEmailPassword.Location = new System.Drawing.Point(18, 29);
            this.loginEmailPassword.Name = "loginEmailPassword";
            this.loginEmailPassword.Padding = new System.Windows.Forms.Padding(0, 3, 25, 3);
            this.loginEmailPassword.Size = new System.Drawing.Size(66, 22);
            this.loginEmailPassword.TabIndex = 8;
            this.loginEmailPassword.Text = "Email";
            // 
            // loginpasswordPanel
            // 
            this.loginpasswordPanel.AutoSize = true;
            this.loginpasswordPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginpasswordPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginpasswordPanel.Location = new System.Drawing.Point(18, 62);
            this.loginpasswordPanel.Name = "loginpasswordPanel";
            this.loginpasswordPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.loginpasswordPanel.Size = new System.Drawing.Size(67, 22);
            this.loginpasswordPanel.TabIndex = 10;
            this.loginpasswordPanel.Text = "Password";
            // 
            // loginEmail
            // 
            this.loginEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.loginEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginEmail.Location = new System.Drawing.Point(90, 31);
            this.loginEmail.Name = "loginEmail";
            this.loginEmail.Size = new System.Drawing.Size(170, 22);
            this.loginEmail.TabIndex = 1;
            this.loginEmail.UseWaitCursor = true;
            this.loginEmail.TextChanged += new System.EventHandler(this.loginEmail_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "";
            this.loginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.loginButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(91, 90);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 32);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPassword
            // 
            this.loginPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginPassword.Location = new System.Drawing.Point(91, 62);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(170, 22);
            this.loginPassword.TabIndex = 4;
            this.loginPassword.UseSystemPasswordChar = true;
            this.loginPassword.TextChanged += new System.EventHandler(this.loginPassword_TextChanged);
            // 
            // profilepic
            // 
            this.profilepic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("profilepic.ErrorImage")));
            this.profilepic.Location = new System.Drawing.Point(0, 45);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(96, 92);
            this.profilepic.TabIndex = 19;
            this.profilepic.TabStop = false;
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.updateStatus);
            this.profilePanel.Controls.Add(this.updatePanel);
            this.profilePanel.Controls.Add(this.searchLabel);
            this.profilePanel.Controls.Add(this.searchButton);
            this.profilePanel.Controls.Add(this.searchBox);
            this.profilePanel.Controls.Add(this.profilePassword);
            this.profilePanel.Controls.Add(this.profileUserName);
            this.profilePanel.Controls.Add(this.viewProfile);
            this.profilePanel.Controls.Add(this.profileSessionId);
            this.profilePanel.Controls.Add(this.profileEmail);
            this.profilePanel.Controls.Add(this.profilepic);
            this.profilePanel.Location = new System.Drawing.Point(12, 4);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1066, 238);
            this.profilePanel.TabIndex = 20;
            this.profilePanel.Visible = false;
            // 
            // updateStatus
            // 
            this.updateStatus.AutoSize = true;
            this.updateStatus.Location = new System.Drawing.Point(75, 211);
            this.updateStatus.Name = "updateStatus";
            this.updateStatus.Size = new System.Drawing.Size(0, 16);
            this.updateStatus.TabIndex = 30;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.profileUpdate);
            this.updatePanel.Controls.Add(this.updateProfile);
            this.updatePanel.Location = new System.Drawing.Point(48, 168);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(268, 40);
            this.updatePanel.TabIndex = 29;
            this.updatePanel.Visible = false;
            // 
            // profileUpdate
            // 
            this.profileUpdate.AccessibleName = "";
            this.profileUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.profileUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.profileUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.profileUpdate.Location = new System.Drawing.Point(144, 8);
            this.profileUpdate.Name = "profileUpdate";
            this.profileUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.profileUpdate.Size = new System.Drawing.Size(121, 32);
            this.profileUpdate.TabIndex = 29;
            this.profileUpdate.Text = "Update";
            this.profileUpdate.UseVisualStyleBackColor = false;
            this.profileUpdate.Click += new System.EventHandler(this.profileUpdate_Click);
            // 
            // updateProfile
            // 
            this.updateProfile.Location = new System.Drawing.Point(3, 15);
            this.updateProfile.Name = "updateProfile";
            this.updateProfile.Size = new System.Drawing.Size(144, 22);
            this.updateProfile.TabIndex = 28;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.searchLabel.Location = new System.Drawing.Point(492, 42);
            this.searchLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.searchLabel.Size = new System.Drawing.Size(131, 22);
            this.searchLabel.TabIndex = 27;
            this.searchLabel.Text = "Search a Movie";
            // 
            // searchButton
            // 
            this.searchButton.AccessibleName = "";
            this.searchButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.searchButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(622, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchButton.Size = new System.Drawing.Size(70, 32);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Go";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.searchBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchBox.Location = new System.Drawing.Point(453, 74);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(170, 22);
            this.searchBox.TabIndex = 25;
            this.searchBox.UseWaitCursor = true;
            // 
            // profilePassword
            // 
            this.profilePassword.AutoSize = true;
            this.profilePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.profilePassword.Location = new System.Drawing.Point(126, 143);
            this.profilePassword.MaximumSize = new System.Drawing.Size(500, 500);
            this.profilePassword.Name = "profilePassword";
            this.profilePassword.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.profilePassword.Size = new System.Drawing.Size(106, 22);
            this.profilePassword.TabIndex = 24;
            this.profilePassword.Text = "Password : ";
            this.profilePassword.Click += new System.EventHandler(this.profilePassword_Click);
            // 
            // profileUserName
            // 
            this.profileUserName.AutoSize = true;
            this.profileUserName.BackColor = System.Drawing.SystemColors.Highlight;
            this.profileUserName.Location = new System.Drawing.Point(126, 111);
            this.profileUserName.MaximumSize = new System.Drawing.Size(500, 500);
            this.profileUserName.Name = "profileUserName";
            this.profileUserName.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.profileUserName.Size = new System.Drawing.Size(115, 22);
            this.profileUserName.TabIndex = 23;
            this.profileUserName.Text = "User Name : ";
            this.profileUserName.Click += new System.EventHandler(this.profileUserName_Click);
            // 
            // viewProfile
            // 
            this.viewProfile.AccessibleName = "";
            this.viewProfile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.viewProfile.BackColor = System.Drawing.SystemColors.MenuBar;
            this.viewProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.viewProfile.Location = new System.Drawing.Point(107, 0);
            this.viewProfile.Name = "viewProfile";
            this.viewProfile.Size = new System.Drawing.Size(135, 32);
            this.viewProfile.TabIndex = 21;
            this.viewProfile.Text = "View Profile";
            this.viewProfile.UseVisualStyleBackColor = false;
            this.viewProfile.Click += new System.EventHandler(this.viewProfile_Click);
            // 
            // profileSessionId
            // 
            this.profileSessionId.AutoSize = true;
            this.profileSessionId.BackColor = System.Drawing.SystemColors.Highlight;
            this.profileSessionId.Location = new System.Drawing.Point(126, 77);
            this.profileSessionId.MaximumSize = new System.Drawing.Size(500, 500);
            this.profileSessionId.Name = "profileSessionId";
            this.profileSessionId.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.profileSessionId.Size = new System.Drawing.Size(111, 22);
            this.profileSessionId.TabIndex = 22;
            this.profileSessionId.Text = "Session ID : ";
            this.profileSessionId.Click += new System.EventHandler(this.profileSessionId_Click);
            // 
            // profileEmail
            // 
            this.profileEmail.AutoSize = true;
            this.profileEmail.BackColor = System.Drawing.SystemColors.Highlight;
            this.profileEmail.Location = new System.Drawing.Point(126, 45);
            this.profileEmail.MaximumSize = new System.Drawing.Size(500, 500);
            this.profileEmail.Name = "profileEmail";
            this.profileEmail.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.profileEmail.Size = new System.Drawing.Size(80, 22);
            this.profileEmail.TabIndex = 20;
            this.profileEmail.Text = "Email : ";
            this.profileEmail.Click += new System.EventHandler(this.profileEmail_Click);
            // 
            // moviePanel
            // 
            this.moviePanel.Controls.Add(this.movieDirector);
            this.moviePanel.Controls.Add(this.movieCast);
            this.moviePanel.Controls.Add(this.moviePlot);
            this.moviePanel.Controls.Add(this.movieName);
            this.moviePanel.Controls.Add(this.moviePlotLabel);
            this.moviePanel.Controls.Add(this.movieCastLabel);
            this.moviePanel.Controls.Add(this.movieDirectorLabel);
            this.moviePanel.Controls.Add(this.movieNameLabel);
            this.moviePanel.Location = new System.Drawing.Point(162, 280);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(576, 166);
            this.moviePanel.TabIndex = 28;
            this.moviePanel.Visible = false;
            // 
            // movieDirector
            // 
            this.movieDirector.AutoSize = true;
            this.movieDirector.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movieDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieDirector.Location = new System.Drawing.Point(128, 51);
            this.movieDirector.MaximumSize = new System.Drawing.Size(500, 500);
            this.movieDirector.Name = "movieDirector";
            this.movieDirector.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.movieDirector.Size = new System.Drawing.Size(30, 22);
            this.movieDirector.TabIndex = 32;
            // 
            // movieCast
            // 
            this.movieCast.AutoSize = true;
            this.movieCast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movieCast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieCast.Location = new System.Drawing.Point(128, 89);
            this.movieCast.MaximumSize = new System.Drawing.Size(500, 500);
            this.movieCast.Name = "movieCast";
            this.movieCast.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.movieCast.Size = new System.Drawing.Size(30, 22);
            this.movieCast.TabIndex = 31;
            // 
            // moviePlot
            // 
            this.moviePlot.AutoSize = true;
            this.moviePlot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moviePlot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moviePlot.Location = new System.Drawing.Point(128, 127);
            this.moviePlot.MaximumSize = new System.Drawing.Size(500, 500);
            this.moviePlot.Name = "moviePlot";
            this.moviePlot.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.moviePlot.Size = new System.Drawing.Size(30, 22);
            this.moviePlot.TabIndex = 30;
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movieName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieName.Location = new System.Drawing.Point(128, 19);
            this.movieName.MaximumSize = new System.Drawing.Size(500, 500);
            this.movieName.Name = "movieName";
            this.movieName.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.movieName.Size = new System.Drawing.Size(30, 22);
            this.movieName.TabIndex = 29;
            // 
            // moviePlotLabel
            // 
            this.moviePlotLabel.AutoSize = true;
            this.moviePlotLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.moviePlotLabel.Location = new System.Drawing.Point(30, 127);
            this.moviePlotLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.moviePlotLabel.Name = "moviePlotLabel";
            this.moviePlotLabel.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.moviePlotLabel.Size = new System.Drawing.Size(69, 22);
            this.moviePlotLabel.TabIndex = 28;
            this.moviePlotLabel.Text = "Plot : ";
            // 
            // movieCastLabel
            // 
            this.movieCastLabel.AutoSize = true;
            this.movieCastLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.movieCastLabel.Location = new System.Drawing.Point(30, 89);
            this.movieCastLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.movieCastLabel.Name = "movieCastLabel";
            this.movieCastLabel.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.movieCastLabel.Size = new System.Drawing.Size(73, 22);
            this.movieCastLabel.TabIndex = 27;
            this.movieCastLabel.Text = "Cast : ";
            // 
            // movieDirectorLabel
            // 
            this.movieDirectorLabel.AutoSize = true;
            this.movieDirectorLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.movieDirectorLabel.Location = new System.Drawing.Point(26, 51);
            this.movieDirectorLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.movieDirectorLabel.Name = "movieDirectorLabel";
            this.movieDirectorLabel.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.movieDirectorLabel.Size = new System.Drawing.Size(87, 22);
            this.movieDirectorLabel.TabIndex = 26;
            this.movieDirectorLabel.Text = "Director ";
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.movieNameLabel.Location = new System.Drawing.Point(28, 19);
            this.movieNameLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.movieNameLabel.Size = new System.Drawing.Size(83, 22);
            this.movieNameLabel.TabIndex = 25;
            this.movieNameLabel.Text = "Movie : ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(629, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1177, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moviePanel);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.entryPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "View Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.entryPanel.ResumeLayout(false);
            this.entryPanel.PerformLayout();
            this.loginRegisterRadio.ResumeLayout(false);
            this.loginRegisterRadio.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.moviePanel.ResumeLayout(false);
            this.moviePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel entryPanel;
        private System.Windows.Forms.Panel loginRegisterRadio;
        private System.Windows.Forms.RadioButton loginRadio;
        private System.Windows.Forms.RadioButton registerRadio;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.TextBox registerUserName;
        private System.Windows.Forms.Label registerUserNameLabel;
        private System.Windows.Forms.Label registerEmailLabel;
        private System.Windows.Forms.Label registerEmailPassword;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label loginEmailPassword;
        private System.Windows.Forms.Label loginpasswordPanel;
        private System.Windows.Forms.TextBox loginEmail;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label entryOp;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label profileEmail;
        private System.Windows.Forms.Button viewProfile;
        private System.Windows.Forms.Label profilePassword;
        private System.Windows.Forms.Label profileUserName;
        private System.Windows.Forms.Label profileSessionId;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel moviePanel;
        private System.Windows.Forms.Label moviePlotLabel;
        private System.Windows.Forms.Label movieCastLabel;
        private System.Windows.Forms.Label movieDirectorLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label movieDirector;
        private System.Windows.Forms.Label movieCast;
        private System.Windows.Forms.Label moviePlot;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.TextBox updateProfile;
        private System.Windows.Forms.Button profileUpdate;
        private System.Windows.Forms.Label updateStatus;
        private System.Windows.Forms.Panel panel1;
    }
}

