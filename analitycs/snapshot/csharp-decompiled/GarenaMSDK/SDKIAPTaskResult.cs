using System.Collections.Generic;

namespace GarenaMSDK;

public class SDKIAPTaskResult
{
	public ErrorCode Code;

	public string Msg;

	public Dictionary<string, string> Extras;

	public const string MSG_TOPUP_LIMIT_EXCEEDED = "topup_limit_exceeded";

	public const string MSG_LOCAL_CURRENCY_BANNED = "local_currency_ban";

	public const string TOTAL_LIMIT_IN_LOCAL_CURRENCY = "total_limit_in_local_currency";

	public const string REMAINING_AMOUNT_IN_LOCAL_CURRENCY = "remaining_amount_in_local_currency";

	public const string LOCAL_CURRENCY_CODE = "local_currency_code";
}
