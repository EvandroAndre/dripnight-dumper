using GCommon;

namespace COW;

public class UIOTPSetPasswordController : UIBaseController, IUIModelDataChangeObserver
{
	private UIOTPSetPasswordView m_View;

	private UIModelOTP m_ModelOTP;

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

	private void InitUIData()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnInputPasswordChange()
	{
	}

	private void OnInputPasswordSecondChange()
	{
	}

	private void OnPasswordEyeBtnClick()
	{
	}

	private void OnPasswordSecondEyeBtnClick()
	{
	}

	private bool CheckInputNumberCanConfirm()
	{
		return false;
	}

	private bool CheckPasswordAreSame()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
