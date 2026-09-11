using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultMVPState : UIHudMatchResultStateBase
{
	private sealed class _003CDelayShowAvatar_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMatchResultMVPState _003C_003E4__this;

		public bool isFemale;

		public PlayerData data;

		public GameObject mvpCameraOB;

		public ResourceID playerAnimID;

		public ResourceID soundAnimID;

		public ResourceID freezzIdleAnimId;

		private int _003CcurrentFrame_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayShowAvatar_003Ed__15(int _003C_003E1__state)
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

	public const float DefaultMvpAnimDuration = 3.5f;

	private Animation m_CameraAnimation;

	private float m_MVPAnimDuration;

	private bool m_NeedShowDownload;

	private float m_StateEnterTime;

	private uint m_MVPAnimId;

	private GameObject m_AudioGo;

	public UIHudMatchResultMVPState(UIHudMatchResultStateMachine machine)
		: base(null, EUIHudMatchResultState.None)
	{
	}

	protected override bool OnCheck()
	{
		return false;
	}

	protected override bool OnEnter()
	{
		return false;
	}

	protected override void OnFinish()
	{
	}

	protected override void OnExit()
	{
	}

	private bool CreateMVPRoom()
	{
		return false;
	}

	private void PlayMvpAnim(bool isFemale, PlayerData data, GameObject mvpCameraOB, ResourceID playerAnimID, ResourceID soundAnimID, ResourceID freezzIdleAnimId)
	{
	}

	private void ShowAvatarAndPlayMvpAnim(bool isFemale, PlayerData data, GameObject mvpCameraOB, ResourceID playerAnimID, ResourceID soundAnimID, ResourceID freezzIdleAnimId)
	{
	}

	private IEnumerator DelayShowAvatar(bool isFemale, PlayerData data, GameObject mvpCameraOB, ResourceID playerAnimID, ResourceID soundAnimID, ResourceID freezzIdleAnimId)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}

	public void _003C_003EiFixBaseProxy_OnExit()
	{
	}
}
