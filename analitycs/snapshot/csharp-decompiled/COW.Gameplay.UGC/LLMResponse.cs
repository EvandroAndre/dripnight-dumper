using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class LLMResponse
{
	public bool IsFinished;

	public long RequestID;

	public string ResponseID;

	public string PersonaID;

	public string Content;

	public List<string> Actions;

	public DOEOGBNPNAJ GIError;

	public List<int> GIWarnings;

	public int RetrieveUGCErrorCode()
	{
		return 0;
	}
}
