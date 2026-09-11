using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetLimitedEventOpenInfoRes : IMessage
{
	public List<BigEventOpenInfoDesc> open_infos;

	public List<BigEventCDNDesc> cdns;

	public List<BigEventEntryDesc> entries;

	public List<BigEventEntranceSettingDesc> entrances;

	public List<BigEventMovieDesc> movies;

	public List<BigEventMatchResultTaskDesc> match_result_tasks;

	public List<BigEventLocalMailDesc> local_mails;

	public List<BigEventEntryPreLoad> preload_entries;

	public List<BigEventCDNDesc> preload_cdns;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
