using GCommon;

namespace COW;

public class UIOTPWarningController : UIBaseController, IUIModelDataChangeObserver
{
	private UIOTPWarningView m_View;

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

	private void OnConfirmBtnClick()
	{
	}

	private void OnExitBtnClick()
	{
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
