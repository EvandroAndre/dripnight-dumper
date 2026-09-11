using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIGameModeMediumItemController : UIGameModeBaseItemController
{
	private UIGameModeCasualInfoController m_InfoCtrl;

	private UIGameModeMediumItemView m_MediumItemView;

	private UIGameModeHCRankInfoController m_HPRankCtrl;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override ResourceID SelectEffectResID()
	{
		return default(ResourceID);
	}

	protected override ResourceID ClickEffectResID()
	{
		return default(ResourceID);
	}

	protected override void SetMapModeUI(MapModeData mapModeData)
	{
	}

	private void RefreshRoomModeIcon()
	{
	}

	public override void OnModeBtnClick()
	{
	}

	private bool IsPresetRoomModeCandidate()
	{
		return false;
	}

	private void RefreshSpecialMatchCDN(MapModeData mapModeData)
	{
	}

	private void SetHippoCrisisRankView()
	{
	}

	public override void SetUIData(uint matchMode, List<MapModeData> dataList, EGameModeUIType gameModeUiType)
	{
	}

	protected override void SetItemUIData(List<MapModeData> dataList)
	{
	}

	protected override void OnGameModeVisiableChange(object[] data)
	{
	}

	protected override bool IsTopRightTakenByInfoCtrl()
	{
		return false;
	}

	protected override void SetInfoCtrlHelperBtnActive(bool active)
	{
	}

	protected override void OnDownLoadStateChange(bool flag)
	{
	}

	protected override void OnRoomCreateRuleUpdated()
	{
	}

	private void OnShowCSGuide(int csGuideItemIndex)
	{
	}

	public int GetPanelOverLiveEffects()
	{
		return 0;
	}

	protected override bool CheckBanMatchState(ref long punishUntil)
	{
		return false;
	}

	private void _003CRefreshSpecialMatchCDN_003Eb__12_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_SelectEffectResID()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_ClickEffectResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_SetMapModeUI(MapModeData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnModeBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData(uint P0, List<MapModeData> P1, EGameModeUIType P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SetItemUIData(List<MapModeData> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGameModeVisiableChange(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsTopRightTakenByInfoCtrl()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetInfoCtrlHelperBtnActive(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDownLoadStateChange(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnRoomCreateRuleUpdated()
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckBanMatchState(ref long P0)
	{
		return false;
	}
}
