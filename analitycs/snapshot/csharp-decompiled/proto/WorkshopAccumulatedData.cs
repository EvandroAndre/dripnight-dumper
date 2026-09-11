namespace proto;

public class WorkshopAccumulatedData
{
	public string acc_data_sheet_name;

	public string acc_data_key;

	public long acc_data_value;

	public long update_time;

	public long clear_start_time;

	public uint clear_interval_hours;

	public uint clear_interval_unit;

	public bool disable_auto_clear;

	public int timezone_offset;

	public bool timezone_set_by_player;
}
