using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

public class FFWSTrophyCup : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public EGJDOBGMLBO ffwsModule;

		internal int _003CChangeFlags_003Eb__0(MatchTeam a, MatchTeam b)
		{
			return 0;
		}
	}

	private sealed class _003CStartFlame_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FFWSTrophyCup _003C_003E4__this;

		private float _003CpassTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartFlame_003Ed__14(int _003C_003E1__state)
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

	private sealed class _003CUpdateCup_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FFWSTrophyCup _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateCup_003Ed__16(int _003C_003E1__state)
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

	private Vector3 m_targetPos;

	public float minYChange;

	public GameObject CupRoot;

	public Transform RotationRoot;

	public Transform[] Flags_3_Array;

	public Transform[] Flags_2_Array;

	public Camera booyahCamera;

	public GameObject booyahAnimRoot;

	private List<uint> m_attachedRess;

	private float m_RotationPassTime;

	private AudioResource m_audio;

	private WaitForSeconds m_CalculateTargetPosInterval;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private IEnumerator StartFlame()
	{
		return null;
	}

	private void CalculateTargetPos()
	{
	}

	private IEnumerator UpdateCup()
	{
		return null;
	}

	private void ChangeFlags()
	{
	}

	private void TryAttachLocalPlayerFlagEffect(uint flag, Transform flagRoot)
	{
	}

	private void ClearFlags()
	{
	}

	public void PlayLocalPlayePosBooyahAnim()
	{
	}

	private void PlayBooyahAnim()
	{
	}
}
