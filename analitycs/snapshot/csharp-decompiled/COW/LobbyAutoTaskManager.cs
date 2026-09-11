using System.Collections.Generic;
using GCommon;

namespace COW;

public class LobbyAutoTaskManager : SingletonModule<LobbyAutoTaskManager>
{
	private AutoPopup m_LobbyAutoPopups;

	public List<AutoPopup.ScheduleTask> ScheduleTasks()
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void Clear()
	{
	}

	public void BlockAllTaskExceptWhiteList(bool preserveFirst = true)
	{
	}

	public void AddTask(AutoPopupTask task)
	{
	}

	public void StartTask()
	{
	}

	public void StopTask()
	{
	}

	public void Update()
	{
	}

	public bool CheckHasTask(AutoPopupTask task)
	{
		return false;
	}
}
