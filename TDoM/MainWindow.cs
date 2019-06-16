using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDoM.Controls;
using TDoM.Core;
using TDoM.Core.Cache;
using TDoM.Core.Search;

namespace TDoM
{
    public partial class MainWindow : Form
    {
        private YoutubeMusicPlayer musicPlayer;

        private const string PLAYING_PLAY_BUTTON_TEXT = "▎ ▎";
        private const string PAUSED_PLAY_BUTTON_TEXT = "▶";

        private Timer MusicTimer = new Timer();

        public MainWindow()
        {
            InitializeComponent();
            musicPlayer = new YoutubeMusicPlayer("https://www.youtube.com/watch?v=2BZGjycR7YM");
            this.DoubleBuffered = true;
            MusicTimer.Interval = 100;
            MusicTimer.Tick += UpdateMusicUI;
            musicTrackBar.UserValueChanged += Seek;
        }

        public void setMusicProgressPercentage(float percentage)
        {
            musicTrackBar.Value = (int)Math.Round(percentage * musicTrackBar.Maximum);
        }

        private async void musicPlayButton_ClickAsync(object sender, EventArgs e)
        {
            if (musicPlayer.IsPlaying)
            {
                musicPlayer.Pause();
                musicPlayButton.Text = PAUSED_PLAY_BUTTON_TEXT;
                MusicTimer.Stop();
            }
            else
            {
                await musicPlayer.Play();
                musicPlayButton.Text = PLAYING_PLAY_BUTTON_TEXT;
                MusicTimer.Start();
            }
            Console.WriteLine($"Length: {musicPlayer.GetDuration()}");
            Console.WriteLine($"Progress: {musicPlayer.GetCurrentTime()} : {musicPlayer.GetElapsedPercentage()}");
        }

        private void musicVolume_ValueChanged(object sender, EventArgs e)
        {
            musicPlayer.SetVolume((double)musicVolume.Value / musicVolume.Maximum);
        }
        public void UpdateMusicUI(object sender, EventArgs e)
        {
            musicTrackBar.SetProgressPercentage(musicPlayer.GetElapsedPercentage());

            TimeSpan elapsed = musicPlayer.GetCurrentTime();
            TimeSpan duration = musicPlayer.GetDuration();
            string timestamp = $"{elapsed.GetAudioTimeStamp()} / {duration.GetAudioTimeStamp()}";
            musicElapsedTimeLabel.Text = timestamp;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public void Seek(object sender, EventArgs e)
        {
            double percentage = musicTrackBar.GetProgressPercentage();
            double seconds = musicPlayer.GetDuration().TotalSeconds * percentage;
            TimeSpan newCurrentTime = TimeSpan.FromSeconds(seconds);
            musicPlayer.SetCurrentTime(newCurrentTime);
        }
    }


}
