using COW.Gameplay.UGC;
using GCommon.CommandPattern;

namespace COW.UGCHudEdit;

public class DeleteHudWidgetCommand : Command
{
	private UGCHudWidget m_Target;

	private UIModelUGCHudEdit m_Model;

	public void Set(UGCHudWidget widget)
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
