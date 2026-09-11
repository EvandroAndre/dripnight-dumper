using GCommon;

namespace COW;

public class UINewVaultPortraitItemController : UIEasyListItemController, IUINewVaultLovableItem
{
	private UINewVaultPortraitItemView m_View;

	private bool m_IsPlatformHeadpic;

	private UINewVaultItemViewData m_data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	protected override void AfterSelectItem()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshABReady()
	{
	}

	public void RefreshEquipState()
	{
	}

	public void RefreshNewGetState()
	{
	}

	public void RefreshIsLoved(bool playVFX = false)
	{
	}

	private void SetPlatformIcon()
	{
	}

	private void ProcessPlatformHeadpicEquipShow()
	{
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

	public void _003C_003EiFixBaseProxy_AfterSelectItem()
	{
	}
}
