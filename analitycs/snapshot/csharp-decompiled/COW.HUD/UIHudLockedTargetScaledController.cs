using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudLockedTargetScaledController : UIHudVehicleAsMissileTargetControllerBase
{
	private UIHudLockedTargetScaledView m_View;

	public Vector2 MaxViewSize;

	public Vector2 MinViewSize;

	private Transform m_SpriteTrans;

	private Vector2 m_SpriteSize;

	private Vector2 m_ScreenSize;

	private bool m_TweeningAlpha;

	private float m_TweenAlphaEndTime;

	private AudioResource m_AudioRes;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void RecycleUI()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void BindTarget(Entity e)
	{
	}

	public override void SetAsAimTarget(bool b, object[] data)
	{
	}

	protected void InitAlphaTween(float time)
	{
	}

	protected void UpdateAlphaTween()
	{
	}

	protected void StartAlphaTween()
	{
	}

	protected void StopAlphaTween()
	{
	}

	protected void StopLoopSound()
	{
	}

	protected override void DoUpdate()
	{
	}

	private void UpdateScale()
	{
	}

	private Vector2 CalcPreferedSize(Camera cam, Transform localTrans, Vector3 size)
	{
		return default(Vector2);
	}

	private void UpdateMinMax(Vector2 v, ref Vector2 min, ref Vector2 max)
	{
	}

	private Vector2 CalcClampedSize(Vector2 size)
	{
		return default(Vector2);
	}

	private Vector2 CalcScale(Vector2 size)
	{
		return default(Vector2);
	}

	private void ApplyScale(Vector2 scale)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_RecycleUI()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_BindTarget(Entity P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetAsAimTarget(bool P0, object[] P1)
	{
	}

	public void _003C_003EiFixBaseProxy_DoUpdate()
	{
	}
}
