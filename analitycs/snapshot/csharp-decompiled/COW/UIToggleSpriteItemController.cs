using GCommon;

namespace COW;

public class UIToggleSpriteItemController : UIBaseController
{
	private UIToggleSpriteItemView m_View;

	private PopMenuData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void SetData(PopMenuData data, int groupID)
	{
	}

	public void SetSpriteByName(string name)
	{
	}

	public virtual void RefreshToggleValue()
	{
	}

	private void OnChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
