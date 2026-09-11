using proto;

namespace COW;

public class GiftRewardPopupData
{
	public string Message;

	public RewardBtn BtnData;

	public string ReceiverName;

	public string SenderName;

	public EGiftRewardPopupWndType GiftType;

	public ulong SenderAccountID;

	public uint FriendIntimacyAdd;

	public MailAttachment MailAttachment;

	public GiftRewardPopupData(string receiverName, string message, string senderName, RewardBtn btnData, EGiftRewardPopupWndType giftType, ulong senderAccountID, uint friendIntimacyAdd, MailAttachment mailAttachment)
	{
	}
}
