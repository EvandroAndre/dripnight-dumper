namespace COW;

public class TaskAuto : BaseTask
{
	public UIProgressBar progressBar;

	public UICustomHoverButton button;

	public bool needPress;

	public float completeTime;

	private bool m_IsRun;

	private float m_CurTime;

	private bool m_IsTaskFinished;

	private void Awake()
	{
	}

	public override void OnStart()
	{
	}

	private void OnClick()
	{
	}

	private void OnPress(bool isPress)
	{
	}

	protected void Update()
	{
	}

	protected virtual void OnProgressUpdate(float progress)
	{
	}

	public override void Pause()
	{
	}

	public override void OnSuccess()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_Pause()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSuccess()
	{
	}
}
