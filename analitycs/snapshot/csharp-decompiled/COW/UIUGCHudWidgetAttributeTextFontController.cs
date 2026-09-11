using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeTextFontController : UIUGCHudWidgetAttributeController<int>
{
	private UIUGCHudWidgetAttributeTextFontView m_View;

	public override int AttributeData
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return UIUGCHudWidgetAttributeEnum.Color;
	}

	public override void InitAttribute(int data)
	{
	}

	public void SetViewData(string title)
	{
	}

	private void OnFontChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
