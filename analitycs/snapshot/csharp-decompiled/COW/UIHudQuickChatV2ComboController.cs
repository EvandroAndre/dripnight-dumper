using GCommon;

namespace COW;

internal class UIHudQuickChatV2ComboController : UIBaseController
{
	public enum EQuickChatV2State
	{
		AutoQuickChatV2 = 1,
		ResponseChat = 2,
		ThumbUp = 3,
		None = 99
	}

	private EQuickChatV2State m_QuickChatV2State;

	private UIHudQuickChatV2ComboView m_View;

	private UIHudAutoQuickChatV2Controller m_AutoQuickChatV2Ctrl;

	private UIHudThumbUpChatBtnController m_ThumbUpCtrl;

	private UIHudResponseChatBtnController m_ResponseChatCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	private void InitAutoQuickChatV2Ctrl()
	{
	}

	private bool EnsureAutoQuickChatV2Ctrl()
	{
		return false;
	}

	private void InitResponseChatCtrl()
	{
	}

	private void InitThumbUpCtrl()
	{
	}

	public bool RequestShowQuickChatV2(uint configId)
	{
		return false;
	}

	private void OnQuickChatV2Trigger(object[] data)
	{
	}

	public bool RequestChangeHudChatVisibility(EQuickChatV2State state, bool show)
	{
		return false;
	}

	private void TryUpdateQuickChatV2State(EQuickChatV2State state)
	{
	}

	private void ApplyContainerVisibility(EQuickChatV2State state)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
