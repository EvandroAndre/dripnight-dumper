using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIGameModeUGCInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIGameModeCasualInfoView m_View;

	private List<MapModeData> m_Data;

	private UIModelMapOpeningInfo m_ModelMap;

	private MapModeData m_SelectedMapModeData;

	private UIUGCGameModeMapPickWndController m_Ctrl;

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

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void SetUIData(List<MapModeData> dataList)
	{
	}

	private void OnHelpBtnCLick()
	{
	}

	private void ShowHelpBtn(MapModeData data)
	{
	}

	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	private void SetTagVfxState()
	{
	}

	private void RefreshOpeningUI()
	{
	}

	public void OnSwitchMapModeClick()
	{
	}

	public void OnSwitchBtnAniEnable(object[] data)
	{
	}

	private void _003COnUIInit_003Eb__7_0()
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
