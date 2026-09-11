using GCommon;

namespace COW;

public class UILuckyBuffBattleItemController : UIEasyListItemController
{
	private UILuckyBuffBattleController m_LuckyBuffBattleCtrl;

	private UIStandardItemMiniController m_ItemMiniController;

	private UILuckyBuffBattleItemView m_View;

	private BaseItemInfo m_BaseItemInfo;

	private CSSharedItemData m_ItemData;

	private FullScreenAnimParams m_AnimParams;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetDownloadInfoState(object[] data)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	protected virtual void OnClothItemClick()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
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
