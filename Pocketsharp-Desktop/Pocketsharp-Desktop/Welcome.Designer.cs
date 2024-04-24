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
            CollectionTab = new TabPage();
            SetupTab = new TabPage();
            groupBox1 = new GroupBox();
            BaseUrlTextBox = new TextBox();
            groupBox2 = new GroupBox();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            TabBar.SuspendLayout();
            WelcomeTab.SuspendLayout();
            SetupTab.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            StatusTextBox.Size = new Size(446, 403);
            StatusTextBox.TabIndex = 0;
            StatusTextBox.Text = "";
            // 
            // AuthenticationTab
            // 
            AuthenticationTab.Location = new Point(4, 24);
            AuthenticationTab.Name = "AuthenticationTab";
            AuthenticationTab.Padding = new Padding(3);
            AuthenticationTab.Size = new Size(452, 409);
            AuthenticationTab.TabIndex = 1;
            AuthenticationTab.Text = "Authentication";
            AuthenticationTab.UseVisualStyleBackColor = true;
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
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(6, 22);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(428, 23);
            UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(6, 51);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(428, 23);
            PasswordTextBox.TabIndex = 1;
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
            SetupTab.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}
