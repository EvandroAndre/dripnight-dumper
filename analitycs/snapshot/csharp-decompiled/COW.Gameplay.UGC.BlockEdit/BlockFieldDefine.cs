using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockFieldDefine
{
	public string fieldType;

	public string labelKey;

	public string enumType;

	public string nameKey;

	public bool isNotLinkable;

	public bool updateBlock;

	public bool locWithIndex;

	public HashSet<string> filters;

	public BlockDefine Owner;

	public BlockEditContext Context => null;

	public BlockFieldDefine(BlockDefine owner)
	{
	}

	public virtual bool FromJsonData(JsonData jsonData, ref int serializedFieldIndex)
	{
		return false;
	}
}
