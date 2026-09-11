using GCommon;

namespace message;

public class NetworkDetection_IPResult
{
	public string target_ip;

	public int average_delay;

	public int loss_rate;

	public TracerouteNodeResult[] traceroute_node_results;

	public long time_stamp;

	public int err_code;
}
