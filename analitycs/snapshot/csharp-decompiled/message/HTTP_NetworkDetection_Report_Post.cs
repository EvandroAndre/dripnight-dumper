namespace message;

public class HTTP_NetworkDetection_Report_Post
{
	public ulong account_id;

	public byte build_variant_type;

	public string region;

	public string country;

	public string phone_carrier;

	public int system_api_level;

	public string client_ip;

	public NetworkDetection_ModuleResult[] results;
}
