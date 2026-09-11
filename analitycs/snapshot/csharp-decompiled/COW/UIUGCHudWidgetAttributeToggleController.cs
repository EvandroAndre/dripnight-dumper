using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeToggleController : UIUGCHudWidgetAttributeController<bool>
{
	private UIUGCHudWidgetAttributeToggleView m_View;

	public override bool AttributeData
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return UIUGCHudWidgetAttributeEnum.Color;
	}

	protected override void OnUIInit()
	{
	}

	public override void InitAttribute(bool data)
	{
	}

	public void SetViewData(string title)
	{
	}

	private void OnToggleValueChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
