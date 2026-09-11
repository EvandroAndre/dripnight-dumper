using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class ArrayValue
{
	public TypeInfo arrayType;

	public List<ValueData> contents;

	public BlockEditContext Context;

	public ArrayValue(BlockEditContext context)
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData, BlockData owner) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public ArrayValue Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	public bool ToExportProtoData(List<UGCVarValueDataV2> target)
	{
		return false;
	}

	public ValueData CreateAndAddItem(TypeInfo valueType)
	{
		return null;
	}
}
