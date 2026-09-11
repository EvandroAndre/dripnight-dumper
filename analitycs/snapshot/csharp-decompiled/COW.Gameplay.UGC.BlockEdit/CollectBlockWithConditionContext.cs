using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public class CollectBlockWithConditionContext
{
	public class CollectCondition
	{
		public string BlockType;

		public string TypeName;

		public int FuncType;
	}

	public List<CollectCondition> Conditions;

	public List<BlockData> BlockDataList;

	public void AddCondition(string blockType = null, string typeName = null, int funcType = 0)
	{
	}
}
