namespace proto;

public class CSFFVoiceReportReq
{
	public ulong report_action_id;

	public uint behavior_rule_id;

	public ulong[] reporter_account_ids;

	public ulong[] need_noti_account_ids;

	public long mute_mic_expire_time;

	public ulong match_id;

	public long match_create_time;

	public long report_time;
}
