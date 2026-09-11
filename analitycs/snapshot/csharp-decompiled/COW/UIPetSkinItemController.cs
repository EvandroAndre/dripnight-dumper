using GCommon;

namespace COW;

public class UIPetSkinItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIPetSkinItemView m_View;

	private PetSkinData skin_info;

	private CSSharedItemData inventoryItem;

	private UIStandardItemMAXBController m_UIStandardItemMAXBController;

	private bool m_IsSelected;

	private UIPetInfoController m_UIPetInfoController;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SelectSkin()
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

	private void RefreshPetDownloadInfo(object[] data)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshData()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetPetInfoController(UIPetInfoController ctrl)
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
