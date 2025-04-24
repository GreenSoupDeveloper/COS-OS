using Cosmos.System.Audio;
using Cosmos.System.Audio.IO;
using Cosmos.HAL.Drivers.PCI.Audio;
using Cosmos.HAL.Audio;
using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Collections.Generic;
using System.Text;

using System.IO;
using COS.COSMAIN.Graphics;
using COS.COSMAIN.Hardware;

using COS.COSMAIN;

using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using Cosmos.HAL;
using COS.COSMAIN.Resources;


namespace COS.Drivers
{
    /// <summary>
    /// Provide some functions for play wave sounds.
    /// </summary>
    public class Audio
    {
        private static AudioMixer Mixer = new();
        private static AudioManager AudioManager;
        private static AudioDriver AudioDevice;

        /// <summary>
        /// Initialize audio (very important because if you don't call this function, you can't play sound)
        /// </summary>
        public static void InitializeAudio()
        {

            try
            {
                AudioDevice = AC97.Initialize(4096);
                AudioManager = new AudioManager()
                {
                    Stream = Mixer,
                    Output = AudioDevice,
                };
                AudioManager.Enable();
            }
            catch (InvalidOperationException)
            {
                // no ac97-compatible device
                AudioManager = null;
            }

        }

        /// <summary>
        /// Play a wave file
        /// </summary>
        /// <param name="Stream">The wave file to be played.</param>
        public static void Play(AudioStream Stream)
        {
            if (AudioManager == null) { return; }
            Mixer.Streams.Add(Stream);
        }

        /// <summary>
        /// Play a wave file
        /// </summary>
        /// <param name="Stream">The wave file to be played.</param>
        public static void Play(byte[] Stream)
        {
            AudioStream aStream = MemoryAudioStream.FromWave(Stream);
            if (AudioManager == null) { return; }
            Mixer.Streams.Add(aStream);
        }
    }
}