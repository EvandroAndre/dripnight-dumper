using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

public class ReportFeedbackData
{
	public ulong UserID;

	public BHGGAEEHJCO PlayerId;

	public uint HeadPic;

	public string NickName;

	public uint MainReason;

	public List<uint> SubReason;

	public uint CurrentCreditScore;

	public bool IsSuccess;

	public List<uint> BehaviorRuleIDs;

	public int CreditReduceDelta;

	public bool IsImportantReport;

	public bool IsQuickReport;

	public bool QuickReportAutoAssertSuccess;
}
