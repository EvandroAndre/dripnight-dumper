using System;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_CloseColorWheel : UGCTutorialAtomicTaskBase
{
	private UIHudBlockEditColorSetterWndController m_ColorWheelController;

	private Action m_CloseHandler;

	private bool m_Registered;

	protected override void OnStart()
	{
	}

	public override bool CheckCompletion()
	{
		return false;
	}

	protected override void OnDispose()
	{
	}

	private void OnColorWheelClosed()
	{
	}
}
