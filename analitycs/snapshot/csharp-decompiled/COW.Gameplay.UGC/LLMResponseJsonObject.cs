using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class LLMResponseJsonObject
{
	public int code;

	public LLMResponseDataJsonObject data;

	public List<int> warnings;

	public LLMResponseDataJsonObject response;
}
