using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudLabel : UGCHudWidget
{
	public enum LabelVerticalAlignmentEnum
	{
		Automatic,
		Top,
		Middle,
		Bottom
	}

	public enum LabelOverflowEnum
	{
		Shrink = 0,
		Clamp = 1,
		ResizeFreely = 2,
		Ellipsis = 99
	}

	protected UILabel m_Label;

	private bool m_IsItalic;

	private bool m_IsBold;

	private BoxCollider m_BoxCollider;

	public BoxCollider BoxCollider => null;

	public UILabel Label => null;

	public bool IsItalic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsUnderline
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

	private void SetBoldAndItalic()
	{
	}

	public override void OnInternalInit()
	{
	}

	protected override void OnInternalDestroy()
	{
	}

	public override void RefreshSprite()
	{
	}

	public int GetUGCOverflowData()
	{
		return 0;
	}

	public void SetUGCOverflowData(int overflow)
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public new void _003C_003EiFixBaseProxy_OnInternalInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInternalDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshSprite()
	{
	}
}
