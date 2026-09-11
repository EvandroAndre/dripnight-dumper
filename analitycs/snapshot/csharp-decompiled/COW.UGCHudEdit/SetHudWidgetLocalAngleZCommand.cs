using COW.Gameplay.UGC;
using GCommon.CommandPattern;

namespace COW.UGCHudEdit;

public class SetHudWidgetLocalAngleZCommand : Command
{
	private UGCHudWidget m_Target;

	private float m_LocalAngleZ;

	private float m_LastLocalAngelZ;

	public void Set(UGCHudWidget widget, float localAngleZ)
	{
	}

	public override void Execute()
	{
	}

	public override void UnExecute()
	{
	}

	public override void Clear()
	{
	}

	public void _003C_003EiFixBaseProxy_Clear()
	{
	}
}
