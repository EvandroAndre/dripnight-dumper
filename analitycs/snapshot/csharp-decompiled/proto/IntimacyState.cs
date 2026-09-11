namespace proto;

public class IntimacyState
{
	public ulong friend_id;

	public EFriend.RelationType relation_type;

	public uint intimacy;

	public long create_at;

	public uint maintain_days;

	public EFriend.SpecialFriendState state;

	public long request_at;

	public bool is_visible;

	public bool enable_friend_skill;
}
