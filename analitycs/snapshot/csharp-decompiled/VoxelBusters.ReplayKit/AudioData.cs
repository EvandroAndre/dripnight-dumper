namespace VoxelBusters.ReplayKit;

public class AudioData
{
	public const int AUDIO_MAX_COUNT = 2048;

	private float[] mBuffers;

	private int mLength;

	public int Count => 0;

	public void Reset()
	{
	}

	public bool Full()
	{
		return false;
	}

	public bool Empty()
	{
		return false;
	}

	public int Write(float[] datas, int offest)
	{
		return 0;
	}

	public int Read(float[] datas, int offest)
	{
		return 0;
	}
}
