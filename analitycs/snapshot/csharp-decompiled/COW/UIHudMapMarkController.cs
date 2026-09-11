using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMapMarkController : UIHudNameBaseController
{
	private UIHudMapMarkView m_View;

	private Vector3 m_MarkPosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	private void DelayClose()
	{
	}

	private void RefreshMarkIconSprite(UISprite icon, int index)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}
}
