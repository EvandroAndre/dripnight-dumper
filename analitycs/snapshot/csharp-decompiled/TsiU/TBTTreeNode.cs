using System.Collections.Generic;

namespace TsiU;

public class TBTTreeNode
{
	private const int defaultChildCount = -1;

	private List<TBTTreeNode> _children;

	private int _maxChildCount;

	public TBTTreeNode(int maxChildCount = -1)
	{
	}

	public TBTTreeNode()
	{
	}

	~TBTTreeNode()
	{
	}

	public TBTTreeNode AddChild(TBTTreeNode node)
	{
		return null;
	}

	public int GetChildCount()
	{
		return 0;
	}

	public bool IsIndexValid(int index)
	{
		return false;
	}

	public T GetChild<T>(int index) where T : TBTTreeNode
	{
		return null;
	}
}
