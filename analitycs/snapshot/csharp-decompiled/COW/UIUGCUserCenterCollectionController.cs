using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIUGCUserCenterCollectionController : UIBaseController, IUIModelDataChangeObserver
{
	public enum SortType
	{
		SubscriptionTime,
		TimesPlayed
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__16_0;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__17_0;

		internal bool _003CGetCollectionCount_003Eb__16_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CRefreshUIGrid_003Eb__17_0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public List<WorkshopHistoryInfo> historyInfo;

		internal UISceneEditTemplateMapInfo _003CRefreshUIGrid_003Eb__1(SceneEditSlotInfo temp)
		{
			return null;
		}
	}

	private const string LocKeySortBySubscribeTime = "T_44_HJ_WS_BUTTON_SUBTIME";

	private const string LocKeySortByPlayCount = "T_44_HJ_WS_BUTTON_PLAYED";

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIUGCUserCenterCollectionView m_View;

	private List<UIUGCUnifiedMapSlot1Controller> m_CachedCollectionItemList;

	private List<PopMenuData> m_SortMenuDataList;

	private UIPopMenuSmallControler m_SortPopMenuCtrl;

	private SortType m_CurrentSortType;

	public Action<string, string> OnSortChange;

	public SortType GetCurrentSortType()
	{
		return SortType.SubscriptionTime;
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

	protected override void OnVisibilityChanged()
	{
	}

	private void OnCollectionEmptyBtnClick()
	{
	}

	public void GetCollectionCount(ref int curCount, ref int maxCount)
	{
	}

	private void RefreshUIGrid()
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

	private void SortSubscriptionList(List<UISceneEditTemplateMapInfo> subscriptionList)
	{
	}

	private int OnSortBySubscribedTime(UISceneEditTemplateMapInfo a, UISceneEditTemplateMapInfo b)
	{
		return 0;
	}

	private int OnSortByPlayCount(UISceneEditTemplateMapInfo a, UISceneEditTemplateMapInfo b)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
