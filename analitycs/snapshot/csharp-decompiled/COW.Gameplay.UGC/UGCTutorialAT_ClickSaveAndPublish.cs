using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_ClickSaveAndPublish : UGCTutorialAtomicTaskBase
{
	private GameObject m_HookedSaveAndPublishGo;

	private GameObject m_HookedUpdateGo;

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

	private void HookButtons()
	{
	}

	private void UnhookButtons()
	{
	}

	private void OnBtnClick(GameObject go)
	{
	}
}
