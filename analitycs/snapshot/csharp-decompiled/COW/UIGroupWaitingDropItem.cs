using System;
using UnityEngine;

namespace COW;

public class UIGroupWaitingDropItem : UIDragDropItem
{
	private Vector2 minBound;

	private Vector2 maxBound;

	private Vector2 bound;

	private float m_centerOffsetX;

	private float m_centerOffsetY;

	private float ratio;

	public Action DropEndAction;

	public void InitBound(Vector2 dragBound, float centerOffsetX = 0f, float centerOffsetY = 0f)
	{
	}

	public void ChangeBound(Vector2 dragBound, float centerOffsetX = 0f, float centerOffsetY = 0f)
	{
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	protected override void OnDragDropEnd()
	{
	}

	public bool IsNearTopBound()
	{
		return false;
	}

	public bool IsDragging()
	{
		return false;
	}

	private void InitScreenBound()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropEnd()
	{
	}
}
