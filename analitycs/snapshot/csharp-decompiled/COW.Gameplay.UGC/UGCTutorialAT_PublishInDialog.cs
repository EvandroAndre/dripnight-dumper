using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_PublishInDialog : UGCTutorialAtomicTaskBase
{
	private GameObject m_HookedGo;

	private bool m_ReadySubscribed;

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

	private void OnDialogReady(UIUGCMyWorksPublishCheckController ctrl)
	{
	}

	private void BindToDialog(UIUGCMyWorksPublishCheckController ctrl)
	{
	}

	private void UnhookButton()
	{
	}

	private void OnBtnClick(GameObject go)
	{
	}

	private void ApplyConfiguredDefaults(UIUGCMyWorksPublishCheckController ctrl)
	{
	}
}
