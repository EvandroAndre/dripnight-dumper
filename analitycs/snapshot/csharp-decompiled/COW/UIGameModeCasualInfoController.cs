using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIGameModeCasualInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public MapModeData map;

		internal bool _003CGetSelectedPickableMaps_003Eb__0(MapModeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public UIGameModeCasualInfoController _003C_003E4__this;

		public GameModeStatsConfigManager.GameModeStatsConfig config;

		internal void _003COnModeStatsBtnClick_003Eb__0()
		{
		}
	}

	public UIGameModeBaseItemController m_ParentController;

	private UIGameModeCasualInfoView m_View;

	private List<MapModeData> m_Data;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelLadderMatch m_ladderModel;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelNewPlayerUnlockFeature m_ModelUnlockFeature;

	private MapModeData m_SelectedMapModeData;

	private CSGetPlayerModeStatsRes m_CurPlayerModeStatsData;

	private UIGameModeNewPlayerUnlockFeatureMediumPreviewController m_GameModePreviewCtrl;

	private ResourceID m_LimitedTimeRankNewSeasonUIFX;

	private GameObject m_LimitedTimeRankNewSeasonGameObject;

	private string m_LimitedTimeRankSeasonKey;

	private int m_CurModeStatsSeasonID;

	private bool m_CurNeedDownLoad;

	private int m_PanelDepth;

	private UICountDownController m_LimitedTimeRankCDCtrl;

	private int m_CurrentSelectedIndex;

	public int CurrentSelectedIndex => 0;

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

	protected override void OnUIDestory()
	{
	}

	public void SetParentController(UIGameModeBaseItemController controller)
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

	private void RefreshCurrentSelectedIndex()
	{
	}

	public void SetUIData(List<MapModeData> dataList)
	{
	}

	private void OnHelpBtnCLick()
	{
	}

	public void SetHelperBtnActive(bool active)
	{
	}

	private void ShowHelpBtn(MapModeData data)
	{
	}

	private void ShowModeStatsBtn(MapModeData data)
	{
	}

	private void ShowLimitedTimeRank(MapModeData data)
	{
	}

	public void OnDownLoadStateChange(bool hasDownLoad)
	{
	}

	public void AdjustPanelDepthWithBase(int depth)
	{
	}

	private void RefreshLimitedTimeRankView()
	{
	}

	private bool NeedShowLimitedTimeRankNewSeasonUIFX()
	{
		return false;
	}

	private bool IsPresetRoomMode(MapModeData data)
	{
		return false;
	}

	private string GetGameModeName(MapModeData data)
	{
		return null;
	}

	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	public void PlayNewPlayerUnlockFeatureSequence()
	{
	}

	public void OnNewPlayerUnlockFeaturePreviewEnd()
	{
	}

	private void UpdateGamePatternUI()
	{
	}

	private void SetTagVfxState()
	{
	}

	public bool IsTagActive()
	{
		return false;
	}

	private List<MapModeData> GetSelectedPickableMaps(uint gameMode, uint matchMode)
	{
		return null;
	}

	private void RefreshOpeningUI()
	{
	}

	private void SetClanWarLevelLimit(bool levelSatisfy)
	{
	}

	private void OnSwitchMapModeClick()
	{
	}

	private void OnLimitedTimeRankBtnClick()
	{
	}

	private void OnLimitedTimeRankNewSeasonBtnClick()
	{
	}

	private void OnModeStatsBtnClick()
	{
	}

	private void OnPlayerModeStatsGet(object[] param)
	{
	}

	private void _003CRefreshLimitedTimeRankView_003Eb__38_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
