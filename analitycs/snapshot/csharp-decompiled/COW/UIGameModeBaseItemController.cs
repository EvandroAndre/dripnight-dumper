using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIGameModeBaseItemController : UIBaseController, IUIModelDataChangeObserver, UITable2.IUITable2Item
{
	protected List<MapModeData> m_MapDataList;

	protected MapModeData m_SelectedMapData;

	protected UIModelMapOpeningInfo m_ModelMap;

	protected UIModelLobbyEventBubble m_LobbyEventBubble;

	protected UIGameModeBaseItemView m_View;

	protected EGameModeUIType m_UIType;

	protected UINewDownloadInfoController m_Downloader;

	protected bool m_CanOpenMode;

	protected int m_depth;

	protected List<ResourceID> m_NeedDownloadRes;

	protected uint m_DelayCall;

	protected int m_CurSelectedIndex;

	protected bool m_NeedCheckDuoVersion;

	protected bool m_DuoVersionNodeActive;

	protected bool m_IsBeBanMatch;

	private UICountDownController m_BanMatchCDCtrl;

	protected UIGameModeOpenDetailsController m_DetailController;

	protected UIModelOptionalDownload m_ModelDownload;

	private ModePageLiveEffectsData m_LoadedLiveEffectsData;

	private GameObject m_LoadedLiveEffectObj;

	protected int m_Table2ItemIndex;

	private GameObject m_SelectVFX;

	private GameObject m_ClickVFX;

	private uint m_LiveEffectTicket;

	public ResDownloadType m_ResType;

	private Coroutine m_LiveEffectCoroutine;

	private static Vector3 DOWNLOADICONPOS;

	private GameObject m_PickHighLightEffect;

	private ResourceID m_InstantiatedTipsBtnResID;

	private GameObject m_TopRightTipsBtnContent;

	protected UIModelMapOpeningInfo.PGCMapInfo m_PGCMapInfo;

	protected UGCSimpleDownloadTask m_PGCMapDownloadTask;

	protected UIModelUser m_ModelUser;

	private GameObject m_CSPeakTournamentBgEffect;

	protected const uint GOTOBIND_TIPSCHANGELEVEL = 5u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public UIWidget GetWidget()
	{
		return null;
	}

	public UIButton GetGuideButton()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void SetUIData(uint matchMode, List<MapModeData> dataList, EGameModeUIType gameModeUiType)
	{
	}

	protected virtual ResourceID ClickEffectResID()
	{
		return default(ResourceID);
	}

	protected virtual ResourceID SelectEffectResID()
	{
		return default(ResourceID);
	}

	protected void InitSelectedState()
	{
	}

	public virtual void HideNewModeFX()
	{
	}

	public virtual void SetPickHighLight(bool state)
	{
	}

	public virtual void SetSelectedObjActive(bool show)
	{
	}

	protected void RefreshAvailableMap()
	{
	}

	protected virtual void SetItemUIData(List<MapModeData> dataList)
	{
	}

	protected bool IsPresetRoomMode(MapModeData mapModeData)
	{
		return false;
	}

	protected void updateDownloadList()
	{
	}

	protected virtual bool GamemodeInActivityStyle()
	{
		return false;
	}

	protected void SetDownLoadViewVisiable(bool flag)
	{
	}

	protected virtual void OnDownLoadStateChange(bool flag)
	{
	}

	protected virtual void SetMapModeUI(MapModeData mapModeData)
	{
	}

	protected virtual bool TryGetNetworkTextureSuperiorToMapMode(out string url)
	{
		url = null;
		return false;
	}

	protected virtual void SetInfoCtrlHelperBtnActive(bool active)
	{
	}

	protected virtual bool IsTopRightTakenByInfoCtrl()
	{
		return false;
	}

	public virtual int GetDropdownLikePanelBaseDepth()
	{
		return 0;
	}

	protected void ClipCDNTexture()
	{
	}

	protected void SetOpenDetailsUI()
	{
	}

	private uint GetServerCDNLiveEffectsID(MapModeData mapModeData)
	{
		return 0u;
	}

	protected bool LoadLiveEffects(MapModeData mapModeData)
	{
		return false;
	}

	private void AdjustOverLivePanelDepth()
	{
	}

	private void OnAsyncLoadLiveEffectFinish(uint ticket, bool success, Object obj)
	{
	}

	private bool LoadLiveEffectRes()
	{
		return false;
	}

	public void OnDuoVersionBtnClick()
	{
	}

	private void OnBanMatchBtnClick()
	{
	}

	protected virtual void OnPanelOverLiveEffectsDepthChange(int overLifeEffectPanelDepth)
	{
	}

	public virtual void OnModeBtnClick()
	{
	}

	private bool CheckMapCanPick(MapModeData mapData)
	{
		return false;
	}

	protected void OnMapPickWndConfirm(object[] data)
	{
	}

	protected virtual void OnGameModeVisiableChange(object[] data)
	{
	}

	protected void OnHLDefaultMap(object[] data)
	{
	}

	private void OnMapModeChooseSuccess(object[] data)
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected virtual void OnRoomCreateRuleUpdated()
	{
	}

	protected bool IsPinnedClassicMode(MapModeData mapModeData)
	{
		return false;
	}

	public void SetSelectedMapDataByIndex(int index)
	{
	}

	public void SetCSGuideTip()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void RefreshDuoVersionNode(object[] data)
	{
	}

	protected virtual bool CheckDuoVersionState()
	{
		return false;
	}

	public void RefreshBanMatchView()
	{
	}

	protected virtual bool CheckBanMatchState(ref long punishUntil)
	{
		return false;
	}

	protected virtual bool IsBeforeCurrentRankSeasonInfoStartTime()
	{
		return false;
	}

	protected virtual bool IsCoveredRankGuideAvailable()
	{
		return false;
	}

	public void HideSeasonSwitchNode()
	{
	}

	protected EGameModeRankItemDisplayState GetRankItemTargetDisplayState(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
		return EGameModeRankItemDisplayState.Unknown;
	}

	private void OnGameplayAffixTipsBtnClick()
	{
	}

	private void ShowGameplayAffixDetailsContent(uint gameMode, uint matchMode)
	{
	}

	private void ShowNewPlayerUnlockFeatureDetailPop(uint gameMode, uint matchMode)
	{
	}

	private static bool IsGameplayAffixTipsBtnVisible(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
		return false;
	}

	public static bool IsNewPlayerUnlockFeatureTipsBtnVisible(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
		return false;
	}

	private void RefreshTipsBtnByResID(ResourceID btnRes)
	{
	}

	private void TryCreateTipsBtn()
	{
	}

	private bool _003CInitSelectedState_003Eb__43_0(MapModeData a)
	{
		return false;
	}

	private void _003CSetMapModeUI_003Eb__54_0()
	{
	}

	private void _003COnModeBtnClick_003Eb__69_0()
	{
	}

	private void _003CRefreshBanMatchView_003Eb__86_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
