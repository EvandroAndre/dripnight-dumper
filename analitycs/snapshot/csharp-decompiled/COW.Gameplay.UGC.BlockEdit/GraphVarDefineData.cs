using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class GraphVarDefineData : VarDefineData
{
	public GraphData Owner;

	public int index;

	public GraphVarDefineData(BlockEditContext context)
		: base(null)
	{
	}

	public override bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData)
	{
		return false;
	}

	public BHHMMLJCPJN ToExportProtoData()
	{
		return null;
	}

	public bool BuildGetterAndSetter()
	{
		return false;
	}

	public bool UpdateGetterAndSetter()
	{
		return false;
	}

	public void InitDefaultValue()
	{
	}

	public override bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData)
	{
		return false;
	}

	public GraphVarDefineData Clone(GraphData targetGraph)
	{
		return null;
	}
}
