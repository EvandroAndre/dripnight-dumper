using System;
using System.Collections.Generic;

namespace GCommon;

public class DelayCallTimer
{
	protected Dictionary<uint, TimerAction> m_TimerActions;

	protected List<uint> m_ExpiredTimerActions;

	protected Dictionary<uint, Action> m_TimerActionsToBeCalled;

	public void UpdateTimer(float gameTime)
	{
	}

	public uint DelayCall(uint delayCallID, float currentTime, float delayTime, Action action, bool isRepeated = false)
	{
		return 0u;
	}

	public void Clear()
	{
	}

	public void ClearAllNoneRepeatedDelayCalls()
	{
	}

	public bool ExistDelayCall(uint id)
	{
		return false;
	}

	public void CancelDelayCall(uint id)
	{
	}

	public void ChangeDelayCallTime(uint id, float deltaTime)
	{
	}

	public void MoveFrontDelayCall(uint id)
	{
	}
}
