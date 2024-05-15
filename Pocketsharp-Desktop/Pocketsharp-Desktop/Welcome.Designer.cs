namespace Pocketsharp_Desktop
{
    partial class Welcome
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
            TabBar = new TabControl();
            WelcomeTab = new TabPage();
            StatusTextBox = new RichTextBox();
            AuthenticationTab = new TabPage();
            groupBox3 = new GroupBox();
            AuthenticationDeleteUserButton = new Button();
            AuthenticationUpdateUserButton = new Button();
            AuthenticationLoginUserButton = new Button();
            AuthenticationRegisterUserButton = new Button();
            CollectionTab = new TabPage();
            SetupTab = new TabPage();
            SetupDeleteSavedButton = new Button();
            groupBox2 = new GroupBox();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            BaseUrlTextBox = new TextBox();
            TabBar.SuspendLayout();
            WelcomeTab.SuspendLayout();
            AuthenticationTab.SuspendLayout();
            groupBox3.SuspendLayout();
            SetupTab.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TabBar
            // 
            TabBar.Controls.Add(WelcomeTab);
            TabBar.Controls.Add(AuthenticationTab);
            TabBar.Controls.Add(CollectionTab);
            TabBar.Controls.Add(SetupTab);
            TabBar.Location = new Point(12, 12);
            TabBar.Name = "TabBar";
            TabBar.SelectedIndex = 0;
            TabBar.Size = new Size(460, 437);
            TabBar.TabIndex = 0;
            // 
            // WelcomeTab
            // 
            WelcomeTab.Controls.Add(StatusTextBox);
            WelcomeTab.Location = new Point(4, 24);
            WelcomeTab.Name = "WelcomeTab";
            WelcomeTab.Padding = new Padding(3);
            WelcomeTab.Size = new Size(452, 409);
            WelcomeTab.TabIndex = 0;
            WelcomeTab.Text = "Welcome";
            WelcomeTab.UseVisualStyleBackColor = true;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Dock = DockStyle.Fill;
            StatusTextBox.Location = new Point(3, 3);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.ReadOnly = true;
            StatusTextBox.Size = new Size(446, 403);
            StatusTextBox.TabIndex = 0;
            StatusTextBox.Text = "";
            StatusTextBox.ZoomFactor = 1.5F;
            // 
            // AuthenticationTab
            // 
            AuthenticationTab.Controls.Add(groupBox3);
            AuthenticationTab.Location = new Point(4, 24);
            AuthenticationTab.Name = "AuthenticationTab";
            AuthenticationTab.Padding = new Padding(3);
            AuthenticationTab.Size = new Size(452, 409);
            AuthenticationTab.TabIndex = 1;
            AuthenticationTab.Text = "Authentication";
            AuthenticationTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(AuthenticationDeleteUserButton);
            groupBox3.Controls.Add(AuthenticationUpdateUserButton);
            groupBox3.Controls.Add(AuthenticationLoginUserButton);
            groupBox3.Controls.Add(AuthenticationRegisterUserButton);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(440, 145);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Control";
            // 
            // AuthenticationDeleteUserButton
            // 
            AuthenticationDeleteUserButton.Location = new Point(6, 109);
            AuthenticationDeleteUserButton.Name = "AuthenticationDeleteUserButton";
            AuthenticationDeleteUserButton.Size = new Size(428, 23);
            AuthenticationDeleteUserButton.TabIndex = 3;
            AuthenticationDeleteUserButton.Text = "User delete";
            AuthenticationDeleteUserButton.UseVisualStyleBackColor = true;
            AuthenticationDeleteUserButton.Click += AuthenticationDeleteUserButton_Click;
            // 
            // AuthenticationUpdateUserButton
            // 
            AuthenticationUpdateUserButton.Location = new Point(6, 80);
            AuthenticationUpdateUserButton.Name = "AuthenticationUpdateUserButton";
            AuthenticationUpdateUserButton.Size = new Size(428, 23);
            AuthenticationUpdateUserButton.TabIndex = 2;
            AuthenticationUpdateUserButton.Text = "User update";
            AuthenticationUpdateUserButton.UseVisualStyleBackColor = true;
            AuthenticationUpdateUserButton.Click += AuthenticationUpdateUserButton_Click;
            // 
            // AuthenticationLoginUserButton
            // 
            AuthenticationLoginUserButton.Location = new Point(6, 51);
            AuthenticationLoginUserButton.Name = "AuthenticationLoginUserButton";
            AuthenticationLoginUserButton.Size = new Size(428, 23);
            AuthenticationLoginUserButton.TabIndex = 1;
            AuthenticationLoginUserButton.Text = "User login";
            AuthenticationLoginUserButton.UseVisualStyleBackColor = true;
            AuthenticationLoginUserButton.Click += AuthenticationLoginUserButton_Click;
            // 
            // AuthenticationRegisterUserButton
            // 
            AuthenticationRegisterUserButton.Location = new Point(6, 22);
            AuthenticationRegisterUserButton.Name = "AuthenticationRegisterUserButton";
            AuthenticationRegisterUserButton.Size = new Size(428, 23);
            AuthenticationRegisterUserButton.TabIndex = 0;
            AuthenticationRegisterUserButton.Text = "User register";
            AuthenticationRegisterUserButton.UseVisualStyleBackColor = true;
            AuthenticationRegisterUserButton.Click += AuthenticationRegisterUserButton_Click;
            // 
            // CollectionTab
            // 
            CollectionTab.Location = new Point(4, 24);
            CollectionTab.Name = "CollectionTab";
            CollectionTab.Padding = new Padding(3);
            CollectionTab.Size = new Size(452, 409);
            CollectionTab.TabIndex = 2;
            CollectionTab.Text = "Collection";
            CollectionTab.UseVisualStyleBackColor = true;
            // 
            // SetupTab
            // 
            SetupTab.Controls.Add(SetupDeleteSavedButton);
            SetupTab.Controls.Add(groupBox2);
            SetupTab.Controls.Add(groupBox1);
            SetupTab.Location = new Point(4, 24);
            SetupTab.Name = "SetupTab";
            SetupTab.Padding = new Padding(3);
            SetupTab.Size = new Size(452, 409);
            SetupTab.TabIndex = 3;
            SetupTab.Text = "Setup";
            SetupTab.UseVisualStyleBackColor = true;
            // 
            // SetupDeleteSavedButton
            // 
            SetupDeleteSavedButton.Location = new Point(317, 380);
            SetupDeleteSavedButton.Name = "SetupDeleteSavedButton";
            SetupDeleteSavedButton.Size = new Size(129, 23);
            SetupDeleteSavedButton.TabIndex = 2;
            SetupDeleteSavedButton.Text = "Delete saved data";
            SetupDeleteSavedButton.UseVisualStyleBackColor = true;
            SetupDeleteSavedButton.Click += SetupDeleteSavedButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PasswordTextBox);
            groupBox2.Controls.Add(UsernameTextBox);
            groupBox2.Location = new Point(6, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 88);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Userdata";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(6, 51);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(428, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(6, 22);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(428, 23);
            UsernameTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BaseUrlTextBox);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BaseURL";
            // 
            // BaseUrlTextBox
            // 
            BaseUrlTextBox.Location = new Point(6, 22);
            BaseUrlTextBox.Name = "BaseUrlTextBox";
            BaseUrlTextBox.Size = new Size(428, 23);
            BaseUrlTextBox.TabIndex = 0;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(TabBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Welcome";
            Text = "Pocketsharp Desktop";
            Load += Welcome_Load;
            TabBar.ResumeLayout(false);
            WelcomeTab.ResumeLayout(false);
            AuthenticationTab.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            SetupTab.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabBar;
        private TabPage WelcomeTab;
        private TabPage AuthenticationTab;
        private TabPage CollectionTab;
        private TabPage SetupTab;
        private RichTextBox StatusTextBox;
        private GroupBox groupBox1;
        private TextBox BaseUrlTextBox;
        private GroupBox groupBox2;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private GroupBox groupBox3;
        private Button AuthenticationRegisterUserButton;
        private Button AuthenticationLoginUserButton;
        private Button AuthenticationDeleteUserButton;
        private Button AuthenticationUpdateUserButton;
        private Button SetupDeleteSavedButton;
    }
}
