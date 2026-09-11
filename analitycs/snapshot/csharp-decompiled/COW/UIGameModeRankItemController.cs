using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIGameModeRankItemController : UIGameModeBaseItemController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__19_0;

		internal void _003COnUIInit_003Eb__19_0()
		{
		}
	}

	private UIModelMapOpeningInfo m_ModelInfo;

	private UIModelLadderMatch m_ModelLadderMatch;

	private NIKKALKPIBO m_GameMode;

	private DLBMPCCFKKM m_MatchMode;

	private static bool m_LockShow;

	private bool m_isGuest;

	private static string NewPlayerInRank;

	private static string NewPlayerInCSRank;

	private new UIModelUser m_ModelUser;

	private bool m_DataInit;

	private UICommonGuideController m_RankGuideCtrl;

	private UIGameModeRankInfoController m_InfoCtrl;

	private UIGameModeGameplayAffixDetailsDropdownController m_GameplayAffixDetailsDropdownCtrl;

	private UIGameModeGameplayAffixPreviewController m_GameplayAffixPreviewCtrl;

	private UIGameModeNewPlayerUnlockFeatureController m_NewPlayerUnlockFeatureCtrl;

	private GameObject m_HLEEffect;

	private uint m_HLEEffectTicket;

	private static uint BASIC_BR_MODE_GUN_EFFECTS;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
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

	protected override bool GamemodeInActivityStyle()
	{
		return false;
	}

	protected override bool TryGetNetworkTextureSuperiorToMapMode(out string url)
	{
		url = null;
		return false;
	}

	public override void SetPickHighLight(bool state)
	{
	}

	public void AddBindAccoutCheck()
	{
	}

	public void CheckLevelLock()
	{
	}

	private void OnAsycLoadHLEEffectSuccess(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	private void OnShowBindAccount()
	{
	}

	public override void OnModeBtnClick()
	{
	}

	private int GetNewPlayerEffectShow()
	{
		return 0;
	}

	private void SetNewPlayerInRankShow(int state)
	{
	}

	private void ShowRankGuide()
	{
	}

	public void CloseRankGuide()
	{
	}

	protected override void OnGameModeVisiableChange(object[] data)
	{
	}

	protected override void SetItemUIData(List<MapModeData> dataList)
	{
	}

	protected override bool IsTopRightTakenByInfoCtrl()
	{
		return false;
	}

	public override int GetDropdownLikePanelBaseDepth()
	{
		return 0;
	}

	protected override void OnPanelOverLiveEffectsDepthChange(int overLifeEffectPanelDepth)
	{
	}

	protected override bool CheckDuoVersionState()
	{
		return false;
	}

	protected override bool CheckBanMatchState(ref long punishUntil)
	{
		return false;
	}

	public void ShowNewSeasonTips()
	{
	}

	public void ShowSeasonEndTips()
	{
	}

	public void RefreshSeasonSwitchNode()
	{
	}

	public bool CheckIsSeasonSwitchState()
	{
		return false;
	}

	protected override bool IsBeforeCurrentRankSeasonInfoStartTime()
	{
		return false;
	}

	protected override bool IsCoveredRankGuideAvailable()
	{
		return false;
	}

	private void RefreshSeasonSwitchView(bool isShow)
	{
	}

	private void HidePreviousDisplayStateContent()
	{
	}

	public EGameModeRankItemDisplayState RefreshWithDisplayStateOnVisible(bool hidePrevious)
	{
		return EGameModeRankItemDisplayState.Unknown;
	}

	public void OnGameplayAffixEventFirstTimeSequenceEnding()
	{
	}

	private UIGameModeGameplayAffixPreviewItemViewData[] BuildGameplayAffixPreviewViewDataItems()
	{
		return null;
	}

	private void PlayGameplayAffixEventFirstTimeSequence()
	{
	}

	private void TryDisplayNewPlayerUnlockFeature()
	{
	}

	private void TryDisplayGameplayAffixDetailsDropdown()
	{
	}

	private void TryStopGameplayAffixDetailsDropdownProtectLabelCarousel()
	{
	}

	private void _003CRefreshSeasonSwitchNode_003Eb__45_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
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

	public bool _003C_003EiFixBaseProxy_GamemodeInActivityStyle()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_TryGetNetworkTextureSuperiorToMapMode(out string P0)
	{
		P0 = null;
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetPickHighLight(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnModeBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnGameModeVisiableChange(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetItemUIData(List<MapModeData> P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsTopRightTakenByInfoCtrl()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetDropdownLikePanelBaseDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnPanelOverLiveEffectsDepthChange(int P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckDuoVersionState()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CheckBanMatchState(ref long P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsBeforeCurrentRankSeasonInfoStartTime()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsCoveredRankGuideAvailable()
	{
		return false;
	}
}
