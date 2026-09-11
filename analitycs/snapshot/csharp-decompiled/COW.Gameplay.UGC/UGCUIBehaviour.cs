using System;
using UnityEngine;
using UnityEngine.Events;

namespace COW.Gameplay.UGC;

public class UGCUIBehaviour : MonoBehaviour
{
	protected uint m_FileID;

	protected uint m_Hierarchy;

	public UnityAction onHierarchyChanged;

	public UnityAction<Transform> onParentChanged;

	public Action onAnchorChanged;

	public Action onActiveChanged;

	public Action onNameChanged;

	public Action onSizeChanged;

	public Action onPositionChanged;

	public Action onRotationChanged;

	protected UGCUIType m_Type;

	private string m_EntityID;

	private int m_Index;

	private bool m_IsClientEntity;

	private int m_Priority;

	protected int m_Layer;

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

	public uint UniqueFileID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint Hierarchy
	{
		get
		{
			return 0u;
		}
		protected set
		{
		}
	}

	public UGCUIType UGCUIType => UGCUIType.Panel;

	public string EntityID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsClientEntity
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void DestroyUI()
	{
	}

	public virtual void SetParent(Transform parent, bool worldPositionStays = true)
	{
	}

	protected virtual void OnHierarchyDirty()
	{
	}

	public virtual void OnInternalInit()
	{
	}

	protected virtual void OnInternalDestroy()
	{
	}

	protected virtual void OnInternalEnable()
	{
	}

	protected virtual void OnInternalDisable()
	{
	}

	protected virtual void OnParentChanged(Transform parent)
	{
	}

	public virtual void UpdateUGCUISizeByAnchorBox()
	{
	}

	public virtual void UpdateUGCUIAnchors()
	{
	}

	public virtual void CalculateSizeDelta()
	{
	}

	public virtual void RemoveDragScrollView()
	{
	}

	public virtual void AddDragScrollView(UIScrollView scrollView)
	{
	}

	public virtual Vector2 GetParentSize()
	{
		return default(Vector2);
	}

	public virtual void SetParentHasChanged()
	{
	}

	public virtual void SetLayer(int layer)
	{
	}

	public virtual Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public virtual Vector3 GetActualPosition(UIHUDUGC_CustomHudController hud)
	{
		return default(Vector3);
	}

	public virtual bool SetActualPosition(UIHUDUGC_CustomHudController hud, Vector3 ap)
	{
		return false;
	}

	public virtual void GetAnchorPositionByActualPosition(UIHUDUGC_CustomHudController hud, Vector3 s, Vector3 d, ref Vector3 src, ref Vector3 dst)
	{
	}

	public virtual Vector2 GetSizeDeltaBySize(Vector2 size)
	{
		return default(Vector2);
	}
}
