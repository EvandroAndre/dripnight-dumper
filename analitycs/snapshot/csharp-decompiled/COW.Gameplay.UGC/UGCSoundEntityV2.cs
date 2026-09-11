using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCSoundEntityV2 : MonoBehaviour
{
	public enum LoopType
	{
		DontChange,
		Loop,
		Once
	}

	public enum ESoundState
	{
		None,
		Pause,
		Replay,
		UnPause
	}

	private sealed class _003CHandleSoundState_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCSoundEntityV2 _003C_003E4__this;

		public ESoundState state;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHandleSoundState_003Ed__42(int _003C_003E1__state)
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

	private AudioResource m_2DEngineResource;

	private GameObject m_3DEngineSource;

	private string m_EntityID;

	private UGCSoundEntityRepItem m_ComponentComm;

	private UGCPlayableRepItem m_ComponentPlayable;

	private UGCLoopableRepItem m_ComponentLoopable;

	private LoopType m_IsLoop;

	private string m_ResName;

	private float m_Volume;

	private bool m_Is3D;

	private bool m_isLoading;

	private int m_RepeatTimes;

	private int m_CurrentCount;

	private float m_StartTime;

	private float m_MaxDistance;

	private float m_MinDistance;

	private ESoundState m_SoundState;

	private int m_Priority;

	private uint m_StartPlayDelayCall;

	private float m_ElapsedTime;

	private uint m_LoopTimes;

	private UGCTransformRepItem m_TransRep;

	private AudioSource m_audioSource;

	private Coroutine m_Coroutine;

	private bool m_isPlaying;

	private float m_Speed;

	private object[] m_EventArgs;

	private bool Loop => false;

	private bool isWaiting => false;

	private bool playableState => false;

	private void Update()
	{
	}

	private void StopCurrentSound()
	{
	}

	private void ClearAudioSource()
	{
	}

	private void StartCurrentSound()
	{
	}

	private void StopWaitPhase()
	{
	}

	private void StartWaitPhase()
	{
	}

	public void OnStateChangeEvent(int valueNew)
	{
	}

	private IEnumerator HandleSoundState(ESoundState state)
	{
		return null;
	}

	public static UGCSoundEntityV2 Create(string entityID)
	{
		return null;
	}

	public int GetPlayedTime()
	{
		return 0;
	}

	private void OnDestroy()
	{
	}

	private void UpdateState()
	{
	}

	private void LateUpdate()
	{
	}

	private void ConfigureAndPlayAudio()
	{
	}

	private void PlayLoopSound()
	{
	}

	private void PlayOneShot()
	{
	}

	private void OnIs3DChangeEvent(bool valueNew)
	{
	}

	private void OnPriorityChangeEvent(int priority)
	{
	}

	private void OnStartTimeChangeEvent(float valueNew)
	{
	}

	private void OnRepeatTimesChangeEvent(int valueNew)
	{
	}

	private void OnVolumeChangeEvent(int valueNew)
	{
	}

	private void OnSoundTypeChanged(string valueNew)
	{
	}

	private void OnIsLoopChangeEvent(int valueNew)
	{
	}

	private void OnMinDistanceChangeEvent(float valueNew)
	{
	}

	private void OnMaxDistanceChangeEvent(float valueNew)
	{
	}

	private void OnPlayingChange(bool value)
	{
	}

	private void OnFlagChange(int value)
	{
	}

	private void OnLocalPosChanged(Vector3 valueNew)
	{
	}

	private void OnRotatorChanged(Quaternion valueNew)
	{
	}

	private void OnScaleVectorChanged(Vector3 valueNew)
	{
	}

	private void OnParentChange(string parentEntityID)
	{
	}

	private void OnSpeedChangeEvent(float valueNew)
	{
	}

	private void _003CPlayLoopSound_003Eb__49_0(GameObject obj)
	{
	}

	private void _003CPlayLoopSound_003Eb__49_1(AudioResource obj)
	{
	}

	private void _003CPlayOneShot_003Eb__50_0(GameObject obj)
	{
	}

	private void _003CPlayOneShot_003Eb__50_1(AudioResource obj)
	{
	}
}
