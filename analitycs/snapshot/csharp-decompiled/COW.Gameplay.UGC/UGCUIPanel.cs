using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCUIPanel : UGCUIBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<UGCUIBehaviour, bool> _003C_003E9__87_0;

		public static Func<UGCUIBehaviour, bool> _003C_003E9__88_0;

		internal bool _003CMarkSizeChanged_003Eb__87_0(UGCUIBehaviour child)
		{
			return false;
		}

		internal bool _003CMarkPositionChanged_003Eb__88_0(UGCUIBehaviour child)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public UGCUIPanel _003C_003E4__this;

		public string value;

		internal void _003Cset_MaskName_003Eb__0(bool succ, bool isReloaded, Texture2D tex)
		{
		}
	}

	protected UIPanel m_Panel;

	public UISprite m_Bg;

	protected bool m_BgFill;

	protected float m_BgAlpha;

	protected Color m_BgColor;

	protected Vector2 m_BgSizeDelta;

	protected string m_MaskName;

	protected Vector2 m_Softness;

	protected UIDrawCall.Clipping m_ClipType;

	protected static readonly Vector2 Vec2Half;

	protected static readonly Vector2 Vec2One;

	private int m_Width;

	private int m_Height;

	private Vector2 m_AnchorPosition;

	private Vector2 m_AnchorMin;

	private Vector2 m_AnchorMax;

	private Vector2 m_SizeDelta;

	private Vector2 m_Pivot;

	public Action beforeAnchorChanged;

	public Action beforeSizeChanged;

	public Action beforePositionChanged;

	public Action beforeRotationChanged;

	public UIPanel Panel => null;

	public UISprite Bg => null;

	public Vector2 BgSizeDelta
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public bool BgFill
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float BgAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Color BgColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public string BgName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int ClippingType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string MaskName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector2 Softness
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 Size => default(Vector2);

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

	public float LocalEulerAngleZ
	{
		get
		{
			return 0f;
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

	public virtual UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	protected override void OnInternalEnable()
	{
	}

	public virtual void MarkSizeChanged()
	{
	}

	public virtual void MarkPositionChanged()
	{
	}

	public virtual void MarkRotationChanged()
	{
	}

	protected void ForEachChildren(Func<UGCUIBehaviour, bool> callback)
	{
	}

	public override void OnInternalInit()
	{
	}

	protected override void OnInternalDestroy()
	{
	}

	public override Vector2 GetParentSize()
	{
		return default(Vector2);
	}

	public Vector2 GetParentPivot()
	{
		return default(Vector2);
	}

	public Vector3 GetLocalPostion(Vector2 pivot, Vector2 newAnchorPosition)
	{
		return default(Vector3);
	}

	public override void UpdateUGCUISizeByAnchorBox()
	{
	}

	public Vector2 GetAnchorPosition(Vector2 pivot)
	{
		return default(Vector2);
	}

	public void SetAnchorPosition(Vector2 pivot, Vector2 newAnchorPosition)
	{
	}

	public override void UpdateUGCUIAnchors()
	{
	}

	public override void CalculateSizeDelta()
	{
	}

	public virtual void MarkAnchorChanged()
	{
	}

	public virtual void MarkNameChanged()
	{
	}

	private void AdaptPositionChanged(Vector3 newLocalPosition)
	{
	}

	protected override void OnParentChanged(Transform parent)
	{
	}

	public virtual void RefreshGrid()
	{
	}

	public virtual void SetSVClipType()
	{
	}

	public override void SetParentHasChanged()
	{
	}

	public override void SetParent(Transform parent, bool worldPositionStays = true)
	{
	}

	public override void SetLayer(int layer)
	{
	}

	public override Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
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

	public void _003C_003EiFixBaseProxy_OnInternalEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInternalInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInternalDestroy()
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

	public void _003C_003EiFixBaseProxy_OnParentChanged(Transform P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetParentHasChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetParent(Transform P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetLayer(int P0)
	{
	}

	public Vector2Int _003C_003EiFixBaseProxy_SetDepth(Vector2Int P0, int P1)
	{
		return default(Vector2Int);
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
