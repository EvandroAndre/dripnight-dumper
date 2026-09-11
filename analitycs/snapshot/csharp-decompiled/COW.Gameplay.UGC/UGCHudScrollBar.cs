using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudScrollBar : MonoBehaviour
{
	public UIPanel m_Panel;

	public UIScrollBar m_ScrollBar;

	public UIWidget m_Widget;

	private UIWidget m_Foreground;

	private UIWidget m_Background;

	private int m_Layer;

	public UIPanel Panel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIScrollBar ScrollBar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIWidget Widget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIWidget Foreground
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIWidget Background
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetDepth(int depth)
	{
	}

	public void SetLayer(int layer)
	{
	}
}
