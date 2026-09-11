using GCommon;

namespace COW;

public class UIVirtualBrandSetItemController : UIEasyListItemController
{
	private UIVirtualBrandSetItemView m_View;

	private uint m_SetId;

	private UIModelVirtualBrand.BrandSetState m_SetState;

	private UIModelVirtualBrand m_model;

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

	public void SetSelected(bool isSelected)
	{
	}

	public void PlayAnim(bool play)
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
