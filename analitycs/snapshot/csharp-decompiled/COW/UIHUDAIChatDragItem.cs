using UnityEngine;

namespace COW;

public class UIHUDAIChatDragItem : UIDragDropItem
{
	private Vector2 minBound;

	private Vector2 maxBound;

	private Vector2 bound;

	private float ratio;

	private UIHUDAIChatParentController m_ParentCtrl;

	private IAIChatDraggableItem m_CurrentShowingCtrl;

	private float m_LeftWidth;

	private float m_RightWidth;

	private float m_TopHeight;

	private float m_BottomHeight;

	private bool m_IsEntrance;

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	protected override void OnDragDropEnd()
	{
	}

	public bool IsDragging()
	{
		return false;
	}

	public void InitConfig(Vector2 dragBound, UIHUDAIChatParentController parentCtrl, bool isEntrance = false)
	{
	}

	public void ChangeBound(Vector2 dragBound)
	{
	}

	private void InitScreenBound()
	{
	}

	private void RestrictWithinScreen(Vector2 delta)
	{
	}

	private void ComputeBoundingBoxSize()
	{
	}

	private void AdjustOtherObject(Vector2 delta)
	{
	}

	private bool CheckCurrentShowingItemValid()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropEnd()
	{
	}
}
