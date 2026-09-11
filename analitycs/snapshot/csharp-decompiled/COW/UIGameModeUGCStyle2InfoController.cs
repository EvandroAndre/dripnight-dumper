using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIGameModeUGCStyle2InfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIGameModeCasualInfoView m_View;

	private UIModelMapOpeningInfo m_ModelMap;

	private MapModeData m_SelectedMapModeData;

	private WorkshopUGCOpeningInfoDesc m_WorkshopUGCOpeningInfoDesc;

	private UIPopupWindowController m_Ctrl;

	public Action onSelectedCodeChanged;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetUIData(List<MapModeData> dataList, WorkshopUGCOpeningInfoDesc desc)
	{
	}

	private void OnHelpBtnCLick()
	{
	}

	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	private void SetTagVfxState()
	{
	}

	private void RefreshDesc(MapModeData data)
	{
	}

	private void RefreshOpeningUI()
	{
	}

	public void OnSwitchMapModeClick()
	{
	}

	public void OnWndConfirm(string mapName)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003COnUIInit_003Eb__8_0()
	{
	}

	private void _003CRefreshDesc_003Eb__14_0(WorkshopBasicInfo res)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
