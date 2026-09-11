using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudButton : UGCHudWidget
{
	protected UIButton m_Button;

	public UISprite m_Sprite;

	protected BoxCollider m_Col;

	private bool m_IsFEButton;

	private Color m_NormalColor;

	private Color m_DisableColor;

	private Color m_PressedColor;

	private float m_Alpha;

	public UIButton Button => null;

	public UISprite Image => null;

	public BoxCollider Col => null;

	public bool IsFEButton
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color NormalColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color DisableColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color PressedColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float Alpha
	{
		get
		{
			return 0f;
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

	public override void AddDragScrollView(UIScrollView scrollView)
	{
	}

	public void RefreshButton()
	{
	}

	public override void RefreshSprite()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_OnInternalEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_AddDragScrollView(UIScrollView P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshSprite()
	{
	}
}
