namespace GCommon;

public class LoadingProcess
{
	public enum EProcessStatus
	{
		NotStarted,
		Running,
		Finished,
		Exception
	}

	private EProcessStatus m_Status;

	public void StartProcess()
	{
	}

	public void UpdateProcess()
	{
	}

	public void CleanProcess()
	{
	}

	public virtual bool IsMainProcess()
	{
		return false;
	}

	public bool IsFinished()
	{
		return false;
	}

	public bool HasException()
	{
		return false;
	}

	protected virtual void OnStartProcess()
	{
	}

	protected virtual EProcessStatus OnUpdateProcess()
	{
		return EProcessStatus.NotStarted;
	}

	protected virtual void OnCleanProcess()
	{
	}
}
