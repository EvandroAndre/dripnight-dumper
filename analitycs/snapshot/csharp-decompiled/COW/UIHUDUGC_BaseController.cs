using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;
using message;

namespace COW;

public abstract class UIHUDUGC_BaseController : IUIHUDBaseController
{
	protected UGCEntityRepItem m_UGCEntityRepItem;

	protected UGCHudWidgetRepItem m_BaseWidgetCmpt;

	public UGCUIBehaviour m_Rect;

	protected string m_EntityID;

	protected string m_HudEntityId;

	protected UIHUDUGC_CustomHudController m_HudController;

	public string m_ParentEntityId;

	protected Vector3 m_InitLocalPosition;

	protected bool m_IsInitCheck;

	protected UGCHudWidgetType m_WidgetType;

	public int Index;

	public List<UIHUDUGC_BaseController> Children;

	public int m_WidgetId;

	public bool NeedRefreshSizeAndPosition;

	private int m_Priority;

	private UGCUIBehaviour m_ObservedRect;

	private Action<UIHUDUGC_BaseController> m_Changed;

	private Action<UIHUDUGC_BaseController> m_Destroyed;

	private Action<UIHUDUGC_BaseController> m_ChildAdded;

	private Action<UIHUDUGC_BaseController> m_ChildRemoved;

	protected bool m_IsClientEntity;

	public int Priority
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected UIHUDUGC_CustomHudController HudController => null;

	public string HostHudEntityID => null;

	public int WidgetID => 0;

	public string EntityID => null;

	public UGCUIBehaviour Rect => null;

	public UGCHudWidgetType WidgetType => UGCHudWidgetType.Empty;

	public bool LogicActive => false;

	public event Action<UIHUDUGC_BaseController> Changed
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UIHUDUGC_BaseController> Destroyed
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UIHUDUGC_BaseController> ChildAdded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UIHUDUGC_BaseController> ChildRemoved
	{
		add
		{
		}
		remove
		{
		}
	}

	protected virtual void InitEntityData()
	{
	}

	public virtual void SetEntityID(string entityID)
	{
	}

	public bool IsClientWidget()
	{
		return false;
	}

	public void SetEntityType(MHJLOKOOGNB entityType)
	{
	}

	protected abstract void OnDestroy();

	public virtual void DestroyEntity()
	{
	}

	protected virtual void OnChildIndexChangeEvent(int cur)
	{
	}

	protected virtual void OnPriorityChangeEvent(int cur)
	{
	}

	protected virtual void OnParentEntityIDChanged(string cur)
	{
	}

	protected virtual void OnHostHudEntityChanged(string cur)
	{
	}

	protected virtual void OnFileIDChanged(int cur)
	{
	}

	protected abstract Vector3 GetRectLocalPosition();

	protected virtual void InitWidget()
	{
	}

	protected virtual void RefreshWidgetInfo()
	{
	}

	public static UIHUDUGC_BaseController Rebuild(MHJLOKOOGNB entityType, string entityID)
	{
		return null;
	}

	protected virtual void OnActiveSelfChanged(bool value)
	{
	}

	protected virtual void OnAnchorPositionChanged(Vector3 cur)
	{
	}

	protected virtual void OnAnchorMinChanged(Vector2 cur)
	{
	}

	protected virtual void OnAnchorMaxChanged(Vector2 cur)
	{
	}

	protected virtual void OnPivotChanged(Vector2 cur)
	{
	}

	protected virtual void OnSizeDeltaChanged(Vector2 cur)
	{
	}

	protected virtual void OnAngleChanged(float cur)
	{
	}

	protected string GetUniqueID()
	{
		return null;
	}

	public virtual void RefreshAlpha()
	{
	}

	public virtual void SetRootParent()
	{
	}

	public void AddChild(UIHUDUGC_BaseController child)
	{
	}

	public void RemoveChild(UIHUDUGC_BaseController child)
	{
	}

	public void GetDirectWidgets(List<UIWidget> widgets)
	{
	}

	public virtual void SetParentHasChanged()
	{
	}

	protected void NotifyChanged()
	{
	}

	protected void NotifyDestroyed()
	{
	}

	private void RegisterObservedRectCallbacks()
	{
	}

	private void UnregisterObservedRectCallbacks()
	{
	}
}
