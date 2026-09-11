using GCommon;

namespace COW;

public class UIImageShareEmojiSelectItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIImageShareEmojiSelectItemView m_View;

	private EmojiSelectItemData m_CurItemData;

	private UITipsNormalController m_tipsCtrl;

	private UIModelInventory m_ModelInventory;

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

	public override void OnItemBtnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshGotoButtonVisibility()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
