using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIRoomHangupWaitingController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CSetButtonShowTime_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float showTime;

		public UIRoomHangupWaitingController _003C_003E4__this;

		public UIButton btn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetButtonShowTime_003Ed__14(int _003C_003E1__state)
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

	private UIRoomHangupWaitingView m_View;

	public Action OnCancel;

	public Action OnQuickStart;

	private UIModelCustomRoom m_ModelRoom;

	private UIModelOptionalDownload m_ModelDownload;

	private UIGroupWaitingDropItem m_DragItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnBtnBack()
	{
	}

	private void OnQuickStartClick()
	{
	}

	private void OnGetRemind(object[] data)
	{
	}

	private void RefreshOptionalMapResDownloader()
	{
	}

	private void RefreshUGCMapResDownloader()
	{
	}

	public void RefreshUI()
	{
	}

	private IEnumerator SetButtonShowTime(UIButton btn, float showTime)
	{
		return null;
	}

	public bool IsDragging()
	{
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
