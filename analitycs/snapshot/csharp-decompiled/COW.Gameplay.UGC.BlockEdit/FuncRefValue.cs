using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public class FuncRefValue
{
	public string graphId;

	public string funcId;

	public bool isAsync;

	public List<ValueData> args;

	public BlockEditContext Context;

	public FuncRefValue(BlockEditContext context)
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

	public FuncRefValue Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	public void AddItem(ValueData valueData, int index)
	{
	}

	public bool RemoveItem(int index)
	{
		return false;
	}

	public bool UpdateGraphId()
	{
		return false;
	}
}
