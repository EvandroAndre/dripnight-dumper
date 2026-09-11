using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessageItem3Controller : UIBaseController, IQuickMsgContainerData, IQuickMsgItemData, IUIModelDataChangeObserver
{
	private sealed class _003CDelayHideReplaceIcon_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIQuickMessageItem3Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayHideReplaceIcon_003Ed__24(int _003C_003E1__state)
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

	private UIQuickMessageSettingItem3View m_View;

	private UIQuickMessageSettingController m_Parent;

	private GameObject m_Glow;

	private GameObject m_GlowVoice;

	private GameObject m_Icon;

	private uint? m_GlowingMsgId;

	private uint m_MsgId;

	private bool m_NeedDownload;

	private UIModelQuickMessage m_ModelQuickMessage;

	private UINewDownloadInfoController m_DownloadCtrl;

	private int _003CContainerIdx_003Ek__BackingField;

	private Coroutine m_ReplaceIconCo;

	public int ContainerIdx
	{
		get
		{
			return _003CContainerIdx_003Ek__BackingField;
		}
		private set
		{
			_003CContainerIdx_003Ek__BackingField = value;
		}
	}

	public uint MsgId => 0u;

	public uint Type => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshAfterCreate(int containerIdx)
	{
	}

	private void OnBtnClick()
	{
	}

	public void RefreshUI(CSVBaseData data)
	{
	}

	private IEnumerator DelayHideReplaceIcon()
	{
		return null;
	}

	private void ShowGlow(bool value)
	{
	}

	private void ShowVoicePlayingVfx(bool value)
	{
	}

	private void RefreshDownloadView()
	{
	}

	private void DownloadSecondConfirmWnd()
	{
	}

	private void DownloadRes()
	{
	}

	private void ClearDownloadView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
