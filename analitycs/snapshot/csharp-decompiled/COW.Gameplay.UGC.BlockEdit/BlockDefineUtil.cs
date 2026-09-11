using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public static class BlockDefineUtil
{
	public static int CurrentBuildBodyIndex;

	public static BlockDefine GetBlockDefine(BlockEditContext context, string typeName)
	{
		return null;
	}

	public static bool BuildBlockDefines(BlockEditContext context, List<string> sourceTexts)
	{
		return false;
	}

	public static BlockDefine BuildBlockDefine(BlockEditContext context, JsonData jsonData, string key, string defaultBlockType, bool allowEmpty = true)
	{
		return null;
	}

	public static BlockFieldDefine BuildField(BlockDefine owner, JsonData jsonData, ref int serializedFieldIndex, string key, string blockName, bool allowEmpty = true)
	{
		return null;
	}

	public static bool CheckNeedShowByPlatform(BlockDefine.UGCAPITarget apiTarget, int declare)
	{
		return false;
	}

	public static bool IsDynamicBlock(string typeName)
	{
		return false;
	}

	public static bool IsExpandableBlock(string typeName)
	{
		return false;
	}

	public static bool AddDynamicBlockDefineHelper(BlockEditContext context, string typeName, JsonData jsonData)
	{
		return false;
	}

	public static BlockDefine GetDynamicBlockDefine<T>(BlockEditContext context, string typeName, IBlockDeserializer<T> blockDeserializer, T serializedData) where T : class
	{
		return null;
	}

	public static BlockDefine CreateDynamicBlockDefine(BlockData blockData)
	{
		return null;
	}

	public static SerializeBlockFieldDefine CreateDynamicFieldDefine(BlockDefine blockDefine, int serializedFieldIndex)
	{
		return null;
	}

	public static bool GetFieldIndexFromSerializedFieldIndex(BlockDefine blockDefine, int serializedFieldIndex, out int fieldIndex)
	{
		fieldIndex = default(int);
		return false;
	}

	public static uint GetExpandableMaxCount()
	{
		return 0u;
	}

	public static bool HasFilter(BlockFieldDefine fieldDefine, string filter)
	{
		return false;
	}
}
