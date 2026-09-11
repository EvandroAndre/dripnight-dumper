using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISceneEditCategoryController : UIBaseController, IUIModelDataChangeObserver
{
	private class UISceneEditCategoryItemEasyList : IEasyList
	{
		private UISceneEditCategoryController m_Ctrl;

		public UISceneEditCategoryItemEasyList(UISceneEditCategoryController ctrl)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		private void _003COpenItemController_003Eb__2_0(SceneEditSlotInfo slotInfo)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__28_0;

		public static Converter<SceneEditSlotInfo, UISceneEditTemplateMapInfo> _003C_003E9__28_1;

		public static Converter<UISceneEditTemplateMapInfo, UISceneEditUGCCenterController.ETabIndex> _003C_003E9__30_0;

		public static Converter<WorkshopBasicInfo, UISceneEditTemplateMapInfo> _003C_003E9__31_0;

		public static Converter<WorkshopHotInfo, UISceneEditTemplateMapInfo> _003C_003E9__34_0;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__34_1;

		public static Converter<SceneEditSlotInfo, UISceneEditTemplateMapInfo> _003C_003E9__34_2;

		public static Converter<WorkshopHotInfo, UISceneEditTemplateMapInfo> _003C_003E9__34_3;

		public static Predicate<WorkshopAuthorSlotInfo> _003C_003E9__34_4;

		public static Converter<WorkshopAuthorSlotInfo, UISceneEditTemplateMapInfo> _003C_003E9__34_5;

		internal bool _003CRequestData_003Eb__28_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal UISceneEditTemplateMapInfo _003CRequestData_003Eb__28_1(SceneEditSlotInfo temp)
		{
			return null;
		}

		internal UISceneEditUGCCenterController.ETabIndex _003CRefreshUI_003Eb__30_0(UISceneEditTemplateMapInfo e)
		{
			return UISceneEditUGCCenterController.ETabIndex.ETabIndex_Recommendation;
		}

		internal UISceneEditTemplateMapInfo _003CRefreshLatestReleaseMapUI_003Eb__31_0(WorkshopBasicInfo data)
		{
			return null;
		}

		internal UISceneEditTemplateMapInfo _003COnDataChanged_003Eb__34_0(WorkshopHotInfo data)
		{
			return null;
		}

		internal bool _003COnDataChanged_003Eb__34_1(SceneEditSlotInfo e)
		{
			return false;
		}

		internal UISceneEditTemplateMapInfo _003COnDataChanged_003Eb__34_2(SceneEditSlotInfo temp)
		{
			return null;
		}

		internal UISceneEditTemplateMapInfo _003COnDataChanged_003Eb__34_3(WorkshopHotInfo data)
		{
			return null;
		}

		internal bool _003COnDataChanged_003Eb__34_4(WorkshopAuthorSlotInfo e)
		{
			return false;
		}

		internal UISceneEditTemplateMapInfo _003COnDataChanged_003Eb__34_5(WorkshopAuthorSlotInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIModelUGCPremium modelUGCPremium;

		public int value;

		internal void _003CRefreshCategoryTab_003Eb__0()
		{
		}
	}

	private UISceneEditCategoryView m_View;

	private UIModelSceneEdit m_Model;

	private UIPopMenuSmallControler m_SortPopCtrl;

	private List<PopMenuData> m_SortPopMenuDataList;

	private int m_CurTabIndex;

	private List<WorkshopCategoryPageDesc> m_PageDesc;

	private Dictionary<int, List<UISceneEditTemplateMapInfo>> m_CategoryMapInfos;

	private List<UISceneEditCategoryTabItemView> m_TabItems;

	private bool m_HasInit;

	private bool m_RecommHasInit;

	private int m_MostPopularIndex;

	private int m_SubscriptionIndex;

	private const uint UGC_PREMIUN_BENEFIT_MAP_PAGE = 99u;

	private int m_NavigationTab;

	private Dictionary<uint, HashSet<string>> m_ExposedMapDic;

	public int NavigationTab
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public uint GetCurPageId()
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void CheckExposure(bool force = false)
	{
	}

	private void InitPageDesc()
	{
	}

	private void RefreshCategoryTab()
	{
	}

	public void RefreshSelectTab()
	{
	}

	public void SelectNavigationTab()
	{
	}

	private void RequestData(int index)
	{
	}

	private void OnSelectTabItem(UISceneEditCategoryTabItemView item)
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshLatestReleaseMapUI()
	{
	}

	private void OnBtnSearchClick()
	{
	}

	private void OnBtnTurnToSearchMapClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void GenerateSortMenuData()
	{
	}

	public void StoreBeforeClose()
	{
	}

	public void RestoreWhenOpen()
	{
	}

	private void _003COnUIInit_003Eb__20_0(object obj)
	{
	}

	private bool _003COnUIInit_003Eb__20_1(UISceneEditCategoryTabItemView item)
	{
		return false;
	}

	private void _003COnUIInit_003Eb__20_2(object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
