using COW.Gameplay.UGC;
using GCommon.CommandPattern;

namespace COW.UGCHudEdit;

public class SetHudWidgetNameCommand : Command
{
	private UGCHudWidget m_Target;

	private string m_Name;

	private string m_LastName;

	public void Set(UGCHudWidget widget, string newName)
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
