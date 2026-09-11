using GCommon;

namespace COW;

public class UISettingTabButton
{
	public delegate void ClickCallback(SettingPageType pageType);

	private UIToggleButton Button;

	private SettingPageType ToggleType;

	private ClickCallback m_Callback;

	public UISettingTabButton(UIToggleButton button, SettingPageType type, ClickCallback callback)
	{
	}

	public void Unbind()
	{
	}

	private void OnButtonClick()
	{
	}
}
