using System.Collections.Generic;

namespace proto;

public class CSGetBPExpShareListRes
{
	public List<BPExpShareInfo> exp_share_list;

	public uint gained_exp;

	public ulong[] today_share_account;

	public uint today_claim_cnt;

	public List<BPExpReceivedHistory> exp_received_history;
}
