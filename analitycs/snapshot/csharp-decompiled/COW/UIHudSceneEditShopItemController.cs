using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditShopItemController : UIBaseController
{
	public enum EShopItemOp
	{
		EOpItemAdd,
		EOpItemExisted
	}

	private UIHudSceneEditShopItemView m_View;

	private EShopItemOp m_Op;

	private LHFNKEDKCBK m_ShopEditor;

	private string m_BindShelfID;

	private string m_BindItemID;

	private string m_HasItemSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemData(LHFNKEDKCBK editor, string itemID, string shelfID, EShopItemOp op)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void OnItemClick()
	{
	}

	private void OnSwitchBtnClick()
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
