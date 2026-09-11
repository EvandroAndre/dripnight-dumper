using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCSoundEntity : MonoBehaviour
{
	public enum ESoundState
	{
		None,
		Pause,
		Replay,
		UnPause
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public UGCSoundEntity _003C_003E4__this;

		public float OneShotTime;

		internal void _003CStartCurrentSound_003Eb__0(GameObject obj)
		{
		}

		internal void _003CStartCurrentSound_003Eb__1(AudioResource obj)
		{
		}
	}

	private sealed class _003CHandleSoundState_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCSoundEntity _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHandleSoundState_003Ed__24(int _003C_003E1__state)
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

	private UGCPresentSoundRepItem m_ComponentComm;

	private UGCPlayableRepItem m_ComponentPlayable;

	private string m_entityID;

	private string TrackEntityID;

	private bool m_IsLoop;

	private string m_ResName;

	private float m_Volume;

	private bool m_Is3D;

	private int m_PlayTimes;

	private uint m_StopSoundDelayCall;

	private float m_AudioDistance;

	private ESoundState m_SoundState;

	private float m_LeftTime;

	private float m_LastPlayTime;

	public Transform TrackObject;

	private void StopCurrentSound()
	{
	}

	private void StartCurrentSound()
	{
	}

	private void OnFollowTargetChanged(string valueNew)
	{
	}

	public void OnSoundTypeChanged(string valueNew)
	{
	}

	public void OnIsLoopChangeEvent(bool valueNew)
	{
	}

	public void OnPlayDistanceChangeEvent(float valueNew)
	{
	}

	public void OnStateChangeEvent(int valueNew)
	{
	}

	private IEnumerator HandleSoundState()
	{
		return null;
	}

	public void OnIs3DChangeEvent(bool valueNew)
	{
	}

	public void OnPositionChangeEvent(Vector3 valueNew)
	{
	}

	public void OnPlayTimeChangeEvent(int valueNew)
	{
	}

	public void OnVolumeChangeEvent(int valueNew)
	{
	}

	public static UGCSoundEntity Create(string entityID)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void OnPlayingChange(bool value)
	{
	}

	private void OnFlagChange(int value)
	{
	}

	private void UpdateState()
	{
	}

	private bool GetFlag(int offset)
	{
		return false;
	}
}
