namespace COW;

public class TaskHeat : BaseTask
{
	public UIProgressBar progressBar;

	public UIProgressBar targetBarLeft;

	public UIProgressBar targetBarRight;

	public UICustomHoverButton pressButton;

	public bool clickStop;

	public bool pingpong;

	public float leftRange;

	public float targetRange;

	public float completeTime;

	private float m_CurTime;

	private float m_TargetValue;

	private bool m_IsRun;

	private int m_Dir;

	private void Awake()
	{
	}

	public override void OnStart()
	{
	}

	private void OnPress(bool isPress)
	{
	}

	private void OnClick()
	{
	}

	private void CheckComplete()
	{
	}

	public override void OnFailure()
	{
	}

	public override void Resume()
	{
	}

	public override void Pause()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFailure()
	{
	}

	public void _003C_003EiFixBaseProxy_Resume()
	{
	}

	public void _003C_003EiFixBaseProxy_Pause()
	{
	}
}
