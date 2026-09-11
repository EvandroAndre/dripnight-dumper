using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockDefine
{
	public enum UGCAPITarget
	{
		All,
		Client,
		GameServer
	}

	public string blockType;

	public string typeName;

	public string nameKey;

	public int funcType;

	public string scriptName;

	public string apiRefName;

	public int module;

	public bool IsNotExportable;

	public List<SerializeBlockFieldDefine> SerializeBlockFields;

	public TypeChangeRuleDefine TypeChangeRule;

	public BlockEditContext Context;

	private UGCBlockConfigData mConfigData;

	public UGCAPITarget apiTarget;

	public string url => null;

	public string APIRef => null;

	public UGCBlockConfigData ConfigData => null;

	public BlockDefine(BlockEditContext context)
	{
	}

	public virtual bool FromJsonData(JsonData jsonData)
	{
		return false;
	}
}
