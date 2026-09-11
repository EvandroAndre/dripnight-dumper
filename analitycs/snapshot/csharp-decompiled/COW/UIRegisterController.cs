using GCommon;

namespace COW;

public class UIRegisterController : UIBaseController, IUIModelDataChangeObserver
{
	public enum RegisterState
	{
		None,
		NewbieVerteranCheck,
		Name,
		Finish
	}

	private UIRegisterView m_View;

	private RegisterState m_RegisterState;

	private string m_RegisterName;

	private uint m_RegisterAvatarID;

	private UICreateCharacterController m_CtrlCreateName;

	private UICheckIsNewbieOrVeteranController m_CtrlCheckIsNewbieOrVerteran;

	private UIModelLogin m_ModelLogin;

	private UIModelUser m_modelUser;

	private const float m_ExitAnimDuration = 9f;

	private uint m_DelayCallExitAnimFinish;

	private uint m_DelayCallShowBtnClose;

	private float m_OpenCreateNameTime;

	public ulong m_AccountId;

	private bool IsDefaultChooseNewbie;

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

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnSwitchRegisterState(RegisterState nextState)
	{
	}

	private void OnRegisterNameConfirm(object[] data)
	{
	}

	private void OnRegisterCheckNewbieVeteranConfirm(object[] data)
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void SwitchCaption(string caption)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void _003COnUIInit_003Eb__15_0()
	{
	}

	private void _003CProcessAnimEvt_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
