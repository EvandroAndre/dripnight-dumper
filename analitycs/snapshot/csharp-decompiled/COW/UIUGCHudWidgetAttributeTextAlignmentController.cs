using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeTextAlignmentController : UIUGCHudWidgetAttributeController<NGUIText.Alignment>
{
	private UIUGCHudWidgetAttributeTextAlignmentView m_View;

	public override NGUIText.Alignment AttributeData
	{
		get
		{
			return NGUIText.Alignment.Automatic;
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

	public override void InitAttribute(NGUIText.Alignment data)
	{
	}

	public void SetViewData(string title)
	{
	}

	private void OnLeftChanged()
	{
	}

	private void OnCenterChanged()
	{
	}

	private void OnRightChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
