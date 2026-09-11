using System;

namespace proto;

public class CollectionBookItemDesc : IComparable
{
	public uint id;

	public uint book_id;

	public uint sort_id;

	public bool hidden_state;

	public AwardDesc award;

	public uint token_id;

	public EInventory.AwardType token_type;

	public uint token_num;

	public uint back_token_num;

	public uint unlock_hidden_probability;

	public string circle_size;

	public string circle_pos;

	public bool grand_prize;

	public uint token_id2;

	public EInventory.AwardType token_type2;

	public int CompareTo(object obj)
	{
		return 0;
	}

	public CollectionBookItemDesc Clone()
	{
		return null;
	}
}
