namespace proto;

public class CSCreateOrDismissSpecialRelationReq
{
	public ulong friend_id;

	public EFriend.RelationType relation_type;

	public bool is_create;
}
