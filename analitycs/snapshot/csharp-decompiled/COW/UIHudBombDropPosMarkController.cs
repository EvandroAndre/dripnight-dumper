using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudBombDropPosMarkController : UIHudNameBaseController
{
	private UIHudBombDropPosMarkView m_View;

	private Vector3 m_BombPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnBombPickupDrop(object[] data)
	{
	}

	private void OnBombPickupGet(object[] data)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	private void OnODFactionChanged(object[] data)
	{
	}

	protected override void LateUpdate()
	{
	}

	private void UpdateNameAlpha()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}
}
