using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIOTPVerifyPhoneSmallController : UIBaseController, IUIModelDataChangeObserver
{
	private UIOTPVerifyPhoneSmallView m_View;

	private UIModelOTP m_ModelOTP;

	private UIPopMenuSmallControler m_AreaPopMenuCtrl;

	private List<string> m_AreaCodeList;

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

	protected override void OnUIOpenAsChild()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnSendVerifyCodeBtnClick()
	{
	}

	private void OnSMSBtnClick()
	{
	}

	private void OnWhatsAppBtnClick()
	{
	}

	private void OnInputPhoneNumberChange()
	{
	}

	private void OnInputVerifyCodeChange()
	{
	}

	private void UpdateConfirmBtn()
	{
	}

	private void UpdateSendBtn()
	{
	}

	private void InitUIData()
	{
	}

	private void InitPopMenu()
	{
	}

	private void GenerateAreaCodeList()
	{
	}

	private void OnAreaCodeSelect(object obj)
	{
	}

	private void SwapSMSAndWhatsApp()
	{
	}

	private bool CheckVerifyCodeValid()
	{
		return false;
	}

	private bool CheckPhoneNumberInputNotEmpty()
	{
		return false;
	}

	private bool CheckVerifyAccessSelected()
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

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
