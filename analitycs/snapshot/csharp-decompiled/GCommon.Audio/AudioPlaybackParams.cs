using System;

namespace GCommon.Audio;

[Serializable]
public abstract class AudioPlaybackParams
{
	public bool IsFromPool;

	public ESoundOwner OwnerType;

	public virtual void Reset()
	{
	}

	public virtual void CopyFrom(AudioPlaybackParams source)
	{
	}
}
