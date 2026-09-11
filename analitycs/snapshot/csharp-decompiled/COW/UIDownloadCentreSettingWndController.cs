using GCommon;
using UnityEngine;

namespace COW;

internal class UIDownloadCentreSettingWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIDownloadCentreSettingWndView m_View;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private static Vector3 REPAIRLABELPOS;

	private static Vector3 REPAIRLABELPOSWITHERROR;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetViewData()
	{
	}

	private void RefreshRepairShowState()
	{
	}

	private void InitBtnState()
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

	private void OnConfirmBtnClick()
	{
	}

	private void OnRepairBtnClick()
	{
	}

	private void OnClearToggleBtnClick()
	{
	}

	private void OnDownLoadToggleOffBtnClick()
	{
	}

	private void OnDownLoadToggleOnBtnClick()
	{
	}

	private void OnClearTipsClick()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
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
