using System;
using AVFoundation;
using Foundation;
using FMRadio.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]             
namespace FMRadio.iOS
{
	public class AudioService : IAudio
	{
		int clicks = 0;

		public AudioService() { }
		AVPlayer player;
		public bool Play_Pause(string url)
		{
			if (clicks == 0)
			{
				//this.player1 = new AVAudioPlayer(NSUrl.FromString(url), "mp3", out err);
				this.player = new AVPlayer();
				this.player = AVPlayer.FromUrl(NSUrl.FromString(url));
				this.player.Play();
				Console.WriteLine("marcheeert");
				Console.WriteLine(url);
				clicks++;
			}
			else if (clicks % 2 != 0)
			{
				this.player.Pause();
				clicks++;

			}
			else {
				this.player.Play();
				clicks++;
			}
			return true;

		}

		public bool Stop(bool val)
		{
			if (player != null)
			{
				player.Dispose();
				clicks = 0;
			}
			return true;
		}
	}
}