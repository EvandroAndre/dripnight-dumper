using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public static class BlockDataUtil
{
	public static readonly Dictionary<string, string> RefIdMapping;

	public static GraphData GraphRedirectTarget;

	public static readonly Dictionary<string, string> CheckLocalVarDefineRangeCache;

	public static bool CheckLocalVarDefineRangeLogEnabled;

	public static bool CheckLocalVarDefineRangeRepeated;

	public static readonly HashSet<string> CheckedBlocks;

	public static readonly List<string> TypeMismatchInfoCache;

	public static readonly Dictionary<BlockData, int> LibraryValueCompletionRequest;

	public static BlockData BuildBlockData<T>(BlockEditContext context, IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return null;
	}

	public static LocalVarDefineData BuildLocalVarDefineData<T>(BlockEditContext context, IBlockDeserializer<T> deserializer, T serializedData, BlockData owner) where T : class
	{
		return null;
	}

	public static bool BuildBlockLibraries(BlockEditContext context, List<string> sourceTexts)
	{
		return false;
	}

	public static void ComplementValuesFromLibraryBlock(BlockEditLibraries libraries, BlockData source, int savedValueCount)
	{
	}

	public static BlockData CreateBlockData(BlockEditContext context, string typeName)
	{
		return null;
	}

	public static ValueData CreateSlotValueData(TypeInfo valueType, BlockData owner)
	{
		return null;
	}

	public static ValueData CreateSlotValueData(TypeInfo valueType, BlockEditContext context)
	{
		return null;
	}

	public static GraphVarDefineData CreateGraphVarDefineData(GraphData owner, TypeInfo varType, string varName)
	{
		return null;
	}

	public static LocalVarDefineData CreateLocalVarDefineData(GraphData graph, BlockData owner, string varName, TypeInfo typeInfo)
	{
		return null;
	}

	public static LocalVarDefineData CreateLocalVarDefineData(BlockEditContext context, BlockData owner, string varName, TypeInfo typeInfo)
	{
		return null;
	}

	public static ValueData CreateDynamicValueData(BlockData owner, int fieldIndex)
	{
		return null;
	}

	public static GraphData CreateGraph(BlockEditContext context, string entityId, string entityType, int declare = 0, bool forUserBlock = false)
	{
		return null;
	}

	public static GraphData CreateGraph(BlockEditContext context, string entityType, int declare = 0)
	{
		return null;
	}

	public static bool SerializeBlockData<T>(IBlockSerializer<T> serializer, T serializedData, BlockData item) where T : class
	{
		return false;
	}

	public static bool SerializeBodyData<T>(IBlockSerializer<T> serializer, T serializedData, BodyData item) where T : class
	{
		return false;
	}

	public static bool SerializeValueData<T>(IBlockSerializer<T> serializer, T serializedData, ValueData item) where T : class
	{
		return false;
	}

	public static bool SerializeGraphVarDefines<T>(IBlockSerializer<T> serializer, T serializedData, Dictionary<string, GraphVarDefineData> items) where T : class
	{
		return false;
	}

	public static bool SerializeVarDefineData<T>(IBlockSerializer<T> serializer, T serializedData, VarDefineData item) where T : class
	{
		return false;
	}

	public static bool SerializeContentData<T>(IBlockSerializer<T> serializer, T serializedData, List<BlockData> items) where T : class
	{
		return false;
	}

	public static bool SerializeRootBlockData<T>(IBlockSerializer<T> serializer, T serializedData, BlockData item) where T : class
	{
		return false;
	}

	public static ValueData CreateConstDefaultValueByType(BlockEditContext context, TypeInfo valueType)
	{
		return null;
	}

	public static string ToPropertyValue(string entityType, string propertyName)
	{
		return null;
	}
}
