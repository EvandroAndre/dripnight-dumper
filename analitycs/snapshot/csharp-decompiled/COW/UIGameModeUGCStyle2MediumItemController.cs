using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIGameModeUGCStyle2MediumItemController : UIGameModeBaseItemController
{
	protected UIGameModeUGCStyle2InfoController m_Ctrl;

	protected WorkshopUGCOpeningInfoDesc m_UgcOpeningInfoDesc;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID SelectEffectResID()
	{
		return default(ResourceID);
	}

	protected override ResourceID ClickEffectResID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnPUGCMapPickWndConfirm(uint diff)
	{
	}

	public override void SetUIData(uint matchMode, List<MapModeData> dataList, EGameModeUIType gameModeUiType)
	{
	}

	private void UpdateDownloadList(object[] data)
	{
	}

	public override void OnModeBtnClick()
	{
	}

	private void RefreshModeTexture()
	{
	}

	private void _003CRefreshModeTexture_003Eb__11_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_SelectEffectResID()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_ClickEffectResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData(uint P0, List<MapModeData> P1, EGameModeUIType P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnModeBtnClick()
	{
	}
}
