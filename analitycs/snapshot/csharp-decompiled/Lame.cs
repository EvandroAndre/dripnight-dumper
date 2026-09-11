using System;
using System.Runtime.InteropServices;

public static class Lame
{
	public static class MP3
	{
		private class Impl
		{
			public virtual IntPtr Init()
			{
				return (IntPtr)0;
			}

			public virtual void Set_In_SampleRate(IntPtr lame, int rate)
			{
			}

			public virtual void Set_Out_SampleRate(IntPtr lame, int rate)
			{
			}

			public virtual void Set_Num_Channels(IntPtr lame, int channels)
			{
			}

			public virtual void Set_BitRate(IntPtr lame, int brate)
			{
			}

			public virtual void Init_Params(IntPtr lame)
			{
			}

			public virtual int Encode_Buffer(IntPtr lame, short[] pcm_l, short[] pcm_r, int num_samples, byte[] mp3buf, int mp3buf_size)
			{
				return 0;
			}

			public virtual int Encode_Flush(IntPtr lame, byte[] mp3buf, int mp3buf_size)
			{
				return 0;
			}

			public virtual int PCM_to_MP3(float[] pcm, uint pcm_size, ref byte[] mp3, ref uint mp3_size, int sampleRate, int channels, int bitRate)
			{
				return 0;
			}

			public virtual void Close(IntPtr lame)
			{
			}
		}

		private class Impl_PInvoke : Impl
		{
			private const string LIB_NAME = "mp3lame";

			[PreserveSig]
			private static extern int pcm_to_mp3_float([In] float[] pcm, uint pcmSize, [In][Out] byte[] mp3Data, ref uint mp3Size, int sampleRate, int channels, int bitRate);

			[PreserveSig]
			private static extern IntPtr lame_init();

			[PreserveSig]
			private static extern void lame_set_in_samplerate(IntPtr lame, int rate);

			[PreserveSig]
			private static extern void lame_set_out_samplerate(IntPtr lame, int rate);

			[PreserveSig]
			private static extern void lame_set_num_channels(IntPtr lame, int channels);

			[PreserveSig]
			private static extern void lame_set_brate(IntPtr lame, int brate);

			[PreserveSig]
			private static extern void lame_init_params(IntPtr lame);

			[PreserveSig]
			private static extern int lame_encode_buffer(IntPtr lame, [In] short[] pcm_l, [In] short[] pcm_r, int num_samples, [In] byte[] mp3buf, int mp3buf_size);

			[PreserveSig]
			private static extern int lame_encode_flush(IntPtr lame, [In] byte[] mp3buf, int mp3buf_size);

			[PreserveSig]
			private static extern void lame_close(IntPtr lame);

			public override IntPtr Init()
			{
				return (IntPtr)0;
			}

			public override void Set_In_SampleRate(IntPtr lame, int rate)
			{
			}

			public override void Set_Out_SampleRate(IntPtr lame, int rate)
			{
			}

			public override void Set_Num_Channels(IntPtr lame, int channels)
			{
			}

			public override void Set_BitRate(IntPtr lame, int brate)
			{
			}

			public override void Init_Params(IntPtr lame)
			{
			}

			public override int Encode_Buffer(IntPtr lame, short[] pcm_l, short[] pcm_r, int num_samples, byte[] mp3buf, int mp3buf_size)
			{
				return 0;
			}

			public override int Encode_Flush(IntPtr lame, byte[] mp3buf, int mp3buf_size)
			{
				return 0;
			}

			public override int PCM_to_MP3(float[] pcm, uint pcm_size, ref byte[] mp3, ref uint mp3_size, int sampleRate, int channels, int bitRate)
			{
				return 0;
			}

			public override void Close(IntPtr lame)
			{
			}
		}

		private static Impl __Impl;

		private static Impl _Impl => null;

		public static IntPtr Init()
		{
			return (IntPtr)0;
		}

		public static void Set_In_SampleRate(IntPtr lame, int rate)
		{
		}

		public static void Set_Out_SampleRate(IntPtr lame, int rate)
		{
		}

		public static void Set_Num_Channels(IntPtr lame, int channels)
		{
		}

		public static void Set_BitRate(IntPtr lame, int brate)
		{
		}

		public static void Init_Params(IntPtr lame)
		{
		}

		public static int Encode_Buffer(IntPtr lame, short[] pcm_l, short[] pcm_r, int num_samples, byte[] mp3buf, int mp3buf_size)
		{
			return 0;
		}

		public static int Encode_Flush(IntPtr lame, byte[] mp3buf, int mp3buf_size)
		{
			return 0;
		}

		public static int PCM_to_MP3(float[] pcm, uint pcm_size, ref byte[] mp3, ref uint mp3_size, int sampleRate, int channels, int bitRate)
		{
			return 0;
		}

		public static void Close(IntPtr lame)
		{
		}
	}
}
