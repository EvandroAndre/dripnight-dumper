using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIForgePurchaseController : UIMallPurchaseBaseController
{
	private ChestSpecialExchangeDesc m_ExchangeDesc;

	private Dictionary<int, UISprite> m_ExchangeMaterial;

	private Dictionary<int, UILabel> m_ExchangeMaterialCount;

	protected override int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private bool IsCostEnought()
	{
		return false;
	}

	private void InitMaterialDict()
	{
	}

	public void RefreshData(ChestSpecialExchangeDesc exchangeDesc, bool showModifyCountContainer = false)
	{
	}

	private void SetExchangItem()
	{
	}

	protected void SetExchangeIcon(UISprite sprite, uint itemID)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}
}
