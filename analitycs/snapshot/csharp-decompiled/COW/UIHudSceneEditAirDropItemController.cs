using GCommon;

namespace COW;

internal class UIHudSceneEditAirDropItemController : UIBaseController
{
	public enum EShopItemOp
	{
		EOpItemAdd,
		EOpItemExisted
	}

	private UIHudSceneEditAirDropItemView m_View;

	private EShopItemOp m_Op;

	private int m_BindItemID;

	private int m_MapIndex;

	private int m_BindItemNum;

	private EShopItemOp m_SelectedOp;

	private int m_SelectedItemID;

	private int m_SelectedMapIdx;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemData(int itemID, int num, int index, EShopItemOp op)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void RefreshState()
	{
	}

	private void OnItemClick()
	{
	}

	private void OnDelBtnClick()
	{
	}

	private void OnTSFinishedCallBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
