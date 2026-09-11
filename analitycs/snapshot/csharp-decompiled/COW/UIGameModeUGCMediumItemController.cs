using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIGameModeUGCMediumItemController : UIGameModeBaseItemController
{
	public static readonly string UGCMapSelectHotVersion;

	protected UIGameModeUGCInfoController m_Ctrl;

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

	protected bool AutoPopTagPickWnd()
	{
		return false;
	}

	protected override void OnUIInit()
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
