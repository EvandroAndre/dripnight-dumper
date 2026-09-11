using System.Collections.Generic;
using COW;
using UnityEngine;

namespace GCommon.Audio;

public class AudioGroup : ISoundInstanceOwner
{
	private readonly SoundGroupDesignData m_DesignData;

	private readonly List<SoundInstance_Unity> m_Instances2D;

	private readonly List<SoundInstance_Unity> m_Instances3D;

	private readonly List<SoundInstance_Unity> m_VirtualVoices;

	private readonly AudioDiscardLogic m_DiscardLogic;

	private const float c_VirtualVoiceMoveThresholdDistSqr = 4f;

	private Vector3 m_LastVirtualVoiceListenerPos;

	public AudioGroup()
	{
	}

	public AudioGroup(int instanceLimit3D, int maxPlayDistance)
	{
	}

	public AudioGroup(SoundGroupDesignData data)
	{
	}

	public void RegisterVoice(SoundInstance_Unity voice, bool is3D)
	{
	}

	public PlaySoundResult Can3DSoundPlay(Vector3 worldPos, Vector3 listenerPos)
	{
		return PlaySoundResult.Success;
	}

	private bool Is2DSoundInstanceLimited()
	{
		return false;
	}

	public bool CanPlay2DShot(ResourceID sound)
	{
		return false;
	}

	public void KillOrVirtualize3DSound(SoundInstance_Unity sound)
	{
	}

	private int GetRealVoiceCount()
	{
		return 0;
	}

	private SoundInstance_Unity TryGetNearestVirtualVoice(Vector3 listenerPos, out float nearestDistanceSqr)
	{
		nearestDistanceSqr = default(float);
		return null;
	}

	private SoundInstance_Unity TryGetFarthestRealVoice(Vector3 listenerPos, out float farthestDistanceSqr)
	{
		farthestDistanceSqr = default(float);
		return null;
	}

	private void ResumeVirtualVoice(SoundInstance_Unity voice)
	{
	}

	public void OnSoundInstanceStopped(SoundInstance instance)
	{
	}

	private void AutoResumeVirtualVoices()
	{
	}

	public void RunOneFrame()
	{
	}

	public void Clear()
	{
	}

	public void UpdatePlayParams(GameObject emitter, bool is3D, AudioPlaybackParams_Unity playParams)
	{
	}
}
