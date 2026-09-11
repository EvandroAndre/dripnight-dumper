namespace proto;

public class CSChooseCollectionFinishMoveReq
{
	public ulong group_id;

	public ulong room_id;

	public CollectionFinishMoveItem finish_move;

	public ulong shard_key;

	public uint game_mode;
}
