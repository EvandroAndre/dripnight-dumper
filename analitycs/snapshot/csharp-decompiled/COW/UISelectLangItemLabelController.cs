using GCommon;

namespace COW;

public class UISelectLangItemLabelController : UISelectLangItemController
{
	private UIToggleItemView m_View;

	private PopMenuData m_Data;

	protected UILabel m_SelectLabel => null;

	protected UILabel m_UnSelectLabel => null;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(PopMenuData data, int groupID)
	{
	}

	public override void RefreshToggleValue()
	{
	}

	private void OnChange()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_SetData(PopMenuData P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshToggleValue()
	{
	}
}
