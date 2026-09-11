using GCommon;

namespace COW;

internal class UIHudBuildingSwitchInfoController : UIBaseController
{
	public UIHudBuildingSwitchInfoView m_View;

	public int Index;

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

	public string GetSpriteName()
	{
		return null;
	}

	public void SetSprite(string name)
	{
	}

	private void OnSwitchBuildingClick()
	{
	}

	public bool GetHighlight()
	{
		return false;
	}

	public void SetHighlight(bool val)
	{
	}

	private void OnIndexChange(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
