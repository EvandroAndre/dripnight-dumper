using System;
using System.Collections;
using System.Collections.Generic;
using COW;
using GCommon;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineAnimCGEvt : PreviewBaseComponent
{
	private sealed class _003CDelay3DShot_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeLineAnimCGEvt _003C_003E4__this;

		public ResourceID soundID;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelay3DShot_003Ed__44(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDelayOneShot_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResourceID soundID;

		public TimeLineAnimCGEvt _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayOneShot_003Ed__43(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private Coroutine m_AudioDelayCoroutine;

	public bool IsGachaFeature;

	[NonSerialized]
	public EAnimAudioBusType AudioBus;

	private ResourceID _003CAudioSource_003Ek__BackingField;

	public bool StopSoundOnDisable;

	private PlayableDirector playableDirector;

	private double lastTime;

	private bool m_IsPlay;

	private bool isCallbackRegistered;

	private bool avatarTLMuanl;

	public ResourceID AudioSource
	{
		get
		{
			return _003CAudioSource_003Ek__BackingField;
		}
		set
		{
			_003CAudioSource_003Ek__BackingField = value;
		}
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void AnimCGFinish()
	{
	}

	public void SubtitlePlay(string animEvtName)
	{
	}

	public void SubtitleFinish()
	{
	}

	public void WeaponCGFinish()
	{
	}

	public void WeaponCgStart()
	{
	}

	public void ShowSpecialBg(bool show)
	{
	}

	public void DisableWeaponRotate()
	{
	}

	public void EnableWeaponRotate()
	{
	}

	public void SetWeaponRotateState(bool flag)
	{
	}

	public void SetSpeicalWeaponRotate()
	{
	}

	public void AnimationOver()
	{
	}

	public void SetAnimRotateEnable()
	{
	}

	public void EnableAvatarInputHandler()
	{
	}

	public void PlayVfxEffect(string vfxid)
	{
	}

	public void LoopFrameAndDisableSync()
	{
	}

	public void JumpToFrame(float time)
	{
	}

	public void JumpToFrameAll(float time)
	{
	}

	public void PlayAnimAudioBackGroundEvt(string voice_resourceid)
	{
	}

	public void IIVTWGachaFullBGSound()
	{
	}

	public void IIVTWGachaHalfBGSound()
	{
	}

	public void IIVTWGachaBGSoundEnd()
	{
	}

	public void IIVTWRyomenSukunaPlayIdle()
	{
	}

	public void IIVTWGachaRyomenSukunaSound()
	{
	}

	public void IIVTWGachaRyomenSukunaInStart()
	{
	}

	public void IIVTWGachaRyomenSukunaInFinish()
	{
	}

	public void IIVTWGachaRyomenSukunaUIIn()
	{
	}

	public void PlayAnimAudioLoopBackGroundEvt(string voice_resourceid)
	{
	}

	public void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	private IEnumerator DelayOneShot(ResourceID soundID)
	{
		return null;
	}

	private IEnumerator Delay3DShot(ResourceID soundID)
	{
		return null;
	}

	public void PlayAnimOneShotEvtAuto3D(string voice_resourceid)
	{
	}

	public void ResumeAudioVolume()
	{
	}

	public void ReduceAudioVolume(float volumerate)
	{
	}

	private void OnEnable()
	{
	}

	private void OnPlayableDirectorPlayed(PlayableDirector director)
	{
	}

	private void PlayAudioByCsv(string name)
	{
	}

	private void ClearDirectorPlayed()
	{
	}

	public void SkipVoice()
	{
	}

	private void Update()
	{
	}
}
