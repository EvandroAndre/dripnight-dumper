using COW.Gameplay.UGC;
using GCommon.CommandPattern;

namespace COW.UGCHudEdit;

public class AdjustHudWidgetSelectorAngleCommand : RecordCommand
{
	private UIUGCHudWidgetSelectorController m_Selector;

	private UGCHudWidget m_BindWidget;

	private float m_InitLocalAngleZ;

	private float m_LocalAngleZ;

	public void Set(UIUGCHudWidgetSelectorController selector)
	{
	}

	public override void Execute()
	{
	}

	public override void UnExecute()
	{
	}

	public override void Record()
	{
	}

	public override void Clear()
	{
	}

	private void SetRotation(float deltaAngle)
	{
	}

	public void _003C_003EiFixBaseProxy_Clear()
	{
	}
}
