using System.Collections.Generic;

namespace proto;

public class CSGetFestivalAttendanceInfoRes
{
	public List<FestivalAttendanceItem> attendance;

	public bool is_signed_today;

	public string act_text1;

	public string act_text2;

	public string act_text3;

	public long start_time;

	public long end_time;

	public bool is_in_attendance_time;

	public uint festival_item_id1;

	public uint festival_item_id2;
}
