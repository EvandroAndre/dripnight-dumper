using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCupConfigRes : IMessage
{
	public CupOpenInfoDesc open_info;

	public CupSettingDesc cup_setting;

	public List<CupTierDesc> tiers;

	public CupCDNSettingDesc cdn_setting;

	public List<CupNameOverwriteDesc> name_overwrite;

	public List<CupChestDesc> chests;

	public bool is_in_blocklist;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
