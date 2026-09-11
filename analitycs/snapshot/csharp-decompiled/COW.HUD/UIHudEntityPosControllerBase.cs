using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public abstract class UIHudEntityPosControllerBase : UIBaseController
{
	protected enum EArrowDirection
	{
		NONE,
		UP,
		DOWN,
		LEFT,
		RIGHT
	}

	protected Entity m_TargetEntity;

	internal Player m_TargetPlayer;

	public Camera Cam;

	protected GameObject Container;

	protected GameObject icon;

	protected UILabel DistanceLabel;

	protected UILabel BGM;

	protected UISprite ArrowUp;

	protected UISprite ArrowLeft;

	protected UISprite ArrowRight;

	protected UISprite ArrowDown;

	protected bool m_EventsRegistered;

	protected float m_EntityPosOffset;

	private float viewPortBoundary;

	private Vector2 m_MinimapSize;

	private Vector2 m_ArrowHalfSize;

	private int m_PrevDistance;

	private Vector3 m_LastViewPos;

	private float m_MarginUp;

	protected bool m_ShowArrows;

	protected bool m_ShowDistance;

	protected bool HasBinding => false;

	protected virtual void UpdateTargetPlayer()
	{
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

	private void RegisterEvents()
	{
	}

	private void UnRegisterEvents()
	{
	}

	protected virtual void OnRegisterEvents()
	{
	}

	protected virtual void OnUnRegisterEvents()
	{
	}

	public virtual void BindTarget(Entity e)
	{
	}

	public virtual void UnBindTarget()
	{
	}

	public virtual void RecycleUI()
	{
	}

	protected void LateUpdate()
	{
	}

	protected virtual void DoUpdate()
	{
	}

	protected void UpdatePosition()
	{
	}

	protected void UpdatePositionNoArrows(Vector3 viewPos)
	{
	}

	protected void UpdatePositionWithArrow(Vector3 viewPos)
	{
	}

	protected void SetViewPos(Vector3 viewPos)
	{
	}

	protected void UpdateDistance()
	{
	}

	protected Vector2 ViewDistance(MonoBehaviour a, MonoBehaviour b, bool view)
	{
		return default(Vector2);
	}

	protected virtual Vector3 GetRefPos(Entity e)
	{
		return default(Vector3);
	}

	protected void ShowArrowDirection(EArrowDirection direction)
	{
	}

	protected void SetViewActive(MonoBehaviour obj, bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
