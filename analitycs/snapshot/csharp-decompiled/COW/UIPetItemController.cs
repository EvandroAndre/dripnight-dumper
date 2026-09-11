using GCommon;
using proto;

namespace COW;

public class UIPetItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIPetCommonItemView m_View;

	private uint m_DelayCallID;

	private PetInfo pet_info;

	private UIModelEvoPass m_ModelEvoPass;

	private bool isSelected;

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

	public void CheckNewTag(object[] param)
	{
	}

	private void LoveInfoChanged(object[] param)
	{
	}

	public void SetCarryShow(PetInfo info)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CLoveInfoChanged_003Eb__14_0()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
