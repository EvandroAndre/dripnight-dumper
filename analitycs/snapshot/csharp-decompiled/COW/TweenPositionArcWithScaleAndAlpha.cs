using System;
using UnityEngine;

namespace COW;

public class TweenPositionArcWithScaleAndAlpha : TweenPositionArc
{
	protected float m_StartAlpha;

	protected float m_EndAlpha;

	protected Vector3 m_StartLocalScale;

	protected Vector3 m_EndLocalScale;

	protected bool m_CanChangeAlpha;

	protected UIWidget m_Widget;

	private Action<TweenPositionArcWithScaleAndAlpha> m_StopCall;

	protected override void Play()
	{
	}

	public void StartAnimation(Vector3 startPos, Vector3 endPos, float startAlpha, float endAlpha, Vector3 startLocalScale, Vector3 endLocalScale, float speed = 1f, float dis = 0f, Quadrant quadrant = Quadrant.None, bool randomFactor = true, int index = 0, float delay = 0f, UIWidget widget = null)
	{
	}

	protected override void StopAnimation()
	{
	}

	public void SetEndCallBack(Action<TweenPositionArcWithScaleAndAlpha> endCall)
	{
	}

	public void _003C_003EiFixBaseProxy_Play()
	{
	}

	public void _003C_003EiFixBaseProxy_StopAnimation()
	{
	}
}
