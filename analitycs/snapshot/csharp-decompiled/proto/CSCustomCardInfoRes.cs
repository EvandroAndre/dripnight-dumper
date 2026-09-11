using System.Collections.Generic;

namespace proto;

public class CSCustomCardInfoRes
{
	public uint custom_event_id;

	public uint floor;

	public List<CustomCardInfo> cards;

	public uint[] progress_info;

	public uint free_num;

	public bool receive_state;

	public uint release_num;

	public uint give_num;
}
