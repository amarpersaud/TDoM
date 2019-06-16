using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YoutubeExplode;
using YoutubeExplode.Models;
using YoutubeExplode.Models.MediaStreams;
using YoutubeExplode.Exceptions;
using System.Media;
using NAudio;
using NAudio.Codecs;
using NAudio.CoreAudioApi;
using NAudio.MediaFoundation;
using NAudio.FileFormats;
using NAudio.Wave;

namespace TDoM.Core
{
    public class YoutubeMusicPlayer : IDisposable
    {
        public string URL
        {
            get
            {
                return _url;
            }
            set
            {
                YoutubeClient.TryParseVideoId(URL, out ID);
                _url = value;
            }
        }
        private string _url;

        public string ID;
        public double Progress;

        public WaveOutEvent outputDevice;
        public YoutubeClient client;
        public Video videoInfo;
        public AudioStreamInfo mediaStreamInfo;
        public MediaFoundationReader mfr;

        public PlaybackState PlaybackState {
            get { return outputDevice.PlaybackState; }
        }


        public YoutubeMusicPlayer(string URL)
        {
            outputDevice = new WaveOutEvent();
            this.URL = URL;
        }
        public YoutubeMusicPlayer()
        {
            outputDevice = new WaveOutEvent();
            URL = "";
            ID = "";
        }

        public async Task Play()
        {
            if (PlaybackState == PlaybackState.Stopped)
            {
                await PlayURL(this.URL);
            }
            else {
                outputDevice.Play();
            }
        }

        public async Task PlayURL(string URL)
        {
            this.URL = URL;

            if (PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Stop();
            }
            client = new YoutubeClient(); //This should be initialized in YoutubeController constructor.
            var mediaInfoSet = await client.GetVideoMediaStreamInfosAsync(ID);

            //Get video metadata
            videoInfo = await client.GetVideoAsync(ID);
            //Get media info
            mediaStreamInfo = mediaInfoSet.Audio.WithHighestBitrate();

            // Some mime type. Should be AAC for youtube.
            var mimeType = $"audio/{mediaStreamInfo.Container.GetFileExtension()}";

            //Make sure outputdevice is not null
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                //outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            //Use MediaFoundationReader to convert AAC stream to WAV for outputDevice
            mfr = new MediaFoundationReader(mediaStreamInfo.Url);
            
            outputDevice.Init(mfr);
            

            outputDevice.Play();
        }

        public void Pause()
        {
            outputDevice.Pause();
        }

        public void Stop()
        {
            outputDevice.Stop();
        }

        public bool IsPaused
        {
            get { return PlaybackState == PlaybackState.Paused; }
        }

        public bool IsPlaying
        {
            get { return PlaybackState == PlaybackState.Playing; }
        }

        public bool IsStopped
        {
            get { return PlaybackState == PlaybackState.Stopped; }
        }

        public TimeSpan GetDuration()
        {
            return mfr.TotalTime;
        }

        public TimeSpan GetCurrentTime()
        {
            return mfr.CurrentTime;
        }
        public void SetCurrentTime(TimeSpan time)
        {
            mfr.CurrentTime = time;
        }
        public double GetElapsedPercentage()
        {

            return GetCurrentTime().TotalSeconds / GetDuration().TotalSeconds;
        }

        public void Dispose()
        {
            outputDevice.Dispose();
            mfr.Dispose();
        }

        public void SetVolume(double percentage)
        {
            outputDevice.Volume = (float)percentage.Clamp(0.0, 1.0);
        }
    }
}
