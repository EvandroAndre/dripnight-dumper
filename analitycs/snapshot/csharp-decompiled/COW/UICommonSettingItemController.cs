using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UICommonSettingItemController : UICommonSettingItemBaseController
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public CommonSettingItemDataToggleBtns data;

		public UICommonSettingItemController _003C_003E4__this;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public Action click;

		public int index;

		public _003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals1;

		internal void _003CSetViewData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_2
	{
		public int val;

		public Action toggleChanged;

		public _003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals2;

		internal void _003CSetViewData_003Eb__2()
		{
		}
	}

	protected CommonSettingItemDataToggleBtns m_Data;

	protected UICommonSettingItemView m_View;

	private List<CommonSettingToggleItem> m_Toggles;

	private UINewDownloadInfoController m_downloadController;

	private UIModelOptionalDownload m_modelOptionalDownload;

	private uint m_EHDResType;

	private uint OptionalDownloadId;

	private bool NoTipsState;

	private UITipsNormalController m_tipsController;

	private bool IsConfirmDownload;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void OnSelectedBtnClicked()
	{
	}

	public override void SetViewData(CommonSettingItemDataBase baseData, int type)
	{
	}

	protected void ClearNewLabelPrefKey()
	{
	}

	private void RefreshDownLoadController(bool show)
	{
	}

	private void OnClickDownLoad()
	{
	}

	private void ShowDownloadWnd()
	{
	}

	protected virtual void UpdateWidgetBounds()
	{
	}

	public void UpdateToggles()
	{
	}

	private void SetCommonPrefsValue(int val)
	{
	}

	public int GetSelectBtn()
	{
		return 0;
	}

	public override void RefreshContent()
	{
	}

	public override void RefreshTips()
	{
	}

	public void RefreshNewLabel()
	{
	}

	private void _003CRefreshDownLoadController_003Eb__14_0()
	{
	}

	private void _003CShowDownloadWnd_003Eb__17_0()
	{
	}

	private void _003CShowDownloadWnd_003Eb__17_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(CommonSettingItemDataBase P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTips()
	{
	}
}
