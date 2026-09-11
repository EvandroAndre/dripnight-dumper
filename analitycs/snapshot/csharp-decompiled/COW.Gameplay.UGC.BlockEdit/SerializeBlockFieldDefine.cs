using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializeBlockFieldDefine : BlockFieldDefine
{
	public EditorValueType EditorValueType;

	public TypeInfo DefinedType;

	public int valueIndex;

	public bool onlyForCodeBlock;

	public int BodyIndex;

	public int SerializeBlockFieldIndex;

	public string desKey;

	public SerializeBlockFieldDefine(BlockDefine owner)
		: base(null)
	{
	}

	public override bool FromJsonData(JsonData jsonData, ref int serializedFieldIndex)
	{
		return false;
	}

	private bool RegisterToOwner()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_FromJsonData(JsonData P0, ref int P1)
	{
		return false;
	}
}
