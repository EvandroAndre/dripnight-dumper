using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_OpenItemAttributeMode : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.VEventHandler m_AdjustTypeHandler;

	private bool m_Registered;

	protected override void OnStart()
	{
	}

	protected override void OnDispose()
	{
	}

	public override bool CheckCompletion()
	{
		return false;
	}

	private void OnAdjustTypeChanged()
	{
	}
}
