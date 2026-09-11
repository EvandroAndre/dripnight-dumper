using System.Collections.Generic;
using GCommon;

namespace COW;

public class Report_UDP_Ping
{
	public byte build_variant_type;

	public string region;

	public string country;

	public string phone_carrier;

	public string client_ip;

	public List<PingResult> ping_results;
}
