using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCreditScoreDescRes : IMessage
{
	public CreditSettingDesc credit_setting_desc;

	public CreditSwitchDesc credit_switch_desc;

	public List<CreditPunishDesc> credit_punish_desc;

	public CreditAwardDesc credit_award_desc;

	public List<CreditReduceDesc> credit_reduce_desc_list;

	public List<CreditPenaltyDesc> credit_penalty_desc_list;

	public BehavioralPointsDesc credit_behavior_desc;

	public List<CreditAutoReportDesc> credit_auto_report_desc;

	public PhotoWallReportDesc photo_wall_report_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
