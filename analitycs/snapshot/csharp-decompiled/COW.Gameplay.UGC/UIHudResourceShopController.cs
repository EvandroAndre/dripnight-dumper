using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UIHudResourceShopController : UIPopupWindowController, IEasyList
{
	private enum RecommendTemplateType
	{
		Banner,
		Item
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public EUGCResourceShopTab mainTab;

		public UIHudResourceShopController _003C_003E4__this;

		internal void _003CCreateTabCtrl_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_1
	{
		public int mainCategory;

		public _003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals1;

		internal void _003CCreateTabCtrl_003Eb__1()
		{
		}
	}

	private UIHudResourceShopView m_View;

	private HNDHJGJILHC m_Game;

	private SceneEditResourceShopManager m_Manager;

	private UIModelSceneEdit m_Model;

	public EUGCResourceShopTab MainTab;

	public int MainCategory;

	public int SubCategory;

	public int SortId;

	public string SearchValue;

	private List<UGCResourceShopItem> m_DataList;

	private UIHudResourceShopSubCategoryController m_SubCategoryController;

	private UIStandardDrawerTabRemakeController m_TabCtrl;

	private Dictionary<int, List<ResourceShopSubCategoryItem>> CategoryDictionary;

	private List<string> m_TipsData;

	private float m_ScrollViewOriginalY;

	private List<PopMenuData> m_SortPopMenuList;

	private UIPopMenuSmallControler m_SortPopMenu;

	private Dictionary<int, ResourceShopSort> m_ShopSortConfig;

	private Dictionary<int, ResourceShopTypeItem> m_ShopTabConfig;

	private static readonly Vector2 RecommendBannerSize;

	private static readonly Vector2 RecommendItemSize;

	private static readonly string BGURL;

	private bool m_IsExcessBounds;

	private int GetSortTypeByValue(string value)
	{
		return 0;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void LoadResourceShopConfig()
	{
	}

	private void CreateTabCtrl()
	{
	}

	public void GotoStore(int tab, int mainCategory)
	{
	}

	private void OnMainTabSelected(EUGCResourceShopTab mainTab)
	{
	}

	private void OnMainCategorySelected(int mainCategory)
	{
	}

	private void OnSubCategorySelected(int subCategory)
	{
	}

	public void RefreshShopItemView(bool resetScroll = true)
	{
	}

	private void OnUploadBtnClicked()
	{
	}

	private void OnCloseBtnClicked()
	{
	}

	private void OnTips()
	{
	}

	private void OnBtnStore()
	{
	}

	private void ResetState()
	{
	}

	private void UpdateLibrary()
	{
	}

	private void UpdateLabelNum()
	{
	}

	private void UpdateUpload()
	{
	}

	private void UpdateOwned()
	{
	}

	private void UpdateShopItemData()
	{
	}

	private void InitRecommendTable2Templates()
	{
	}

	private void RefreshRecommendTable2Data(bool resetScroll = false)
	{
	}

	private void OnRecommendationDataChanged(object[] data)
	{
	}

	public void GetUploadItems(int mainCategory, int subCategory, ref List<UGCResourceShopItem> dataList)
	{
	}

	public void GetOwnedItems(int mainCategory, int subCategory, ref List<UGCResourceShopItem> dataList)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnStoppedMoving()
	{
	}

	private void CheckRecommendationExposure()
	{
	}

	private void OnDragExcessBounds()
	{
	}

	private UGCResourceShopDisplayData GetDisplayData(string searchValue, int mainCategory, int subCategory, int sortId)
	{
		return null;
	}

	private void OnPageDataRequested(object[] data)
	{
	}

	private void ClearSearch()
	{
	}

	private void OnSearchClear()
	{
	}

	private void OnSearchSubmit()
	{
	}

	private void GenerateSortPopList()
	{
	}

	private void OnSortSelected(object data)
	{
	}

	private void SetSearchRelevantActive(bool isShow)
	{
	}

	private UITable2.IUITable2Item _003CInitRecommendTable2Templates_003Eb__44_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitRecommendTable2Templates_003Eb__44_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
