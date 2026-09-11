namespace GCommon.Audio;

public class PlayingAudioInfo
{
	public int AudioSourceHash;

	public string ClipName;

	public bool IsLoop;

	public bool Is3D;

	public int ShowingFrameCount;

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
