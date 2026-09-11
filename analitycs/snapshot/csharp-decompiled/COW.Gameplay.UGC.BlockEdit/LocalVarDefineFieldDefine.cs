using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class LocalVarDefineFieldDefine : SerializeBlockFieldDefine
{
	public bool isOut;

	public LocalVarDefineFieldDefine(BlockDefine owner)
		: base(null)
	{
	}

	public override bool FromJsonData(JsonData jsonData, ref int serializedFieldIndex)
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_FromJsonData(JsonData P0, ref int P1)
	{
		return false;
	}
}
