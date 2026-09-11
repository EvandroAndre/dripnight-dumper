using COW.Gameplay.UGC;
using GCommon.CommandPattern;
using UnityEngine;

namespace COW.UGCHudEdit;

public class SetHudWidgetAnchorPositionCommand : Command
{
	private UGCHudWidget m_Target;

	private Vector2 m_AnchorPosition;

	private Vector2 m_LastAnchorPosition;

	public void Set(UGCHudWidget target, float anchorPositionX, float anchorPositionY)
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
