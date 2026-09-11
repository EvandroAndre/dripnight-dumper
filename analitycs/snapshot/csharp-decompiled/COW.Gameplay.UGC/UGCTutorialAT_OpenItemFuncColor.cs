using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_OpenItemFuncColor : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.EventHandler m_OpenHandler;

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

	private void OnColorOpen(object[] data)
	{
	}
}
