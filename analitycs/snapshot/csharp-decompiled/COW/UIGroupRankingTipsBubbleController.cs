using GCommon;

namespace COW;

public class UIGroupRankingTipsBubbleController : UIRankingTipsBaseController
{
	private UIGroupRankingTipsBubbleView m_View;

	private UIModelChat m_ModelChat;

	private UIModelGroup m_ModelGroup;

	private ulong lastSendTime;

	private const int CoolDownTime = 5;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitCommonReference()
	{
	}

	private void ChangeState(bool isHide)
	{
	}

	public void OnSendBtnClick()
	{
	}

	public bool IsGuest()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
