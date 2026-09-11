namespace COW.Gameplay.UGC.BlockEdit;

public class LocalVarDefineData : VarDefineData
{
	public BlockData Owner;

	public LocalVarDefineData(BlockEditContext context)
		: base(null)
	{
	}

	public override bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData)
	{
		return false;
	}

	public LocalVarDefineData Clone(BlockData owner, GraphData graphData)
	{
		return null;
	}

	public bool UpdateGetterAndSetter()
	{
		return false;
	}

	public BlockData FindProcessOwner()
	{
		return null;
	}
}
