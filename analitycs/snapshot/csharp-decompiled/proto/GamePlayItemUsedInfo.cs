namespace proto;

public class GamePlayItemUsedInfo
{
	public enum ItemType
	{
		None,
		UsedCount,
		InflictDamage,
		BlockDamage,
		GetIIVItemCount,
		KillCount,
		AssistCount
	}

	public uint used_item_id;

	public ItemType used_item_type;

	public uint effect_value;
}
