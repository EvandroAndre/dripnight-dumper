using ProtoBuf;

namespace proto;

public class ReportGGPInfo : IMessage
{
	public bool is_report_to_ggp;

	public string ggp_url;

	public long ut_flag;

	public bool is_transfer_report;

	public bool is_enable_ggp;

	public string content;

	public bool is_get_feature;

	public bool is_get_flag;

	public bool is_enable_tcp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
