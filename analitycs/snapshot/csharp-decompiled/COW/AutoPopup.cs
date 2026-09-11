using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class AutoPopup
{
	public enum State
	{
		None,
		Start,
		End
	}

	public enum TaskState
	{
		None,
		WatingData,
		Do,
		WaitingDone
	}

	public class ScheduleTask
	{
		public TaskState state;

		public List<int> waitHttpMessages;

		public HttpRequest currentWaitHttpRequest;

		public AutoPopupTask task;
	}

	private State m_State;

	private List<ScheduleTask> m_ScheduleTasks;

	private static readonly HashSet<Type> m_BlockWhiteList;

	public List<ScheduleTask> ScheduleTasks()
	{
		return null;
	}

	public void StartTask()
	{
	}

	public void StopTask()
	{
	}

	public State NowState()
	{
		return State.None;
	}

	public void AddTask(AutoPopupTask task)
	{
	}

	public void Update()
	{
	}

	public void RemoveTask(ScheduleTask scheduleTask)
	{
	}

	public void Reset()
	{
	}

	public void BlockAllTaskExceptWhiteList(bool preserveFirst = true)
	{
	}

	public bool CheckHasTask(AutoPopupTask task)
	{
		return false;
	}

	public void Clear()
	{
	}
}
