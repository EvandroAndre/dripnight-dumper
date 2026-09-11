using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class PreviewAsistant : MonoBehaviour
{
	public string vfxid;

	public List<Animator> m_PlayerAnimatorList;

	public List<Animator> m_PlayerIdleAnimatorList;

	public AnimationClip IdleAnim;

	private float ActionTime;

	private float RealTime;

	private bool StartIdle;

	public void PlayAnimAudioBackGroundEvt(string voice_resourceid)
	{
	}

	public void PlayAnimAudioLoopBackGroundEvt(string voice_resourceid)
	{
	}

	public void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	public void ResumeAudioVolume()
	{
	}

	public void ReduceAudioVolume(float volumerate)
	{
	}

	public void AnimCGFinish()
	{
	}

	public void WeaponCGFinish()
	{
	}

	public void WeaponCgStart()
	{
	}

	public void AnimationOver()
	{
	}

	public void SetAnimRotateEnable()
	{
	}

	public void AutoDestoryCg()
	{
	}

	public void PlayVfxEffect(string vfxid)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void StartRecordIdle()
	{
	}

	public void OnDisable()
	{
	}

	public void ResetRecord()
	{
	}

	private void UpdatePlayerAnimator()
	{
	}
}
