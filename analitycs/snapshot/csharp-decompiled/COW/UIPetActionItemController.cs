using GCommon;

namespace COW;

public class UIPetActionItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIPetActionItemView m_View;

	private PetActionData action_info;

	private CSSharedItemData inventoryItem;

	private UIStandardItemMAXBController m_UIStandardItemMAXBController;

	private bool isSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void PlayAction()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void SetHighLightBGState(bool show)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshData()
	{
	}

	private void RefreshPetDownloadInfo(object[] data)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
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

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
