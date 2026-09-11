using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class LLMStreamResponseBase
{
	public bool IsFinished;

	public long RequestID;

	public string ResponseID;

	public string PersonaID;

	public string DeltaText;

	public string AudioURL;

	public List<string> Actions;

	public DOEOGBNPNAJ GIError;

	public List<int> GIWarnings;

	public int RetrieveUGCErrorCode()
	{
		return 0;
	}
}
