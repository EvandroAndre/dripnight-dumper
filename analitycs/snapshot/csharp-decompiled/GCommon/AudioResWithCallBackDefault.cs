using UnityEngine;

namespace GCommon;

public class AudioResWithCallBackDefault : AudioResWithCallBackBase
{
	public AudioSource Audio;

	public bool IsNeedUnloadAudioData;

	public ObjectPool<AudioResWithCallBackDefault> OwnedPool;

	protected override void OnOnCollected()
	{
	}

	public void UnloadAudioData()
	{
	}

	public override void ReturnToPool()
	{
	}
}
