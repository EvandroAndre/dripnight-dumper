using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCTutorialGuide_Dialogue : UGCTutorialGuideBase
{
	private Action m_OnComplete;

	public override bool IsBlocking => false;

	public List<UGCTutorialDialogueData> Dialogues => null;

	protected override void OnShow(Action onComplete)
	{
	}

	public void OnDialogueSequenceComplete()
	{
	}

	protected override void OnHide()
	{
	}

	protected override void OnDispose()
	{
	}

	public bool _003C_003EiFixBaseProxy_get_IsBlocking()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDispose()
	{
	}
}
