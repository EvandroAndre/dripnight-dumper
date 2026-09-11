using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIHudResourceShopItemDetailController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIHudResourceShopItemDetailController _003C_003E4__this;

		public Dictionary<ulong, ShopAuthorInfo> dic;

		public ulong accountId;

		public ShopAuthorInfo info;

		internal void _003CUpdateAuthorInfo_003Eb__0()
		{
		}
	}

	private UIHudResourceShopItemDetailView m_View;

	private SceneEditResourceShopManager m_Manager;

	private UGCResourceShopMetaData m_MetaData;

	private List<UIWorkshopModeTagController> m_Tags;

	private EUGCResourceShopTab m_MainTab;

	private string m_SearchValue;

	private int m_MainCategory;

	private int m_SubCategory;

	private int m_Index;

	private bool m_IsAISearch;

	private int m_RecommendTypeId;

	private int m_RecommendEventId;

	private int m_TextureOriWidth;

	private int m_TextureOriHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void UpdateDetail(object[] data)
	{
	}

	private void OnLikeChanged(object[] data)
	{
	}

	public void SetData(UGCResourceShopMetaData metaData, EUGCResourceShopTab mainTab, string searchValue = "", int mainCategory = 0, int subCategory = 0, int index = 0, bool bAISearch = false, int recommendTypeId = 0, int recommendEventId = 0)
	{
	}

	private void TryLogPurchase()
	{
	}

	private void UpdateReviewResult()
	{
	}

	private void UpdateLike()
	{
	}

	private void UpdateTags()
	{
	}

	private void UpdateAuthorInfo()
	{
	}

	private void UpdateState()
	{
	}

	private void OnBtnRemoveClick()
	{
	}

	private void OnBtnUseClick()
	{
	}

	private void OnBtnAddClick()
	{
	}

	private void OnBtnDownloadClick()
	{
	}

	private void OnBtnTakeDownClick()
	{
	}

	private void OnBtnCodeClick()
	{
	}

	private void OnBtnReportClick()
	{
	}

	private void OnBtnLikeClick()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void _003COnBtnRemoveClick_003Eb__25_0()
	{
	}

	private void _003COnBtnTakeDownClick_003Eb__29_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
