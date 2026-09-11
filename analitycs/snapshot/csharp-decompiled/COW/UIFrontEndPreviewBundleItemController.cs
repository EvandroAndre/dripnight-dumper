using GCommon;

namespace COW;

public class UIFrontEndPreviewBundleItemController : UIEasyListItemController
{
	private UIFrontEndPreviewBundleItemView m_View;

	private CSSharedItemData m_itData;

	private UIModelInventory m_ModelInventory;

	private ShowBoostAvatarParams m_ShowBoostAvatarParmas;

	private BaseItemInfo m_Data;

	private new uint m_Index;

	private UIStandardItemMini2Controller ctrl;

	private bool m_IsItemABReady;

	private bool m_RefreshPreview;

	private const uint m_itemClothFemaleMin = 203000578u;

	private const uint m_itemClothFemaleMax = 203999999u;

	private const uint m_itemClothMaleMin = 211000343u;

	private const uint m_itemClothMaleMax = 211999999u;

	private const string HIDDEN_PAGE_DESC_TITLE_KEY = "T_34_XY_HYPERBOOK_HIDDENTITLE";

	private const string HIDDEN_PAGE_DESC_CONTENT_KEY = "T_34_XY_HYPERBOOK_HIDDENDEC";

	private uint m_OriginalItemID;

	private uint m_ClothesSetID;

	private UISmallDetailTipsController m_CurrentTips;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public void SetRefreshPreviewState(bool flag)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	private void SetTreasureBoxProbabilityState()
	{
	}

	private void SetTreasureBoxProbabilityStateOnUnSelect()
	{
	}

	public bool CheckIDInvaild(uint itemid)
	{
		return false;
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void RefreshData()
	{
	}

	public void SetOriginalItemID(uint id)
	{
	}

	public void SetClothesSetID(uint id)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void CheckItemABReady(uint itemID)
	{
	}

	private bool CheckIsHyperBookHiddenPageItem(uint originalID, uint itemID)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
