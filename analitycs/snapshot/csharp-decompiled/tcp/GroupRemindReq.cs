namespace tcp;

public class GroupRemindReq
{
	public ulong group_id;

	public EGroup.RemindType remind_type;

	public ulong remindee_id;

	public string deeplink;
}
