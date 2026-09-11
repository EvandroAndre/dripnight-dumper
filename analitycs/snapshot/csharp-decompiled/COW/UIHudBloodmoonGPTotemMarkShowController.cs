using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBloodmoonGPTotemMarkShowController : UIHudNameBaseController
{
	private const float TARGET_HEIGHT_OFFSET = 2f;

	private const float WIDGET_BOUND_SIZE = 50f;

	private Bloodmoon_GP_TotemMarkShowView m_View;

	private GameObject m_Container;

	private Vector3 m_TargetWorldPosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedShowDistance()
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

	public void BindTotem(Vector3 targetWorldPosition)
	{
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private void RegisterEvents()
	{
	}

	private void UpdateTrackingState(bool tracking)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
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
