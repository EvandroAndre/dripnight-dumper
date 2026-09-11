using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIDownloadCentreFixWndController : UIPopupWindowController
{
	private sealed class _003CStartRepair_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartRepair_003Ed__15(int _003C_003E1__state)
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

	private UIDownloadCentreFixWndView m_View;

	private ResUpdateDownloadEngine.VersionCheckState m_LastVersionCheckState;

	private ResUpdateDownloadEngine.VersionCheckState m_NowVersionCheckState;

	private UIDownloadCentreController m_Parent;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitFixWndShpwState(ResUpdateDownloadEngine.VersionCheckState versionState, bool isInit = false)
	{
	}

	private void RefreshRepairUpdareState()
	{
	}

	private void Update()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void OnRepairBtnClick()
	{
	}

	private IEnumerator StartRepair()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
