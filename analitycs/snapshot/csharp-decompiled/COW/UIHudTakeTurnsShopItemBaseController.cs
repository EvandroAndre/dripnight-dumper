using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudTakeTurnsShopItemBaseController : UIBaseController
{
	protected UIHudTakeTurnsShopItemViewExt m_View;

	protected CSShopItemData m_Data;

	protected bool m_Selected;

	private uint m_PurchaseCnt;

	private uint m_LimitCnt;

	protected uint m_Quality;

	private uint m_Price;

	private GameObject[] m_BuffTips;

	private float m_StartPressTime;

	private uint m_BuffId;

	private GameObject m_PressedBtn;

	private VisualInstanceHolder m_AdditionalSkinned;

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

	private void Update()
	{
	}

	private void OnItemBtnClick()
	{
	}

	public UIButton GetTutorialBindingBtn()
	{
		return null;
	}

	public UIWidget GetTutorialBindingWidget()
	{
		return null;
	}

	public void SetUIData(CSShopItemData data, uint quality = 0u, bool isPurchaseRefresh = false)
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	private void RefreshPrice(object[] data)
	{
	}

	private void CheckItemsValid()
	{
	}

	private void CheckLimitation()
	{
	}

	private uint GetLimitCount()
	{
		return 0u;
	}

	private void OnItemPurchased(object[] data)
	{
	}

	private bool CheckPriceValid()
	{
		return false;
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void SetSelected(bool v)
	{
	}

	private void OnCoinChanged(int data)
	{
	}

	private void OnShow(object[] data)
	{
	}

	private void RefreshLimitation(object[] data)
	{
	}

	private void OnFreeCardCountChanged(object[] data)
	{
	}

	public void ShowTutorial(TutorialEventEnum eTutorialEvent)
	{
	}

	private void OnODFactionChange(object[] data)
	{
	}

	private void OnItemAccountChanged(uint itemID)
	{
	}

	public void SetBuffData(uint buffId)
	{
	}

	public uint GetDataItemId()
	{
		return 0u;
	}

	private void OnItemPress(GameObject go, bool pressed)
	{
	}

	private void OnItemClick(GameObject go)
	{
	}

	public UIWidget GetItemWidget()
	{
		return null;
	}

	private void ShowDetail()
	{
	}

	public void HideDetail()
	{
	}

	private bool _003CRefreshLimitation_003Eb__32_0(LJCEMHFBNNN i)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
