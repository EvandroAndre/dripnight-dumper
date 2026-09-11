using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudJoystick : UGCHudWidget
{
	protected BoxCollider m_Col;

	public UISprite m_Joystick;

	public UISprite m_JoystickBG;

	public UISprite m_Arrow;

	private UIEventTrigger m_Trigger;

	private EventDelegate m_OnPress;

	private EventDelegate m_OnRelease;

	private EventDelegate m_OnDrag;

	private UICamera.MouseOrTouch m_Touch;

	private bool m_Pressed;

	private Vector2 m_Pos;

	private Vector2 m_RootPos;

	public Vector2 m_DefaultPos;

	public int m_JoystickCapDragRadius;

	public int m_ArrowOffset;

	public float m_ActivatedAlpha;

	public float m_InactivatedAlpha;

	private object[] m_EventArgs1;

	public BoxCollider Col => null;

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	private void Update()
	{
	}

	protected override void OnInternalEnable()
	{
	}

	protected override void OnInternalDisable()
	{
	}

	public void Register()
	{
	}

	public void Unregister()
	{
	}

	public void OnPressEvent()
	{
	}

	public void OnReleaseEvent()
	{
	}

	public void OnDragEvent()
	{
	}

	public void SendEndEvent()
	{
	}

	public void RefreshState()
	{
	}

	public void OnApplicationFocus(bool focus)
	{
	}

	public override void SetLayer(int layer)
	{
	}

	public override Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public override void SetParentHasChanged()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_OnInternalEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInternalDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_SetLayer(int P0)
	{
	}

	public Vector2Int _003C_003EiFixBaseProxy_SetDepth(Vector2Int P0, int P1)
	{
		return default(Vector2Int);
	}

	public new void _003C_003EiFixBaseProxy_SetParentHasChanged()
	{
	}
}
