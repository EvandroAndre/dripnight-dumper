using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetAttributeCustomAdaptController : UIUGCHudWidgetAttributeController<Vector2Int>
{
	private UIUGCHudWidgetAttributeCustomAdaptView m_View;

	public override Vector2Int AttributeData
	{
		get
		{
			return default(Vector2Int);
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

	public override void InitAttribute(Vector2Int data)
	{
	}

	private void OnHorizontalValueChanged(int value)
	{
	}

	private void OnVerticalValueChanged(int value)
	{
	}

	private void UpdateAnchorIcon(int x, int y)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
