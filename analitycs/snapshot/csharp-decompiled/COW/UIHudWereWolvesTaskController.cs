using GCommon;

namespace COW;

public class UIHudWereWolvesTaskController : UIBaseController
{
	private UIHudWereWolvesTaskView m_View;

	private uint _uniqueId;

	private BaseTask m_task;

	private bool m_IsTaskSuccessDelayClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnNoTask(object[] data)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnTaskComplete()
	{
	}

	private void OnTaskCompletePost()
	{
	}

	private void OnBtnTaskClick(object[] data)
	{
	}

	private void CreateTask()
	{
	}

	public void SetData(uint uniqueId)
	{
	}

	public void CloseTask()
	{
	}

	public void SuccessDelayCloseTask()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
