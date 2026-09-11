using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_PickColorWheelPreset : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.EventHandler m_PickHandler;

	private bool m_Registered;

	private UGCTutorialAtomicTaskParam_PickColorWheelPreset m_Param;

	private int m_TargetWheelIndex;

	private string m_TargetHexNorm;

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

	private void OnWheelPick(object[] data)
	{
	}

	private static string NormalizeHex(string hex)
	{
		return null;
	}
}
