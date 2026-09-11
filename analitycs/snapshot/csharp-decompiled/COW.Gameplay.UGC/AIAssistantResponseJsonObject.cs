using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class AIAssistantResponseJsonObject
{
	public AIAssistantResponseSegment delta;

	public List<int> warnings;

	public int error_code;

	public string error_detail;
}
