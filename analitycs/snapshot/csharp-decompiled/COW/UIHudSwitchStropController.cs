using GCommon;

namespace COW;

internal class UIHudSwitchStropController : UIHudButtonBaseController
{
	public const string BUTTON_MAPPING_NAME = "SwitchStrop";

	private UIHudSwitchStropView m_View;

	private float m_CDEndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshStropCD(bool isUsing)
	{
	}

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
