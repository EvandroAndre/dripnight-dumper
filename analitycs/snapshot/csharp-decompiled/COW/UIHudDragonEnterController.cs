using GCommon;

namespace COW;

public class UIHudDragonEnterController : UIBaseController
{
	private UIHudDragonEnterView m_View;

	private UILabel m_TimeLabel;

	private bool m_HasSendStillChallengeMsg;

	private bool m_CanSkipChallenge;

	private int m_CurTxtNum;

	private float m_CloseTime;

	private UIQuickMatchController m_QuickMatchController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnMatchMakingHide()
	{
	}

	private void OnMatchMakingShow()
	{
	}

	private void OnDragonSkip()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetViewData(bool canSkip)
	{
	}

	private void OnBtnStillDragonTaskClick()
	{
	}

	public void ShowPrepareEnterDragonTask(uint duration, bool canSkipTask)
	{
	}

	private void FixedUpdate()
	{
	}

	private void ShowResult()
	{
	}

	private void HideDragonTask()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
