using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanSearchController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private AutoPopup m_AutoPopup;

	private UIClanSearchView m_View;

	private UIModelClan m_ModelClan;

	private UIModelUser m_ModelUser;

	private UIModelQRCode m_ModelQRCode;

	private const int COOLDOWN_SECONDS = 5;

	private const int SEARCH_COOLDOWN_SEC = 1;

	private CountDownConfig config;

	private CountDownConfig m_SearchConfig;

	private int CLAN_ID_LENGTH_MIN;

	private const int FILTER_COUNTDOWN_SECONDS = 5;

	private uint m_FilterCallID;

	private string m_regionSelected;

	private string m_styleSelected;

	private string[] m_SloganLabels;

	private uint m_Area;

	private EClanApproval m_ApprovalState;

	private uint m_ClanLevel;

	private uint m_ClanMemNum;

	private List<uint> m_Tags;

	private bool m_IsRefreshEnable;

	private bool m_IsSearchEnable;

	private ClanInfo m_CurSelectItemClanInfo;

	private EClanSearchOpenState m_OpenState;

	private List<UIClanListItemController> m_Items;

	private UIClanBriefBoxController m_BriefBoxController;

	private bool m_HasSetNaviBar;

	public ClanInfo CurSelectItemClanInfo => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void OnClickFilter()
	{
	}

	private void OnSearchPopMenuClick(object[] data)
	{
	}

	private void OnQRScanBtnClick()
	{
	}

	private void OnChoose()
	{
	}

	private void RefreshFilterResult()
	{
	}

	private void FilterCountDown()
	{
	}

	private void InFilterCDTime(bool isInTime)
	{
	}

	private void OnFilterClanList()
	{
	}

	public void ReadyShowAssistClanInviteView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshClanList<DataType>(List<DataType> clanList)
	{
	}

	private void OnBtnClanCreated()
	{
	}

	private void OnBtnClanRefresh()
	{
	}

	private void OnCountDownStarted()
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void OnBtnClanSearch()
	{
	}

	public void SearchClanById(string clanId)
	{
	}

	private void OnInputChanged()
	{
	}

	private void OnBtnInputClear()
	{
	}

	private void OnSearchCountDownStarted()
	{
	}

	private void OnSearchCountDownFinished()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void RefreshClanDetail(ClanInfo info)
	{
	}

	private void OnClanItemStateChanged(object[] data)
	{
	}

	private static void GotoClanLeaderboard()
	{
	}

	private void PrepareTopBarTokens()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
