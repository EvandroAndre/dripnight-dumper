using System.Collections.Generic;

namespace proto;

public class ReportInfo
{
	public ulong offender_id;

	public string offender_nickname;

	public List<PunishRecord> punish_records;

	public ulong match_id;

	public long match_create_time;

	public long report_time;

	public long mute_mic_expire_time;

	public uint mute_mic_duration;

	public uint cs_compensation_points;
}
