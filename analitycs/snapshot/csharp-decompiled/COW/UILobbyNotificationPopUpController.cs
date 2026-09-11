using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbyNotificationPopUpController : UIBaseController
{
	private sealed class _003CRemaining_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyNotificationPopUpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRemaining_003Ed__30(int _003C_003E1__state)
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

	private sealed class _003CWaitingContent_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyNotificationPopUpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitingContent_003Ed__23(int _003C_003E1__state)
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

	private UILobbyNotificationPopUpView m_View;

	private object m_Data;

	private ENotificationPopUpType m_NotificationType;

	private NotifyData m_NotifyData;

	private float m_Timer;

	private int m_BasePanelDepth;

	private const float MaxWaitingTime = 5f;

	private Dictionary<uint, UILobbyNotificationPopUpContentBaseController> m_ContentDict;

	private UILobbyNotificationPopUpContentBaseController m_Content;

	private bool _003CIsReusable_003Ek__BackingField;

	public ENotificationPopUpType NotificationType => ENotificationPopUpType.None;

	public bool IsReusable
	{
		get
		{
			return _003CIsReusable_003Ek__BackingField;
		}
		private set
		{
			_003CIsReusable_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnBtnCloseClick()
	{
	}

	public void SetViewData(ENotificationPopUpType type, object data)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshContent()
	{
	}

	private UILobbyNotificationPopUpContentBaseController GetContent()
	{
		return null;
	}

	private void RefreshPanelDepth()
	{
	}

	private IEnumerator WaitingContent()
	{
		return null;
	}

	private void PopUp()
	{
	}

	public void PopBack()
	{
	}

	public void InterruptNotification()
	{
	}

	private void OnInAnimFinished()
	{
	}

	private void OnOutAnimFinished()
	{
	}

	private void OnOutAnimFinishedByInterrupted()
	{
	}

	private IEnumerator Remaining()
	{
		return null;
	}

	public virtual void OnRelease(int PanelDepth)
	{
	}

	public virtual void OnCollect()
	{
	}

	private void ResetPostion()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
