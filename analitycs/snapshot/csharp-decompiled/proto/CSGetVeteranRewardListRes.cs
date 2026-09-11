using System.Collections.Generic;

namespace proto;

public class CSGetVeteranRewardListRes
{
	public bool is_veteran;

	public List<VeteranRewardItem> rewards;

	public uint[] random_task;

	public uint activeness;

	public bool is_return_login;

	public EAttendance.VeteranLeaveDays leave_days_tag;

	public bool first_game_played;

	public List<AwardDesc> return_login_awards;

	public List<AwardDesc> first_game_awards;

	public uint[] claim_stage_award_id;

	public uint daily_task_id;

	public PreveteranInfo preveteran_info;

	public bool own_special_stage;

	public uint[] claim_special_stage_award_id;

	public ulong return_at;
}
