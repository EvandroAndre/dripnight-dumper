namespace tcp;

public class EElitePass
{
	public enum Proto
	{
		Proto_NONE,
		Proto_CHALLENGE_COMPLETE_NTF,
		Proto_ACCOUNT_EP_LEVEL_UP,
		Proto_QUEST_COMPLETE_NTF,
		Proto_CHALLENGE_UPDATE_NTF,
		Proto_RECEIVE_PREMIUMPASS_NTF,
		Proto_ACCOUNT_EXP_CHANGE_NTF,
		Proto_BP_UNLOCK_SUCCESS_NTF,
		Proto_EP_DAILY_CHALLENGE
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}

	public enum BPPurchaseReason
	{
		BPPurchaseReason_NONE,
		BPPurchaseReason_IAP,
		BPPurchaseReason_SUBSCRIBE,
		BPPurchaseReason_EPCARD
	}
}
