using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNameBaseController : UIBaseController
{
	private FollowCamera m_FollowCamera;

	protected Camera m_FollowCameraComponent;

	protected OUTSCREEN_DIRCTION_TYPE m_dirctionType;

	protected GameObject m_ArrowLeft;

	protected GameObject m_ArrowUp;

	protected GameObject m_ArrowRight;

	protected GameObject m_ArrowDown;

	protected UILabel m_DistanceLabel;

	protected int m_PrevDistance;

	private StringBuilder m_DistanceStr;

	private MutableString m_DistanceMutableStr;

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected virtual Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected virtual bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected virtual bool NeedKeepInScreen()
	{
		return false;
	}

	protected virtual bool NeedUpdatePosition()
	{
		return false;
	}

	protected virtual bool NeedShowDistance()
	{
		return false;
	}

	protected virtual bool NeedOptDistanceUpdate()
	{
		return false;
	}

	protected virtual void OnDistanceChanged(float distance)
	{
	}

	protected virtual bool NeedShowOutScreenAllow()
	{
		return false;
	}

	protected virtual bool KeepShowDownArrow()
	{
		return false;
	}

	protected virtual void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
	{
	}

	protected virtual void LateUpdate()
	{
	}

	protected virtual void UpdateNamePosition()
	{
	}

	protected virtual float GetScaleFactorDefault()
	{
		return 0f;
	}

	protected virtual float GetScaleFactorDeltaChangeByMetre()
	{
		return 0f;
	}

	private void SetDistance(int distance)
	{
	}

	protected virtual void OnDistanceLabelChanged()
	{
	}

	protected virtual Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected virtual Vector4 GetWidgetDirOffset()
	{
		return default(Vector4);
	}

	protected virtual Vector3 ExtraScreenGap()
	{
		return default(Vector3);
	}

	protected virtual bool IsVisibleWithZoneType(int zonetype)
	{
		return false;
	}

	protected virtual void OnTrainingZoneChanged(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
