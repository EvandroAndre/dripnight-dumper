using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIProfileHistoryHighestTitleController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private UIProfileHistoryHighestTitleView m_View;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelProfile m_ModelProfile;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private List<HighestTitleShowParams> m_BRHighestWeaponTitleShowParams;

	private List<HighestTitleShowParams> m_CSHighestWeaponTitleShowParams;

	private HighestTitleShowParams m_BRHighestRankTitleParam;

	private HighestTitleShowParams m_CSHighestRankTitleParam;

	private HighestTitleShowParams m_CSHighestPeakTitleParam;

	private UIProfileHistoryHighestTitleItemController m_RankItemController;

	private UIProfileHistoryHighestTitleItemController m_PeakItemController;

	private List<UIProfileHistoryHighestTitleItemController> m_WeaponItemControllers;

	private NIKKALKPIBO m_CurrentGameMode;

	private bool m_IsHideTitle;

	private bool m_IsShowTitle;

	private ulong m_AccountId;

	private bool AreaLeaderboardTitleRecordReady;

	private HighestTitleShowParams CurrentRankTitleParam => null;

	private HighestTitleShowParams CurrentPeakTitleParam => null;

	private List<HighestTitleShowParams> CurrentWeaponTitleParams => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetAccountId(ulong accoundId)
	{
	}

	public void RefreshData()
	{
	}

	private void OnGoPosBtn()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnChooseBRClick()
	{
	}

	private void OnChooseCSClick()
	{
	}

	public void RefreshView()
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
