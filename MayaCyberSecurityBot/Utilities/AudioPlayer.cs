using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using NAudio.Wave;

namespace MayaCyberSecurityBot.Utilities
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "greeting.wav");

                if (File.Exists(audioPath))
                {
                    using (var audioFile = new AudioFileReader(audioPath))
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(audioFile);
                        outputDevice.Play();

                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[AUDIO] Welcome to the Maya Cybersecurity Awareness Bot!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("[AUDIO] Could not play greeting.");
            }
        }
    }
}