using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeImageFlipController : UIUGCHudWidgetAttributeController<UIBasicSprite.Flip>
{
	private UIUGCHudWidgetAttributeImageFlipView m_View;

	public override UIBasicSprite.Flip AttributeData
	{
		get
		{
			return UIBasicSprite.Flip.Nothing;
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

	private void OnHorizontalChanged()
	{
	}

	private void OnVerticalChanged()
	{
	}

	private void UpdateFlip()
	{
	}

	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return UIUGCHudWidgetAttributeEnum.Color;
	}

	public override void InitAttribute(UIBasicSprite.Flip data)
	{
	}

	public void SetViewData(string title)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
