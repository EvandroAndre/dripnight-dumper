using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetAttributeColorController : UIUGCHudWidgetAttributeController<Color>
{
	private UIUGCHudWidgetAttributeColorView m_View;

	public override Color AttributeData
	{
		get
		{
			return default(Color);
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

	public override void InitAttribute(Color data)
	{
	}

	public void SetViewData(string title)
	{
	}

	private void OnBtnClick()
	{
	}

	private void _003COnBtnClick_003Eb__9_0(Color value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
