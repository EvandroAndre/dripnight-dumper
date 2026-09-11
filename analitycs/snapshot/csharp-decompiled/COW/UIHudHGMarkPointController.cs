using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHGMarkPointController : UIHudNameBaseController
{
	private UIHudHGMarkPointView m_View;

	private Vector3 m_MarkPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetMarkPos(Vector3 pos)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool KeepShowDownArrow()
	{
		return false;
	}

	protected override void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_KeepShowDownArrow()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE P0)
	{
	}
}
