using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudTDMLikeShopController : UIHudInGameShopBaseController
{
	private List<uint> m_ChoosedItemList;

	private Dictionary<uint, UIHudCSEquipCategoryController> m_CategroyMap;

	private TDMLikeShopConfigDataManager shopManager;

	private bool _003CPurchased_003Ek__BackingField;

	public bool Purchased
	{
		get
		{
			return _003CPurchased_003Ek__BackingField;
		}
		set
		{
			_003CPurchased_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnInitSpecialUIElement()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetUIData()
	{
	}

	protected override void OnPurchaseBtnClick()
	{
	}

	protected override void OnPurchaseTimeOut()
	{
	}

	protected override void OnCloseBtnClick()
	{
	}

	private void ClearUIData()
	{
	}

	protected override void OnItemSelected(object[] data)
	{
	}

	private void RefreshPrices()
	{
	}

	protected override void OnBuySameBtnClick()
	{
	}

	public void UpdateBuySameButtonEnable(bool isEnable)
	{
	}

	private bool CanModeCloseShopTemparory()
	{
		return false;
	}

	private void OnHelpButtonClick()
	{
	}

	private void OnPurchased(int data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseTimeOut()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBuySameBtnClick()
	{
	}
}
