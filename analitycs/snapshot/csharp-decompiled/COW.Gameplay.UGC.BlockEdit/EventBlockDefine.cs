using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public class EventBlockDefine : ProcessBlockDefine
{
	public int eventType;

	public EventBlockDefine(BlockEditContext context)
		: base(null)
	{
	}

	public override bool FromJsonData(JsonData jsonData)
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_FromJsonData(JsonData P0)
	{
		return false;
	}
}
