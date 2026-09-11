using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSEnemyMarkController : UIHudNameBaseController
{
	private UIHudCSEnemyMarkView m_View;

	private Vector3 m_BindPos;

	private bool m_NeedUpdatePosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnNewPhaseStarted(object[] data)
	{
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedOptDistanceUpdate()
	{
		return false;
	}

	protected override void OnDistanceLabelChanged()
	{
	}

	public void BindTarget(Vector3 pos)
	{
	}

	public void UnBindTarget()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedOptDistanceUpdate()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceLabelChanged()
	{
	}
}
