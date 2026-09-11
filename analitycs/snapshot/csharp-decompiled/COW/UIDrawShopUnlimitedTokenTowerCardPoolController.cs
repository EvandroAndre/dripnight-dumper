using GCommon;

namespace COW;

public class UIDrawShopUnlimitedTokenTowerCardPoolController : UIDrawShopUnlimitedCardPoolController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void SetCommonData(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	protected override bool TryGetGoodsInfo(uint goodsId, out BaseItemInfo itemInfo, out bool isRemove, out bool isRare, out UIModelDrawShop.RepeatChangeItemInfo repeatChangeInfo)
	{
		itemInfo = null;
		isRemove = default(bool);
		isRare = default(bool);
		repeatChangeInfo = null;
		return false;
	}

	protected override void OnTitleClick()
	{
	}

	public uint GetTokenCount()
	{
		return 0u;
	}

	protected override UIModelDrawShop.EDrawShopWheelCustomType GetCardPoolShowCustomType()
	{
		return UIModelDrawShop.EDrawShopWheelCustomType.Common;
	}

	protected override UIDrawShopCommonCardPoolShowController OpenCardPoolShowController(UIModelDrawShop.EDrawShopWheelCustomType customType)
	{
		return null;
	}

	protected override void RefreshTopCardPoolBG()
	{
	}

	public void _003C_003EiFixBaseProxy_SetCommonData(UIModelDrawShop.DrawShopContentDataBase P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_TryGetGoodsInfo(uint P0, out BaseItemInfo P1, out bool P2, out bool P3, out UIModelDrawShop.RepeatChangeItemInfo P4)
	{
		P1 = null;
		P2 = default(bool);
		P3 = default(bool);
		P4 = null;
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnTitleClick()
	{
	}

	public UIModelDrawShop.EDrawShopWheelCustomType _003C_003EiFixBaseProxy_GetCardPoolShowCustomType()
	{
		return UIModelDrawShop.EDrawShopWheelCustomType.Common;
	}

	public UIDrawShopCommonCardPoolShowController _003C_003EiFixBaseProxy_OpenCardPoolShowController(UIModelDrawShop.EDrawShopWheelCustomType P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RefreshTopCardPoolBG()
	{
	}
}
