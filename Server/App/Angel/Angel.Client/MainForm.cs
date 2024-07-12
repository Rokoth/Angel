using Angel.Client.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Angel.Client
{
    public partial class MainForm : Form
    {
        private IServiceProvider _serviceProvider;
        private ISessionKeeper _sessionKeeper;       

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _sessionKeeper = _serviceProvider.GetRequiredService<ISessionKeeper>();
            InitializeComponent();
            buttonStart.Enabled = false;
            buttonSettings.Enabled = false;
        }
               
        private void buttonAuth_Click(object sender, EventArgs e)
        {
            var authForm = _serviceProvider.GetRequiredService<AuthForm>();
            var res = authForm.ShowDialog();
            if (res == DialogResult.OK && _sessionKeeper.IsAuth)
            {
                SetAuth();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = _serviceProvider.GetRequiredService<AuthForm>();
            var res = settingsForm.ShowDialog();
            if (res != DialogResult.OK)
            {
                MessageBox.Show("Ошибка при сохранении настроек, попробуйте позже.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var gameForm = _serviceProvider.GetRequiredService<GameForm>();
            gameForm.StartLoad();
            while(!gameForm.IsLoaded)
            {
                loadProgressBar.Value = gameForm.GetLoadedProgress();                
            }
            Hide();
            gameForm.Show();
            gameForm.OnClose += OnGameFormClose;
        }

        private void OnGameFormClose(object? sender, EventArgs e)
        {
            Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            var settingsForm = _serviceProvider.GetRequiredService<AboutForm>();
            var res = settingsForm.ShowDialog();
            if (res != DialogResult.OK)
            {
                MessageBox.Show("Ошибка, попробуйте позже.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void SetAuth()
        {
            buttonStart.Enabled = true;
            buttonSettings.Enabled = true;
        }
    }
}
