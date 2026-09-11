using System;

namespace COW;

public class DelayCallSequencer
{
	private uint m_DelayCallID;

	private int m_CurrentStep;

	private bool m_IsRunning;

	private int m_MaxStep;

	private Func<int, float> m_GetStepDuration;

	private Action<int> m_ExecuteStep;

	public int CurrentStep => 0;

	public bool ReachMaxStep => false;

	public bool IsRunning => false;

	public void Init(int maxStep, Func<int, float> getStepDuration, Action<int> executeStep)
	{
	}

	public bool Start()
	{
		return false;
	}

	public bool Start(int initialStep)
	{
		return false;
	}

	public void Stop()
	{
	}

	private void ExecuteThenScheduleNext()
	{
	}

	private void OnCurrentStepComplete()
	{
	}
}
