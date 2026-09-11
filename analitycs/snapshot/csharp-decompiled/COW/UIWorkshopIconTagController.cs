using GCommon;

namespace COW;

public class UIWorkshopIconTagController : UIWorkshopModeTagController
{
	private UIWorkshopIconTagView m_IconView;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetIcon(string spriteName)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
