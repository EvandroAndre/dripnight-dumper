using System.Collections.Generic;

namespace proto;

public class AttendanceList
{
	public List<AttendanceItem> attendance;

	public long end_time;

	public string url;

	public string loc_key;

	public bool is_signed_today;

	public EAttendance.AttendanceType attendance_type;

	public long start_time;

	public uint attendance_config_id;
}
