using COW.Gameplay.UGC;
using GCommon.CommandPattern;
using UnityEngine;

namespace COW.UGCHudEdit;

public class DragWidgetSelectorCommand : RecordCommand
{
	private UIUGCHudWidgetSelectorController m_Selector;

	private UGCHudWidget m_BindWidget;

	private Vector2 m_StartPosition;

	private Vector2 m_StartAnchorMin;

	private Vector2 m_StartAnchorMax;

	private Vector2 m_EndPosition;

	private Vector2 m_EndAnchorMin;

	private Vector2 m_EndAnchorMax;

	public void Set(UIUGCHudWidgetSelectorController selector)
	{
	}

	public bool CheckCondition()
	{
		return false;
	}

	public override void Record()
	{
	}

	public override void Execute()
	{
	}

	public override void UnExecute()
	{
	}

	public override void Clear()
	{
	}

	public void _003C_003EiFixBaseProxy_Clear()
	{
	}
}
