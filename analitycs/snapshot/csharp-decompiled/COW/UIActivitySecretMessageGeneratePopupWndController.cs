using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIActivitySecretMessageGeneratePopupWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public const string SECRET_MESSAGE_EXCHANGE_LIMIT_RULE_KEY = "T_35_FH_SECRETMISSION_EXCHANGEMAXNUM";

	private const string SECRET_MESSAGE_GENERATE_RULE_KEY = "T_35_FH_SECRETMISSION_OUTPUTRULE";

	private const string LATEST_SECRET_MESSAGE_PLAYER_PREF_KEY = "SecretMessage{0}_Activity{1}_Account{2}_LatestSecretMessage";

	private const string GUIDE_STEP1_KEY = "SecretMessage_GenerateGuide_Step1_Account{0}";

	private const string GUIDE_STEP2_KEY = "SecretMessage_GenerateGuide_Step2_Account{0}";

	private const string LOG_IDENTIFIER = "SecretMessageGeneratePopup";

	private uint m_ActivityID;

	private uint m_SecretMessageID;

	private uint m_DelayExecuteGuidePeek;

	private string m_SecretMessageContent;

	private UIActivitySecretMessageGeneratePopupWndView m_View;

	private UIInvitePlatformCommonGridController m_ShareGridController;

	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	private bool IsViewDataSet => false;

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

	private void InitShareGridController()
	{
	}

	private void GetActivityDescBySubType()
	{
	}

	private void SetShareGridControllerViewData(string secretMessage)
	{
	}

	private string GetSecondRule()
	{
		return null;
	}

	private string GetThirdRule()
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

	private void RefreshSecretMessageLabel(string secretMessageContent)
	{
	}

	private void RefreshSecretMessageVFX(string secretMessage)
	{
	}

	private void SetInteractionStatus(bool active)
	{
	}

	private void OnCopyBtnClick()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
