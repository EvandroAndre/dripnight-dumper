namespace proto;

public class CSOpenTreasureBoxReq
{
	public uint treasure_id;

	public ulong trans_id;

	public ETreasureBox.BoxType box_type;

	public bool can_get_unique;

	public uint item_cnt;

	public bool is_crate_treasure;

	public bool is_auto_open;
}
