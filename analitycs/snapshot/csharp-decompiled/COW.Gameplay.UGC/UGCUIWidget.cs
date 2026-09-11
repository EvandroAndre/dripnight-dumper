using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public abstract class UGCUIWidget : UGCUIBehaviour
{
	public enum AnchorType
	{
		TopLeft,
		Top,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<UGCUIBehaviour, bool> _003C_003E9__80_0;

		public static Func<UGCUIBehaviour, bool> _003C_003E9__82_0;

		internal bool _003CMarkSizeChanged_003Eb__80_0(UGCUIBehaviour child)
		{
			return false;
		}

		internal bool _003CMarkPositionChanged_003Eb__82_0(UGCUIBehaviour child)
		{
			return false;
		}
	}

	protected Vector2 m_AnchorMin;

	protected Vector2 m_AnchorMax;

	protected Vector2 m_SizeDelta;

	protected static readonly Vector2 Vec2Half;

	protected static readonly Vector2 Vec2One;

	protected AnchorType m_Anchor;

	protected Vector2 m_AnchorOffset;

	protected Vector2 m_AnchorPosition;

	protected UIWidget m_Widget;

	private Vector2 m_Pivot;

	protected int m_Width;

	protected int m_Height;

	public Action beforeAnchorChanged;

	public Action beforeSizeChanged;

	public Action beforePositionChanged;

	public Action beforeRotationChanged;

	private bool m_IsDirty;

	public bool IsDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UIWidget Widget => null;

	public Vector2 AnchorMin
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 AnchorMax
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 SizeDelta
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector3 Position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 LocalPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public int Depth => 0;

	public Vector2 Size
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 Pivot
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector3 WorldCenter => default(Vector3);

	public Rect Rect => default(Rect);

	public AnchorType Anchor
	{
		get
		{
			return AnchorType.TopLeft;
		}
		set
		{
		}
	}

	public Vector2 AnchorPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Quaternion Rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public override Vector2 GetParentSize()
	{
		return default(Vector2);
	}

	public Vector2 GetParentPivot()
	{
		return default(Vector2);
	}

	public Vector2 GetAnchorPosition(Vector2 pivot)
	{
		return default(Vector2);
	}

	public void SetAnchorPosition(Vector2 pivot, Vector2 newAnchorPosition)
	{
	}

	public Vector3 GetLocalPostion(Vector2 pivot, Vector2 newAnchorPosition)
	{
		return default(Vector3);
	}

	public override void UpdateUGCUISizeByAnchorBox()
	{
	}

	public override void UpdateUGCUIAnchors()
	{
	}

	public virtual void MarkAnchorChanged()
	{
	}

	public virtual void MarkNameChanged()
	{
	}

	public virtual void MarkRotationChanged()
	{
	}

	private void AdaptSizeChanged(Vector2 lastSize)
	{
	}

	public override void CalculateSizeDelta()
	{
	}

	public virtual void MarkSizeChanged()
	{
	}

	private void AdaptPositionChanged(Vector3 newLocalPosition)
	{
	}

	public virtual void MarkPositionChanged()
	{
	}

	public override void OnInternalInit()
	{
	}

	protected override void OnInternalDestroy()
	{
	}

	protected override void OnParentChanged(Transform parent)
	{
	}

	protected void ForEachChildren(Func<UGCUIBehaviour, bool> callback)
	{
	}

	public override void SetParent(Transform parent, bool worldPositionStays = true)
	{
	}

	public override void SetParentHasChanged()
	{
	}

	public virtual UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public virtual void RefreshGrid()
	{
	}

	public virtual void RefreshSprite()
	{
	}

	public override Vector3 GetActualPosition(UIHUDUGC_CustomHudController hud)
	{
		return default(Vector3);
	}

	public override bool SetActualPosition(UIHUDUGC_CustomHudController hud, Vector3 ap)
	{
		return false;
	}

	public override void GetAnchorPositionByActualPosition(UIHUDUGC_CustomHudController hud, Vector3 s, Vector3 d, ref Vector3 src, ref Vector3 dst)
	{
	}

	public Vector2 CalculateAnchorPosition(Transform root, Transform parent, Vector3 actualPosition)
	{
		return default(Vector2);
	}

	public override Vector2 GetSizeDeltaBySize(Vector2 size)
	{
		return default(Vector2);
	}

	public void _003C_003EiFixBaseProxy_OnInternalInit()
	{
	}

	public Vector2 _003C_003EiFixBaseProxy_GetParentSize()
	{
		return default(Vector2);
	}

	public void _003C_003EiFixBaseProxy_UpdateUGCUISizeByAnchorBox()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateUGCUIAnchors()
	{
	}

	public void _003C_003EiFixBaseProxy_CalculateSizeDelta()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInternalDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnParentChanged(Transform P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetParent(Transform P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetParentHasChanged()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_GetActualPosition(UIHUDUGC_CustomHudController P0)
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_SetActualPosition(UIHUDUGC_CustomHudController P0, Vector3 P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_GetAnchorPositionByActualPosition(UIHUDUGC_CustomHudController P0, Vector3 P1, Vector3 P2, ref Vector3 P3, ref Vector3 P4)
	{
	}

	public Vector2 _003C_003EiFixBaseProxy_GetSizeDeltaBySize(Vector2 P0)
	{
		return default(Vector2);
	}
}
