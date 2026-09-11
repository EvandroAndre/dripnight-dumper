using System;
using System.Collections.Generic;

namespace GCommon;

public class TimerAction : Timer, IObjectPoolCallback
{
	private Action m_Action;

	private bool m_IsRepeated;

	private float m_Duration;

	private bool m_IsInPool;

	public void SetActionAt(float gameTime, float expiredTime, Action action, bool isRepeated)
	{
	}

	public void ChangeExpireTime(float deltaExpiredTime)
	{
	}

	public void MoveFront()
	{
	}

	public bool IsRepeated()
	{
		return false;
	}

	public bool Update(float gameTime, uint actionId, Dictionary<uint, Action> timerActionsToBeCalled)
	{
		return false;
	}

	public void OnAllocated()
	{
	}

	public void OnCollected()
	{
	}

	public bool IsInPool()
	{
		return false;
	}
}
