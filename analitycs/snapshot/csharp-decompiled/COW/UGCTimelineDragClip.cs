using System;
using UnityEngine;

namespace COW;

public class UGCTimelineDragClip : MonoBehaviour
{
	public Transform target;

	public Vector3 scrollMomentum;

	public bool restrictWithinBounds;

	public float momentumAmount;

	protected Vector3 scale;

	public UIRect contentRect;

	protected Vector3 mTargetPos;

	protected Vector3 mMomentum;

	protected Vector3 mScroll;

	protected bool mPressed;

	protected Bounds mBounds;

	public UIWidget widget;

	public Action draggingAction;

	public bool isKeyFrame;

	public Vector3 dragMovement
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void UpdateBounds()
	{
	}

	public void SetLongPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	public void Move(Vector3 localDelta)
	{
	}

	private void LateUpdate()
	{
	}

	public void CancelMovement()
	{
	}

	private void OnScroll(float delta)
	{
	}

	protected virtual Vector3 ConstrainToBounds(Vector3 pos)
	{
		return default(Vector3);
	}
}
