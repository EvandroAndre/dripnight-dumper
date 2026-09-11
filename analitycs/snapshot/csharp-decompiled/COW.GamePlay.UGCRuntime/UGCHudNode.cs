using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCHudNode
{
	public string entityID;

	public string parent;

	private List<string> _childList;

	public Rect rect;

	public string hudEntityID;

	public int fileID;

	public List<string> childList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCHudNode(string entityID, string parentID, List<string> childList, Rect r, string hudID, int fileID)
	{
	}

	public UGCHudNode()
	{
	}

	public int removeChild(string entityID)
	{
		return 0;
	}
}
