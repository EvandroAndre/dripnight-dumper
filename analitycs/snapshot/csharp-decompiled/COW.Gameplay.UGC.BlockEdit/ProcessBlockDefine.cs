using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public abstract class ProcessBlockDefine : BlockDefine
{
	public List<ProcessBlockBodyDefine> bodies;

	protected ProcessBlockDefine(BlockEditContext context)
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
