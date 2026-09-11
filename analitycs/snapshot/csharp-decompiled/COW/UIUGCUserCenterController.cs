using System;
using GCommon;

namespace COW;

public class UIUGCUserCenterController : UINavigationController, IUIModelDataChangeObserver
{
	public enum TabEnum
	{
		Subscribe,
		History,
		Follow
	}

	private UIUGCUserCenterView m_View;

	private UIModelSceneEdit m_Model;

	private UIModelCraftlandProfile m_ModelCraftlandProfile;

	private UIUGCUserCenterLevelInfoController m_LevelInfoCtrl;

	private UIUGCUserCenterCollectionController m_CollectionCtrl;

	private UIUGCUserCenterHistoryPlayedController m_HistoryPlayedCtrl;

	private UIUGCUserCenterFollowController m_FollowCtrl;

	private bool m_IsFeedBackInCD;

	private bool m_IsUpdatingFollowedCreatorListViewedAt;

	private TabEnum m_CurrentTab;

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

	public override void OnWillPopToNavigation(Type targetType, UIBaseNavigationController previousNavigation)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnTabBtnSelectCallback(UIToggleButton button)
	{
	}

	private void OnChildTabSortChange(string oldSortStr, string newSortStr)
	{
	}

	public void TraceEventLogger(string oldTabStr, string oldSortStr, string newTabStr, string newSortStr, UINavigationUtil.UINavigationFrom ui_from = UINavigationUtil.UINavigationFrom.None)
	{
	}

	private string GetCurSortStr(TabEnum tabIndex)
	{
		return null;
	}

	public void ShowTab(TabEnum tabIndex)
	{
	}

	private void RefreshTabBtnSelectedState(TabEnum tabIndex)
	{
	}

	private void RefreshFollowRedMarkerPrompt()
	{
	}

	private void UpdateFollowedCreatorListViewedAtIfNeeded()
	{
	}

	private void OnFeedBackBtnClick()
	{
	}

	public void RefreshFeedBackBtn()
	{
	}

	private void OnSettingBtnClick()
	{
	}

	private void OnTabHelpBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnWillPopToNavigation(Type P0, UIBaseNavigationController P1)
	{
	}
}
