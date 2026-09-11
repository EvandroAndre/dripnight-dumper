namespace proto;

public class WorkshopSubscribeSlotInfo
{
	public uint slot_id;

	public EWorkshop.SlotState slot_state;

	public string workshop_code;

	public WorkshopBasicInfo workshop_basic_info;

	public long subscribe_at;

	public string original_workshop_code;
}
