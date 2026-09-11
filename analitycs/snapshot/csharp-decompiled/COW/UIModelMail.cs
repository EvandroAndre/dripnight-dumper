using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelMail : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MailInfo> _003C_003E9__51_1;

		public static Comparison<ReportMailInfo> _003C_003E9__53_1;

		public static Func<MailInfo, ulong> _003C_003E9__59_0;

		public static Func<ReportMailInfo, ulong> _003C_003E9__60_0;

		public static Comparison<MailInfo> _003C_003E9__61_0;

		public static Comparison<MailInfo> _003C_003E9__62_0;

		public static Action _003C_003E9__69_0;

		internal int _003CRequestMailList_003Eb__51_1(MailInfo a, MailInfo b)
		{
			return 0;
		}

		internal int _003CRequestReportMailList_003Eb__53_1(ReportMailInfo a, ReportMailInfo b)
		{
			return 0;
		}

		internal ulong _003CRequestReadMail_003Eb__59_0(MailInfo a)
		{
			return 0uL;
		}

		internal ulong _003CRequestReadReportMail_003Eb__60_0(ReportMailInfo a)
		{
			return 0uL;
		}

		internal int _003CAddLocalMail_003Eb__61_0(MailInfo a, MailInfo b)
		{
			return 0;
		}

		internal int _003CAddSubscriptionLocalMail_003Eb__62_0(MailInfo a, MailInfo b)
		{
			return 0;
		}

		internal void _003CCheckIfPopupRewards_003Eb__69_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public UIModelMail _003C_003E4__this;

		public UIModelGameAssistantIntroduction modelGameAssist;

		internal void _003CRequestMailList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public EMail.Status status;

		public List<MailInfo> mails;

		public UIModelMail _003C_003E4__this;

		public uint receiveGiftSource;

		public bool needRefreshAssist;

		public bool isBatchOp;

		public bool isFriendGift;

		public Action<MailInfo> _003C_003E9__2;

		public Action<MailInfo> _003C_003E9__3;

		internal void _003CRequestReadMail_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestReadMail_003Eb__2(MailInfo a)
		{
		}

		internal void _003CRequestReadMail_003Eb__3(MailInfo a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public EMail.Status status;

		public List<ReportMailInfo> mails;

		public UIModelMail _003C_003E4__this;

		public bool isBatchOp;

		public Action<ReportMailInfo> _003C_003E9__2;

		public Action<ReportMailInfo> _003C_003E9__3;

		internal void _003CRequestReadReportMail_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestReadReportMail_003Eb__2(ReportMailInfo a)
		{
		}

		internal void _003CRequestReadReportMail_003Eb__3(ReportMailInfo a)
		{
		}
	}

	private const string READ_MAIL_KEY = "READ_MAIL";

	private const string READ_REPORT_MAIL_KEY = "READ_REPORT_MAIL";

	public static readonly int MAX_MAIL_SHOW;

	public static readonly int MAIL_EXPIRE_DAYS;

	public static readonly int MAX_REPORT_MAIL_SHOW;

	public static readonly int MAIL_REPORT_EXPIRE_DAYS;

	public const uint PropID_GetMailRetOK = 2u;

	public const uint PropID_GetMailRetFail = 4u;

	public const uint PropID_ReadMailRetOK = 8u;

	public const uint PropID_ReadMailRetFail = 16u;

	public const uint PropID_GetReportMailRetOK = 32u;

	public const uint PropID_GetReportMailRetFail = 64u;

	public const uint PropID_ReadReportMailRetOK = 128u;

	public const uint PropID_ReadReportMailRetFail = 256u;

	private bool _003CHasNewMail_003Ek__BackingField;

	private bool _003CHasNewReportMail_003Ek__BackingField;

	private int _003CNewMailCount_003Ek__BackingField;

	private int _003CNewReportMailCount_003Ek__BackingField;

	private string m_ReportMatchTime;

	private string m_ReportMainReasons;

	private List<uint> m_ReportTypeLists;

	private List<MailInfo> m_CachedMailInfoList;

	private List<MailInfo> m_ShowMailInfoList;

	private List<MailInfo> m_NoReciveGiftMailList;

	private List<MailInfo> m_LocalMailList;

	private List<ReportMailInfo> m_CachedReportMailInfoList;

	private List<ReportMailInfo> m_ShowReportMailInfoList;

	private List<IGameAssistItemData> m_MailAssistDataList;

	private HashSet<string> m_ReadMailIDs;

	private HashSet<string> m_CurrentMailIDs;

	private HashSet<string> m_ReadReportMailIDs;

	private HashSet<string> m_CurrentReportMailIDs;

	public const string PREF_SUBSCRIPTION_RENEWAL_MAIL = "Subscription_RenewalMail_{0}";

	public bool HasNewMail
	{
		get
		{
			return _003CHasNewMail_003Ek__BackingField;
		}
		set
		{
			_003CHasNewMail_003Ek__BackingField = value;
		}
	}

	public bool HasNewReportMail
	{
		get
		{
			return _003CHasNewReportMail_003Ek__BackingField;
		}
		set
		{
			_003CHasNewReportMail_003Ek__BackingField = value;
		}
	}

	public int NewMailCount
	{
		get
		{
			return _003CNewMailCount_003Ek__BackingField;
		}
		set
		{
			_003CNewMailCount_003Ek__BackingField = value;
		}
	}

	public int NewReportMailCount
	{
		get
		{
			return _003CNewReportMailCount_003Ek__BackingField;
		}
		set
		{
			_003CNewReportMailCount_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public List<MailInfo> GetMailInfoList(bool sorted = true)
	{
		return null;
	}

	public List<ReportMailInfo> GetReportMailInfoList(bool sorted = true)
	{
		return null;
	}

	public List<MailInfo> GetNoReciveGiftMailList()
	{
		return null;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestMailList(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private EAnnouncement.PhoneQuality GetPhoneQuality()
	{
		return EAnnouncement.PhoneQuality.PhoneQuality_DEFAULT;
	}

	public void RequestReportMailList(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	private void InitMailDataToAssist(List<MailInfo> infoList, bool needRefreshAssistView, bool needUpdateAssistData)
	{
	}

	public void AddMailDataToAssist(bool needRefreshAssistView, bool needUpdateAssistData)
	{
	}

	private void SortMailList(List<MailInfo> list)
	{
	}

	private void SortReportMailList(List<ReportMailInfo> list)
	{
	}

	public void SetMailStatus(EMail.Status status, MailInfo mailInfo, bool isFriendGift = false, uint receiveGiftSource = 0u)
	{
	}

	public void RequestReadMail(List<MailInfo> mails, EMail.Status status, bool isBatchOp, bool isFriendGift = false, uint receiveGiftSource = 0u, bool needRefreshAssist = false)
	{
	}

	public void RequestReadReportMail(List<ReportMailInfo> mails, EMail.Status status, bool isBatchOp)
	{
	}

	public void AddLocalMail(List<MailInfo> localMails)
	{
	}

	public void AddSubscriptionLocalMail(List<MailInfo> localMails)
	{
	}

	private void RemoveSubscriptionLocalMails()
	{
	}

	public static bool IsLocalMailType(uint mailType)
	{
		return false;
	}

	private static string GetLocalMailId(MailInfo mailInfo)
	{
		return null;
	}

	public void DeleteLocallMail(List<MailInfo> deleteMails, bool notice, bool isBatchOp)
	{
	}

	public void ProcessLocalMail()
	{
	}

	public void CheckIfPopupRewards(EMail.Status type, List<ExchangedAward> exchangedAwards, AwardData awardData, ExchangeChangeData changeData)
	{
	}

	public void CheckIfPopupRewards(EMail.Status type, CSReadReportMailRes readMailRes)
	{
	}

	public void CheckIfPopupRewards(EMail.Status type, CSReadMailRes readMailRes)
	{
	}

	public bool IsMailRead(ulong id)
	{
		return false;
	}

	public bool IsMailRead(MailInfo mailInfo)
	{
		return false;
	}

	public bool IsReportMailRead(ulong id)
	{
		return false;
	}

	public void SetMailRead(ulong id)
	{
	}

	public void SetMailRead(MailInfo mailInfo)
	{
	}

	public void SetReportMailRead(ulong id)
	{
	}

	public void RemoveMailRead(ulong id)
	{
	}

	public void RemoveReportMailRead(ulong id)
	{
	}

	public void UpdateMailRead()
	{
	}

	public void UpdateReportMailRead()
	{
	}

	public void SaveMailRead()
	{
	}

	public bool HasUnreadMail()
	{
		return false;
	}

	public bool HasUnreadNoticeMail()
	{
		return false;
	}

	public bool HasUnreadSystemMail()
	{
		return false;
	}

	public bool HasUnreadReportMail()
	{
		return false;
	}

	public bool HasClaimableMail()
	{
		return false;
	}

	public bool HasClaimableNoticeMail()
	{
		return false;
	}

	public bool HasClaimableSystemMail()
	{
		return false;
	}

	public bool HasNewMailNtf()
	{
		return false;
	}

	public void SetSelectedReportMailAppealInfoToWebView(string mathTime, string mainReasons, List<uint> reportTypeLists)
	{
	}

	public string GetSelectedReportMailAppealInfoToWebView()
	{
		return null;
	}

	public string ConvertAwardToString(AwardData awardData)
	{
		return null;
	}

	public bool ConditionHasAttachmentMail(MailInfo mail)
	{
		return false;
	}

	public bool CheckAttachmentNotNull(MailAttachment attachment)
	{
		return false;
	}

	public string GetMailAttachmentFirstItemName(MailInfo mailInfo)
	{
		return null;
	}

	public bool ConditionRecevableMail(MailInfo mail)
	{
		return false;
	}

	public bool ConditionProcessableMail(MailInfo mail)
	{
		return false;
	}

	public bool ConditionDeletableMail(MailInfo mail)
	{
		return false;
	}

	public bool ConditionRecevableReportMail(ReportMailInfo mail)
	{
		return false;
	}

	public bool ConditionProcessableReportMail(ReportMailInfo mail)
	{
		return false;
	}

	public bool ConditionDeletableReportMail(ReportMailInfo mail)
	{
		return false;
	}

	public string MakeUrl(string url)
	{
		return null;
	}

	private void _003CRequestReportMailList_003Eb__53_0(HttpErrorCode errorCode, object res)
	{
	}

	private int _003CSortMailList_003Eb__56_0(MailInfo a, MailInfo b)
	{
		return 0;
	}

	private int _003CSortReportMailList_003Eb__57_0(ReportMailInfo a, ReportMailInfo b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
