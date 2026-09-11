using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class DataBlockDefine : BlockDefine
{
	public TypeInfo ReturnType;

	public string ReturnKey;

	public List<BlockFieldDefine> fields;

	public long UIBlockType;

	public DataBlockDefine(BlockEditContext context)
		: base(null)
	{
	}

	public override bool FromJsonData(JsonData jsonData)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_FromJsonData(JsonData P0)
	{
		return false;
	}
}
