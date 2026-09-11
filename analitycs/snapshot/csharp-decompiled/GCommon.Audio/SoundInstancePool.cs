using System;
using System.Collections.Generic;

namespace GCommon.Audio;

public abstract class SoundInstancePool<T> : ISoundInstanceOwner where T : SoundInstance
{
	protected readonly List<T> m_RunningInstances;

	protected readonly Queue<T> m_FreeInstances;

	public List<T> FindSoundInstances(Predicate<T> predicate = null)
	{
		return null;
	}

	public void OnSoundInstanceSpawn(T instance)
	{
	}

	public void OnSoundInstanceStopped(SoundInstance instance)
	{
	}

	internal virtual void Clear()
	{
	}
}
