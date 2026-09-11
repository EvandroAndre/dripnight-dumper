using System;
using UnityEngine;

namespace COW;

public class TweenPositionArc : MonoBehaviour
{
	public enum Quadrant
	{
		None,
		First,
		Second,
		Third,
		Fourth
	}

	protected Vector3 mStartPos;

	protected Vector3 mEndPos;

	protected float mF1;

	protected float mF2;

	protected float mTime;

	protected float mSpeed;

	protected int mIndex;

	protected float mDelay;

	protected bool mPlay;

	protected bool mStop;

	private Action<TweenPositionArc> m_EndCall;

	private void Update()
	{
	}

	protected virtual void Play()
	{
	}

	protected void SetFactor()
	{
	}

	protected void SetFactor(Quadrant quadrant)
	{
	}

	protected void SetFactor(float dis)
	{
	}

	protected void SetFactorPerpendicular(float arcRatio)
	{
	}

	public void SetEndCallBack(Action<TweenPositionArc> endCall)
	{
	}

	public void StartAnimation(Vector3 startPos, Vector3 endPos, float speed = 1f, float dis = 0f, Quadrant quadrant = Quadrant.None, bool randomFactor = true, int index = 0, float delay = 0f, bool usePerpendicularVector = false)
	{
	}

	protected virtual void StopAnimation()
	{
	}
}
