

namespace Angel.Client
{
    partial class MainForm
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
            buttonAuth = new Button();
            buttonStart = new Button();
            buttonSettings = new Button();
            buttonAbout = new Button();
            loadProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // buttonAuth
            // 
            buttonAuth.BackColor = SystemColors.MenuHighlight;
            buttonAuth.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAuth.Location = new Point(12, 365);
            buttonAuth.Name = "buttonAuth";
            buttonAuth.Size = new Size(203, 52);
            buttonAuth.TabIndex = 0;
            buttonAuth.Text = "Войти/Зарегистрироваться";
            buttonAuth.UseVisualStyleBackColor = false;
            buttonAuth.Click += buttonAuth_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.MenuHighlight;
            buttonStart.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic);
            buttonStart.Location = new Point(231, 365);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(175, 52);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Игра";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = SystemColors.MenuHighlight;
            buttonSettings.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic);
            buttonSettings.Location = new Point(423, 365);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(166, 52);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "Настройки";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = SystemColors.MenuHighlight;
            buttonAbout.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic);
            buttonAbout.Location = new Point(603, 365);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(185, 52);
            buttonAbout.TabIndex = 3;
            buttonAbout.Text = "Об игре";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += this.buttonAbout_Click;
            // 
            // loadProgressBar
            // 
            loadProgressBar.Location = new Point(12, 424);
            loadProgressBar.Name = "loadProgressBar";
            loadProgressBar.Size = new Size(776, 19);
            loadProgressBar.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fon_0_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(loadProgressBar);
            Controls.Add(buttonAbout);
            Controls.Add(buttonSettings);
            Controls.Add(buttonStart);
            Controls.Add(buttonAuth);
            Name = "MainForm";
            Text = "Хранители";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAuth;
        private Button buttonStart;
        private Button buttonSettings;
        private Button buttonAbout;
        private ProgressBar loadProgressBar;
    }
}
