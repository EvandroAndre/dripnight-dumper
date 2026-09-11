using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_CheckPointMarkShowController : UIHudNameBaseController
{
	private UIHUDUGC_CheckPointMarkShowView m_View;

	private Vector3 m_BindWorldPosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(Vector3 targetPosition)
	{
	}

	public void SetEndPoint(bool isEnd)
	{
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedOptDistanceUpdate()
	{
		return false;
	}

	protected override void OnDistanceLabelChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedOptDistanceUpdate()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceLabelChanged()
	{
	}
}
