using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_ClickExitEditor : UGCTutorialAtomicTaskBase
{
	private GameObject m_HookedGo;

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

	private void HookBackButton()
	{
	}

	private void UnhookBackButton()
	{
	}

	private void OnBackBtnClick(GameObject go)
	{
	}
}
