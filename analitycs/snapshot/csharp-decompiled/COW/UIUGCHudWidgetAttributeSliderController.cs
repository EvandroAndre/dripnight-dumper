using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeSliderController : UIUGCHudWidgetAttributeController<int>
{
	private UIUGCHudWidgetAttributeSliderView m_View;

	private int m_MinValue;

	private int m_MaxValue;

	private int m_Length;

	private bool m_IsAlpha;

	public bool IsAlpha
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

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

	public void SetViewData(string title, int MinValue, int MaxValue, int step = 0)
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

	private void OnSliderChanged()
	{
	}

	private void OnDragFinished()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
