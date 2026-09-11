using System;
using UnityEngine;

namespace COW;

public class CenterFocusCarouselHelper : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public Action onComplete;

		internal void _003CTween_003Eb__0()
		{
		}
	}

	public Transform leftItem;

	public Transform centerItem;

	public Transform rightItem;

	public UIButton leftButton;

	public UIButton centerButton;

	public UIButton rightButton;

	private Vector3 m_LeftPos;

	private Vector3 m_CenterPos;

	private Vector3 m_RightPos;

	public int FirstDepth;

	public int SecondDepth;

	public int ThirdDepth;

	public float smallScale;

	public float bigScale;

	public float animDuration;

	private bool m_IsAnimating;

	private Action m_CenterClickAction;

	private Action m_CompleteAction;

	private void Start()
	{
	}

	private void InitState()
	{
	}

	private void OnClickCenter()
	{
	}

	public void SetCenterClickAction(Action action)
	{
	}

	public void SetCompleteAction(Action action)
	{
	}

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	private void Tween(Transform item, Vector3 targetPos, float targetScale, Action onComplete = null)
	{
	}

	private void SetDepth(Transform item, int depth)
	{
	}

	private void _003COnClickLeft_003Eb__23_0()
	{
	}

	private void _003COnClickRight_003Eb__24_0()
	{
	}
}
