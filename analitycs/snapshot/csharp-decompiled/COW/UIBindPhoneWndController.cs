using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using proto;

namespace COW;

public class UIBindPhoneWndController : UIPopupWindowController
{
	private UIBindPhoneWndView m_View;

	private UIPopMenuSmallControler m_AreaPopMenuCtrl;

	private List<PopMenuData> m_AreaNumberPopMenuDatas;

	private EBindPhoneOpt m_Opt;

	private Action m_OnConfirm;

	private PhoneNumControlDesc m_SelectedPhoneNumDesc;

	private string m_PendingPhoneNumber;

	private ulong m_NextVerifyCodeSendTime;

	private const uint VERIFY_CODE_LENGTH = 6u;

	private const ulong VERIFY_CODE_SEND_CD = 60uL;

	private UIModelAntiAddiction m_ModelAntiAddiction;

	private bool m_HasSend;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override string Rule()
	{
		return null;
	}

	private string GetAreaNumber(PhoneNumControlDesc desc)
	{
		return null;
	}

	private string GetCountryCode(PhoneNumControlDesc desc)
	{
		return null;
	}

	private uint GetNumberMinLength(PhoneNumControlDesc desc)
	{
		return 0u;
	}

	private uint GetNumberMaxLength(PhoneNumControlDesc desc)
	{
		return 0u;
	}

	public void SetData(EBindPhoneOpt opt, Action onConfirm, string descKey)
	{
	}

	private void GenerateAreaNumberMenu()
	{
	}

	private void OnAreaNumberSelect(object obj)
	{
	}

	private void OnBtnSendVerifyCodeClick()
	{
	}

	private void OnSendOTPResponse(MSDKResult res)
	{
	}

	private void OnBtnCheckConfirmClick()
	{
	}

	private void CheckVerifyCodeCorrect()
	{
	}

	private void LogBindPhone(string result)
	{
	}

	private void OnPhoneNumberCheckResponse(MSDKResult res)
	{
	}

	private bool CheckVerifyCodeValid()
	{
		return false;
	}

	private bool CheckPhoneNumberValid()
	{
		return false;
	}

	private void RefreshSendCodeTimesRemind()
	{
	}

	private void Update()
	{
	}

	private void _003CCheckVerifyCodeCorrect_003Eb__25_0(MSDKResult res)
	{
	}

	private void _003CCheckVerifyCodeCorrect_003Eb__25_1(MSDKResult res)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}
}
