using System;

namespace GCommon.Audio;

[Serializable]
public class AudioPlaybackParams_Unity : AudioPlaybackParams
{
	public float Volume;

	public float Pitch;

	public int Priority;

	public bool Loop;

	public int Bus;

	public ResourceID AudioSourceID;

	public uint GroupID;

	public override void Reset()
	{
	}

	public override void CopyFrom(AudioPlaybackParams source)
	{
	}
}
