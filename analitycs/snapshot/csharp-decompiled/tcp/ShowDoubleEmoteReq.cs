namespace tcp;

public class ShowDoubleEmoteReq
{
	public ulong group_id;

	public uint emote_id;

	public ulong inviter_id;

	public EGroup.DoubleEmoteBehavior behavior;

	public ulong[] invitee_ids;
}
