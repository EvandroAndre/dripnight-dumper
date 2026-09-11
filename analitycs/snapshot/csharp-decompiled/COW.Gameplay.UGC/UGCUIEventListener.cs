using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCUIEventListener : MonoBehaviour
{
	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	private static UIEventMutex m_Mutex;

	private VoidDelegate m_OnSubmit;

	private VoidDelegate m_OnClick;

	private VoidDelegate m_OnDoubleClick;

	private BoolDelegate m_OnHover;

	private BoolDelegate m_OnPress;

	private BoolDelegate m_OnSelect;

	private FloatDelegate m_OnScroll;

	private VoidDelegate m_OnDragStart;

	private VectorDelegate m_OnDrag;

	private VoidDelegate m_OnDragOver;

	private VoidDelegate m_OnDragOut;

	private VoidDelegate m_OnDragEnd;

	private ObjectDelegate m_OnDrop;

	private KeyCodeDelegate m_OnKey;

	private BoolDelegate m_OnTooltip;

	private bool m_MutexEnabled;

	private int m_InstanceID;

	private const uint DEFAULT_AUTORELEASEMUTEXTIME = 100u;

	public VoidDelegate OnSubmitDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VoidDelegate OnClickDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VoidDelegate OnDoubleClickDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoolDelegate OnHoverDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoolDelegate OnPressDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoolDelegate OnSelectDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FloatDelegate OnScrollDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VoidDelegate OnDragStartDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VectorDelegate OnDragDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VoidDelegate OnDragOverDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VoidDelegate OnDragOutDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public VoidDelegate OnDragEndDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ObjectDelegate OnDropDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public KeyCodeDelegate OnKeyDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoolDelegate OnTooltipDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool IsColliderEnabled => false;

	private void Init()
	{
	}

	private void OnSubmit()
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnSelect(bool selected)
	{
	}

	private void OnScroll(float delta)
	{
	}

	private void OnDragStart()
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnDragOver()
	{
	}

	private void OnDragOut()
	{
	}

	private void OnDragEnd()
	{
	}

	private void OnDrop(GameObject go)
	{
	}

	private void OnKey(KeyCode key)
	{
	}

	private void OnTooltip(bool show)
	{
	}

	private void OnDestroy()
	{
	}

	private void Check(Action action, uint autoReleaseTime = 100u)
	{
	}

	private void ReleaseMutex()
	{
	}

	public static UGCUIEventListener Get(GameObject go, bool mutex = false)
	{
		return null;
	}

	private void _003COnClick_003Eb__74_0()
	{
	}

	private void _003COnDragEnd_003Eb__84_0()
	{
	}
}
