using System.Collections.Generic;

namespace VoxelBusters.ReplayKit;

public static class AudioUtils
{
	private static AudioData current_data;

	private static Queue<AudioData> audio_pools;

	private static Queue<AudioData> audio_datas;

	public static void Reset()
	{
	}

	private static AudioData GetEmptyAudioData()
	{
		return null;
	}

	public static void CollectAudioData(AudioData data)
	{
	}

	public static void WriteData(float[] data)
	{
	}

	public static bool Empty()
	{
		return false;
	}

	public static AudioData Dequeue()
	{
		return null;
	}

	public static float[] GetCurrentLastData()
	{
		return null;
	}
}
