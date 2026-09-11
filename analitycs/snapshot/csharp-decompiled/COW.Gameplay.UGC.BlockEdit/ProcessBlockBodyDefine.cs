using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class ProcessBlockBodyDefine
{
	public List<BlockFieldDefine> fields;

	public bool isLinkable;

	public List<SerializeBlockFieldDefine> SerializeBlockFields;

	public BlockDefine Owner;

	public ProcessBlockBodyDefine(BlockDefine owner)
	{
	}

	public bool FromJsonData(JsonData jsonData, string blockName, ref int serializedFieldIndex)
	{
		return false;
	}
}
