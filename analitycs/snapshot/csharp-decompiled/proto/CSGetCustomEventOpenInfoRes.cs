using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCustomEventOpenInfoRes : IMessage
{
	public List<CustomEventOpenInfoDesc> open_infos;

	public List<CustomEventEntranceDesc> entrances;

	public List<CustomEventTemplateDesc> templates;

	public List<CustomEventLocDesc> locs;

	public List<CustomEventCDNDesc> cdns;

	public List<CustomEventEntryDesc> entries;

	public List<CustomEventMatchResultTaskDesc> match_result_tasks;

	public List<CustomEventLobbyIconDesc> lobby_icons;

	public List<string> preLoad_cdn_urls;

	public List<CustomEventEntryDesc> preload_entries;

	public List<BigEventLocalMailDesc> local_mails;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
