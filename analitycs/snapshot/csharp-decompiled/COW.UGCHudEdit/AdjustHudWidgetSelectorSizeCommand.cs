using COW.Gameplay.UGC;
using GCommon.CommandPattern;
using UnityEngine;

namespace COW.UGCHudEdit;

public class AdjustHudWidgetSelectorSizeCommand : RecordCommand
{
	private UIUGCHudWidgetSelectorController m_Selector;

	private UIWidget.Pivot m_PivotType;

	private UGCHudWidget m_BindWidget;

	private int m_InitWidth;

	private int m_InitHeight;

	private Vector3 m_InitPosition;

	private int m_CurrentWidth;

	private int m_CurrentHeight;

	private Vector3 m_CurrentPosition;

	public void Set(UIUGCHudWidgetSelectorController selector, UIWidget.Pivot pivotType)
	{
	}

	public bool CheckCondition(UIWidget.Pivot pointType)
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

	private void GetSign(UIWidget.Pivot pivot, out int signX, out int signY)
	{
		signX = default(int);
		signY = default(int);
	}

	public void _003C_003EiFixBaseProxy_Clear()
	{
	}
}
