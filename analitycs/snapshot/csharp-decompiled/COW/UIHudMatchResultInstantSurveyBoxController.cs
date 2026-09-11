using GCommon;

namespace COW;

public class UIHudMatchResultInstantSurveyBoxController : UIPopupWindowController
{
	private UIHudMatchResultInstantSurveyBoxView m_View;

	private UIHudMatchResultInstantSurveyController m_ContentCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public bool SetData(EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode)
	{
		return false;
	}

	public void OnTipsBoxClose()
	{
	}

	private bool EnsureContent()
	{
		return false;
	}

	private void ResetContentDepth()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
