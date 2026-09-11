namespace proto;

public class ConcurrencyLimitSetting
{
	public enum Handler
	{
		None,
		LBS_BatchRemoveCoordinates
	}

	public Handler handler_name;

	public uint worker_count;

	public uint data_channel_length;

	public uint process_rate;

	public uint process_burst;

	public uint process_cnt_per_worker;
}
