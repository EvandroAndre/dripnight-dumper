using COW.Gameplay.UGC;
using GCommon.CommandPattern;

namespace COW.UGCHudEdit;

public class SetHudWidgetSizeCommand : Command
{
	private UGCHudWidget m_Target;

	private int m_Width;

	private int m_Height;

	private int m_LastWidth;

	private int m_LastHeight;

	public void Set(UGCHudWidget widget, int width, int height)
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
