using System.Collections.Generic;

namespace tcp;

public class ReportChatReq
{
	public ulong target_account_id;

	public uint reason;

	public string message;

	public List<string> message_list;

	public uint channel_type;

	public string reporter_age_type;

	public string target_age_type;
}
