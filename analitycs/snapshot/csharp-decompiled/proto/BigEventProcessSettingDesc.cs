namespace proto;

public class BigEventProcessSettingDesc
{
	public ELimitedEvent.EventID event_id;

	public ELimitedEvent.ProcessType process_type;

	public uint process_id;

	public ulong start_value;

	public ulong end_value;

	public uint time_span;

	public uint lower_bound;

	public uint upper_bound;
}
