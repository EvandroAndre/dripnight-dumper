using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCBtTreeData
{
	public string title;

	public string description;

	public string root;

	public Dictionary<string, object> properties;

	public Dictionary<string, UGCBtNodeData> nodes;
}
