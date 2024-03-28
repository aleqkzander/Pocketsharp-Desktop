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
            AuthenticationTab = new TabPage();
            CollectionTab = new TabPage();
            SetupTab = new TabPage();
            StatusTextBox = new RichTextBox();
            TabBar.SuspendLayout();
            WelcomeTab.SuspendLayout();
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
            SetupTab.Location = new Point(4, 24);
            SetupTab.Name = "SetupTab";
            SetupTab.Padding = new Padding(3);
            SetupTab.Size = new Size(452, 409);
            SetupTab.TabIndex = 3;
            SetupTab.Text = "Setup";
            SetupTab.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabBar;
        private TabPage WelcomeTab;
        private TabPage AuthenticationTab;
        private TabPage CollectionTab;
        private TabPage SetupTab;
        private RichTextBox StatusTextBox;
    }
}
