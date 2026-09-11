using System;
using UnityEngine;

namespace GCommon.Audio;

public class SoundInstancePool_Unity : SoundInstancePool<SoundInstance_Unity>, IReusableObjectOwner
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SoundInstance_Unity> _003C_003E9__6_0;

		public static Predicate<SoundInstance_Unity> _003C_003E9__7_0;

		internal bool _003CStopAllOneShotSounds_003Eb__6_0(SoundInstance_Unity s)
		{
			return false;
		}

		internal bool _003CStopAllLoopingSounds_003Eb__7_0(SoundInstance_Unity s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public GameObject emitter;

		internal bool _003CStopAllSoundsByEmitter_003Eb__0(SoundInstance_Unity s)
		{
			return false;
		}
	}

	internal SoundInstance_Unity GetOrCreateInstance(ResourceID audioSourceID)
	{
		return null;
	}

	public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
	{
	}

	public void AutoRecycleStoppedInstances()
	{
	}

	public bool StopByPredicate(Predicate<SoundInstance_Unity> predicate)
	{
		return false;
	}

	public bool StopAll()
	{
		return false;
	}

	public bool StopAllSoundsByEmitter(GameObject emitter)
	{
		return false;
	}

	public bool StopAllOneShotSounds()
	{
		return false;
	}

	public bool StopAllLoopingSounds()
	{
		return false;
	}

	internal override void Clear()
	{
	}
}
