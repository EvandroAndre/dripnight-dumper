using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class AIAssistantResponse
{
	public string DeltaText;

	public string DeltaAsrTxt;

	public string MsgID;

	public string ToolName;

	public List<ToolCallArg> ToolCallings;

	public List<int> GIWarnings;

	public string error_detail_raw;

	public DOEOGBNPNAJ GIError;

	public GIErrorDetail GIErrorDetail;
}
