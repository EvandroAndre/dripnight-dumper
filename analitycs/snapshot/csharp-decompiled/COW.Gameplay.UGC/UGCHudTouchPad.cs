using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudTouchPad : UGCHudWidget
{
	protected BoxCollider m_Col;

	private bool m_AllowPressedOutside;

	private bool m_Pressed;

	private bool m_Dragging;

	private Vector2 m_LastPos;

	private UICamera.MouseOrTouch m_Touch;

	private UIEventTrigger m_Trigger;

	private EventDelegate m_OnPress;

	private EventDelegate m_OnRelease;

	private EventDelegate m_OnDragStart;

	private EventDelegate m_OnDrag;

	private EventDelegate m_OnDragEnd;

	private object[] m_EventArgs1;

	private object[] m_EventArgs2;

	private object[] m_EventArgs4;

	public BoxCollider Col => null;

	public bool AllowPressedOutside
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
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

	public void OnDragStartEvent()
	{
	}

	public void OnDragEvent()
	{
	}

	public void OnDragEndEvent()
	{
	}

	public void SendEndEvent()
	{
	}

	public void OnApplicationFocus(bool focus)
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
}
