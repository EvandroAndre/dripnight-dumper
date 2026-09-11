using System;

namespace GCommon;

public class LoadingProcessManager
{
	private LoadingProcess[] m_Processes;

	private int m_LastMainProcessIndex;

	private Action<bool, int> m_FinshedHandler;

	public void Start(LoadingProcess[] processes, Action<bool, int> finishedHandler)
	{
	}

	public void Update()
	{
	}

	private void StartNextProcess()
	{
	}

	private void DispachFinishedEvent(bool result, int exceptionProcessIndex = -1)
	{
	}

	private bool HasProcesses()
	{
		return false;
	}
}
