using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUserCenterFollowController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	public enum SortType
	{
		UpdateTime,
		TimesPlayed
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public UIUGCUserCenterFollowController _003C_003E4__this;

		public List<string> pinnedMaps;

		internal int _003CBuildSortedMapList_003Eb__0(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b)
		{
			return 0;
		}

		internal int _003CBuildSortedMapList_003Eb__1(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b)
		{
			return 0;
		}
	}

	private const string LocKeySortByUpdateTime = "T_43_SJ_WS_SORT_BY_UPDATE";

	private const string LocKeySortByPlayCount = "T_44_HJ_WS_BUTTON_PLAYED";

	private const string LocKeyNoMap = "T_54_SQF_WS_NO_MAP";

	private const string LocKeyHomepageNotPublic = "T_54_SQF_WS_HOMEPAGE_NOT_PUBLIC";

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelCraftlandProfile m_ModelCraftlandProfile;

	private UIUGCUserCenterFollowView m_View;

	private int m_followAuthorListSelectedIndex;

	private UIPopMenuSmallControler m_SortPopMenuCtrl;

	private List<PopMenuData> m_SortMenuDataList;

	private SortType m_CurrentSortType;

	public Action<string, string> OnSortChange;

	private List<UIUGCProfileCraftlandMapController> m_CachedMapSlotItemList;

	public SortType GetCurrentSortType()
	{
		return SortType.UpdateTime;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnEmptyLableBtnClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void GetFollowCount(ref int curCount, ref int maxCount)
	{
	}

	private void RefreshFollowAuthorList()
	{
	}

	private int CompareFollowAuthor(UIUGCUserCenterFollowAuthorItemData a, UIUGCUserCenterFollowAuthorItemData b)
	{
		return 0;
	}

	private void RefreshFollowAuthorListBy(ulong account_id)
	{
	}

	private void OnClickFollowAuthorSettingBtn(UIButton setBtn)
	{
	}

	private void OnClickOperateCancelFollowBtn()
	{
	}

	private void OnClickPinFollowBtnBtn()
	{
	}

	private void OnClickCancelOperationBtn()
	{
	}

	private void RefreshOperateBtnPanel(bool isShow)
	{
	}

	private void RefreshOperateBtnLabel()
	{
	}

	private void UpdateOperateBtnPanelPos(UIButton setBtn)
	{
	}

	private void OnFollowAuthorItemSelected(int dataIndex)
	{
	}

	private void RefreshUIGrid(WorkshopAuthorInfo authorInfo = null)
	{
	}

	private void SetMapSlotEventLog()
	{
	}

	private void InitSortPopMenu()
	{
	}

	private PopMenuData CreateSortMenuData(SortType sortType, string locKey)
	{
		return null;
	}

	private void GenerateSortMenuData()
	{
	}

	private void OnSortSelected(object value)
	{
	}

	private List<UISceneEditRecommendationItemInfo> BuildSortedMapList(WorkshopAuthorInfo authorInfo, List<string> pinnedMaps)
	{
		return null;
	}

	private int CompareMapByUpdateTime(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b, List<string> pinnedMaps)
	{
		return 0;
	}

	private int CompareMapByPlayCount(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b, List<string> pinnedMaps)
	{
		return 0;
	}

	private int CompareMapByPinOrder(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b, List<string> pinnedMaps)
	{
		return 0;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
