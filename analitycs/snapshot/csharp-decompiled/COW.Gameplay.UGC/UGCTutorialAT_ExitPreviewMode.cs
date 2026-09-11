using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_ExitPreviewMode : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.VEventHandler m_EditPhaseHandler;

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

	private void OnEditPhaseChanged()
	{
	}
}
