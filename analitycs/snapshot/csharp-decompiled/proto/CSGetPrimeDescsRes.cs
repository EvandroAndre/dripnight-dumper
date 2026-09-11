using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetPrimeDescsRes : IMessage
{
	public List<PrimeLevelDesc> prime_level;

	public List<PrimePrivilegeDesc> prime_privilege;

	public List<PrimeCDNDesc> prime_cdn;

	public List<PrimeLeaderboardDesc> prime_leaderboard;

	public ClientPrimeSettingDesc prime_setting;

	public List<PrimeFestivalDesc> prime_festival;

	public List<PrimeFestivalAwardDesc> prime_festival_award;

	public List<PrimeEventDesc> prime_event_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
