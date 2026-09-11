using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIActivitySecretMessageRedeemPopupWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private const string DEFAULT_INPUT_TEXT_KEY = "T_35_FH_SECRETMISSION_INPUTNOLIMIT";

	private const string DISABLE_INPUT_TEXT_KEY = "T_35_FH_SECRETMISSION_INPUTLIMIT";

	private const string SECRET_MESSAGE_REDEEM_RULE_KEY = "T_35_FH_SECRETMISSION_INPUTRULE";

	private const string ILLEGAL_INPUT_VALUE_TIPS_KEY = "T_35_FH_SECRETMISSION_UNKOWNINPUT";

	private const string PREFIX_CODE_NOT_FOUND_TIPS_KEY = "BR_SECRET_MISSION_FRONT_KEY_ERR";

	private const string EXCHANGE_SUCCESS_KEY = "T_35_FH_SECRETMISSION_INPUTSUCCESS";

	private const string GUIDE_STEP1_KEY = "SecretMessage_RedeemGuide_Step1_Account{0}";

	private uint m_ActivityID;

	private uint m_SecretMessageID;

	private uint m_DelayExecuteGuidePeek;

	private UIActivitySecretMessageRedeemPopupWndView m_View;

	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnSecretMessageExchanged(bool success)
	{
	}

	private string GetSecondRule()
	{
		return null;
	}

	private void SetupDefaultState()
	{
	}

	private void RefreshHelpTipsLabel()
	{
	}

	private void RefreshPopupWndTitle()
	{
	}

	private void RefreshConfirmBtn()
	{
	}

	private void RefreshSecretMessageInput(bool clearInputValue)
	{
	}

	private void ClearSecretMessageInput()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnPasteBtnClick()
	{
	}

	private void OnSecretMessageInputChanged()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void StopGuideQueue()
	{
	}

	private void PrepareGuideQueueData()
	{
	}

	private void StartDelayExecuteGuidePeek()
	{
	}

	private void DelayExecuteGuidePeek()
	{
	}

	private void PopAndExecuteNext()
	{
	}

	public void SetViewData(uint activityID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
