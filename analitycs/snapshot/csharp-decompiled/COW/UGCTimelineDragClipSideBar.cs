using System;
using UnityEngine;

namespace COW;

public class UGCTimelineDragClipSideBar : MonoBehaviour
{
	public enum SiderBarDire
	{
		Left,
		Right
	}

	public SiderBarDire siderBarDire;

	public UIWidget otherSiderBar;

	public Action draggingAction;

	public Action<bool> pressAction;

	public Vector3 scrollMomentum;

	public bool restrictWithinBounds;

	public float momentumAmount;

	public float minDragRange;

	protected Vector3 scale;

	public UIRect contentRect;

	protected Vector3 mTargetPos;

	protected Vector3 mMomentum;

	protected Vector3 mScroll;

	protected bool mPressed;

	protected Bounds mBounds;

	protected float spriteWidth;

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

	public float sidePosX => 0f;

	private void OnEnable()
	{
	}

	private void UpdateBounds()
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

	private void OnPress(bool isPressed)
	{
	}

	protected Vector3 ConstrainToBounds(Vector3 pos)
	{
		return default(Vector3);
	}
}
