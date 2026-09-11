namespace GCommon;

public class TracerouteResult : NetDetectionResult
{
	public TracerouteNodeResult[] traceroute_node_results;

	public long time_stamp;

	public ETraceRouteError err_code;
}
