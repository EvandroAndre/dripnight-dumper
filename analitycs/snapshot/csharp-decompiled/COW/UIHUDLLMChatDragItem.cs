using UnityEngine;

namespace COW;

public class UIHUDLLMChatDragItem : UIDragDropItem
{
	private Vector2 minBound;

	private Vector2 maxBound;

	private Vector2 bound;

	private UIHudUGC_LLMChatController m_ParentCtrl;

	private IAIChatDraggableItem m_CurrentShowingCtrl;

	private float m_LeftWidth;

	private float m_RightWidth;

	private float m_TopHeight;

	private float m_BottomHeight;

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

	public void InitConfig(Vector2 dragBound, UIHudUGC_LLMChatController parentCtrl)
	{
	}

	public void ChangeBound(Vector2 dragBound)
	{
	}

	private void InitScreenBound()
	{
	}

	public void RestrictWithinScreen(Vector2 delta)
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
