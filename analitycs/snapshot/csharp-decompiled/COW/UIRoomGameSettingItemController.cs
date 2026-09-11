using GCommon;

namespace COW;

public class UIRoomGameSettingItemController : UIBaseController
{
	private UIRoomGameSettingItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(string title, string text, int titleWidth, bool predictToolEnabel = false, bool predictToolDisable = false, bool trapEnable = false, bool trapDisable = false)
	{
	}

	public void UpdatePresetPos()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
