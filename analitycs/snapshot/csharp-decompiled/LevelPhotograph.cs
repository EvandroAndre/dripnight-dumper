using System;
using System.Collections;
using System.Collections.Generic;
using COW;
using COW.GamePlay;
using GCommon;
using UnityEngine;

public class LevelPhotograph : MonoBehaviour
{
	private sealed class _003CShowEffect_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelPhotograph _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowEffect_003Ed__35(int _003C_003E1__state)
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

	public float moveSpeedScale;

	public Vector2 XMoveRange;

	public Vector2 YMoveRange;

	public float MAX_FOV;

	public float MIN_FOV;

	public string EventLogClickType;

	public string SoundId;

	public string EffectId;

	public Transform EffectObject;

	public float EffectShowTime;

	public bool IsCoverDefaultSound;

	private Camera PhotoCamera;

	private float m_OrgFOV;

	private bool m_IsPlayerInTrigger;

	public ResourceID SoundResId;

	private UIModelMatch m_ModelMatch;

	private FEKBCHODFLE m_AsyncLoadTickets;

	public float BanTriggerMatchTime;

	private bool m_IsTraingMode;

	private bool m_IsInPhotogragphMode;

	public bool IsPlayerInTrigger => false;

	public bool IsInPhotographMode => false;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void OnTriggerExit(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnPlayerExit()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void EnterPhotographMode(object[] data)
	{
	}

	private void ExitPhotographMode(object[] data)
	{
	}

	public void TakePhoto()
	{
	}

	private void DelegateAsyncLoadVFX(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	private IEnumerator ShowEffect()
	{
		return null;
	}

	private void Update()
	{
	}

	private void AdjustCameraFOV(object[] data)
	{
	}

	private UserControlAxisData GetAxisData(int axisIndex)
	{
		return null;
	}
}
