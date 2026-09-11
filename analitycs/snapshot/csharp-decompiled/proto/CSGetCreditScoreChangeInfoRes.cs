using System.Collections.Generic;

namespace proto;

public class CSGetCreditScoreChangeInfoRes
{
	public ulong account_id;

	public List<CreditScoreChangeInfo> credit_score_change_list;
}
