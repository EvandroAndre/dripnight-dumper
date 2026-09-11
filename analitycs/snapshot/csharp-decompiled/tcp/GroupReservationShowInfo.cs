using System;
using ProtoBuf;

namespace tcp;

public class GroupReservationShowInfo : IMessage, IComparable
{
	public ulong inviter_id;

	public ulong account_id;

	public string nickname;

	public uint head_pic;

	public ulong game_start_ts;

	public uint game_mode;

	public uint map_id;

	public ExternalIconInfo external_icon_info;

	public uint match_mode;

	public string lock_region;

	private int m_Priority;

	public int Priority
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}

	public int CompareTo(object obj)
	{
		return 0;
	}
}
