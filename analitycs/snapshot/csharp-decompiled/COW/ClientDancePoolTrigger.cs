using GCommon;
using UnityEngine;

namespace COW;

public class ClientDancePoolTrigger : Entity
{
	private AudioSource m_AudioSource;

	private AudioClip[] m_DancePoolBgmClips;

	private int m_DancePoolBgmClipCount;

	private int m_CurrentDancePoolBgmIndex;

	private const float m_DancePoolBgmStartGuardSec = 0.1f;

	private float m_DancePoolBgmStartRealtime;

	protected override void OnAwake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void StartDancePoolBgm()
	{
	}

	private bool LoadDancePoolBgmClips()
	{
		return false;
	}

	private void PlayNextDancePoolBgm()
	{
	}

	private void OnMusicVolumeChange(object[] data)
	{
	}

	private void StopDancePoolBgm()
	{
	}

	private void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}
}
