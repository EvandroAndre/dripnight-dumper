using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockDefineDictionary
{
	public bool IsDataCorrupted;

	public Dictionary<string, BlockDefine> BlockDefines;

	public Dictionary<string, DynamicBlockDefineHelper> DynamicBlockDefineHelpers;

	public BlockEditContext Context;

	public BlockDefineDictionary(BlockEditContext context)
	{
	}

	public void Clear()
	{
	}

	public bool FromJsonData(JsonData jsonData)
	{
		return false;
	}
}
