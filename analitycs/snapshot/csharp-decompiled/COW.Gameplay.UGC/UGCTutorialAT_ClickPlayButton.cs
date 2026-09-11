using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_ClickPlayButton : UGCTutorialAtomicTaskBase
{
	private GameObject m_HookedGo;

	private int m_DelayDialogueSeconds;

	protected override void OnStart()
	{
	}

	private int ResolveDelayDialogueSeconds()
	{
		return 0;
	}

	protected override void OnDispose()
	{
	}

	public override bool CheckCompletion()
	{
		return false;
	}

	private void HookPlayButton()
	{
	}

	private void UnhookPlayButton()
	{
	}

	private void OnPlayBtnClick(GameObject go)
	{
	}

	private void SetDelayDialogueForNextLine(int delaySeconds)
	{
	}
}
