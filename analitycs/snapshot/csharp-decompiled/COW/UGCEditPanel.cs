using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using Lean.Touch;
using UnityEngine;

namespace COW;

public class UGCEditPanel : UGCUIWidget
{
	public bool dragRestrict;

	public Action onClick;

	public Action<Vector2, Vector2> onDrag;

	public Action<float, float> onPinchAndSpread;

	private float m_InitScale;

	private float m_MinZoomRatio;

	private float m_MaxZoomRatio;

	private float m_DragRestrictRatioX;

	private float m_DragRestrictRatioY;

	public float CurrentScale => 0f;

	public override void OnInternalInit()
	{
	}

	protected override void OnInternalEnable()
	{
	}

	protected override void OnInternalDisable()
	{
	}

	private void OnClick()
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnGesture(List<LeanFinger> fingers)
	{
	}

	public void SetZoomLimit(float minRatio, float maxRatio)
	{
	}

	public void DragSelf(Vector2 currentScreenPosition, Vector2 delta)
	{
	}

	public float Zoom(float delta)
	{
		return 0f;
	}

	public new void _003C_003EiFixBaseProxy_OnInternalInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInternalEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInternalDisable()
	{
	}
}
