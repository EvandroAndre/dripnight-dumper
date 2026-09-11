using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudHippoCrisisRetreatPointMarkShowController : UIHudNameBaseController
{
	private static int PHASE_FIGHT_START_LAST_SEC;

	private static int IS_VISIBLE_DISTANCE;

	private UIHudHippoCrisisRetreatPointMarkShowView m_View;

	private LevelWeRunRetreatPoint m_LevelRetreatPoint;

	private uint m_CurPhaseStartTime;

	private MKEIPDPNLOP m_CurPhase;

	private bool m_WaitToTween;

	private bool m_IsNeedVisible;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
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

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override Vector4 GetWidgetDirOffset()
	{
		return default(Vector4);
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	private void OnTweenFinished()
	{
	}

	private void OnHippoCrisisGamePhaseChanged(object[] data)
	{
	}

	public void RefreshVisibleState()
	{
	}

	private void SetVisibleByFarAway(bool isVisible)
	{
	}

	public void SetBindLevelRetreatPoint(LevelWeRunRetreatPoint retreatPoint)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
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

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public Vector4 _003C_003EiFixBaseProxy_GetWidgetDirOffset()
	{
		return default(Vector4);
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}
}
