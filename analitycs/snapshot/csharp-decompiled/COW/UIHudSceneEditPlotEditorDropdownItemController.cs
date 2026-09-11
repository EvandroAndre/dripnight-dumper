using GCommon;

namespace COW;

public class UIHudSceneEditPlotEditorDropdownItemController : UIBaseController
{
	public enum EOptionType
	{
		Normal,
		New
	}

	private UIHudSceneEditPlotEditorDropdownItemView m_View;

	private EOptionType m_OptionType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(EOptionType optionType, string content)
	{
	}

	public void ModifyWidth(float width)
	{
	}

	public void SetCallback(EventDelegate.Callback callback)
	{
	}

	public void SetSelected(bool value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
