using System.Text;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudScrollView : UGCUIPanel
{
	public UIScrollView m_ScrollView;

	public UGCHudScrollBar m_ScrollBarH;

	public UGCHudScrollBar m_ScrollBarV;

	public GameObject m_SVCollider;

	public UIPanel m_SVPanel;

	private int m_ContentOrigin;

	private int m_VerticalBar;

	private int m_HorizontalBar;

	private Vector2 m_CustomXY;

	private Vector2 m_ShowPosition;

	public bool m_Drag;

	private bool m_NeedRefreshPosition;

	private static readonly StringBuilder m_LogSb;

	public UIScrollView ScrollView => null;

	public UGCHudScrollBar ScrollBarH => null;

	public UGCHudScrollBar ScrollBarV => null;

	public GameObject SVCollider => null;

	public UIPanel SVPanel => null;

	public int ContentOrigin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int VerticalBar
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int HorizontalBar
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector2 CustomXY
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 ShowPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public override void SetSVClipType()
	{
	}

	public float GetVerticalScrollAmount()
	{
		return 0f;
	}

	public float GetHorizontalScrollAmount()
	{
		return 0f;
	}

	public void SetVerticalScrollAmount(float value)
	{
	}

	public void SetHorizontalScrollAmount(float value)
	{
	}

	public void RefreshPosition()
	{
	}

	public void MarkNeedRefreshPosition()
	{
	}

	private void LateUpdate()
	{
	}

	protected override void OnInternalEnable()
	{
	}

	public void NoDragRefreshPosition()
	{
	}

	public void AddDragScrollViewInChildren()
	{
	}

	public override void SetLayer(int layer)
	{
	}

	public override Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_SetSVClipType()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInternalEnable()
	{
	}

	public new void _003C_003EiFixBaseProxy_SetLayer(int P0)
	{
	}

	public new Vector2Int _003C_003EiFixBaseProxy_SetDepth(Vector2Int P0, int P1)
	{
		return default(Vector2Int);
	}
}
