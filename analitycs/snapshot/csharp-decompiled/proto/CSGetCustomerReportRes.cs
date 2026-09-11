using ProtoBuf;

namespace proto;

public class CSGetCustomerReportRes : IMessage
{
	public CustomerReportDesc customer_report_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
