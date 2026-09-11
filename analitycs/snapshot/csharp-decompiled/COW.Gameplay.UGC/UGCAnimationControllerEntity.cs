using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

internal class UGCAnimationControllerEntity
{
	private UGCAnimationModule m_module;

	private UGCEntityDataStore m_repDataMgr;

	protected UGCAnimationController m_controller;

	protected UGCAnimationControllerRepItem m_repEntity;

	protected UGCAnimationStateEntity m_currentState;

	protected UGCAnimationClipEntity m_clipEntity;

	private bool m_isWaitSyncState;

	private float m_nextDebugTime;

	public UGCAnimationController Controller => null;

	public void SetModule(UGCAnimationModule module)
	{
	}

	public void AttachEntity(string entityID)
	{
	}

	public void InitWithAnimation(Animation animation)
	{
	}

	public void InitWithGameObject(GameObject obj)
	{
	}

	public void Update(float deltaTime)
	{
	}

	public bool TryAttachCurrentStateClip()
	{
		return false;
	}

	public void TryRestoreSyncState()
	{
	}

	private void OnResUUIDChange(string value)
	{
	}

	private void OnAttachTargetChange(string value)
	{
	}

	private void OnCurrentStateChange(string value)
	{
	}

	private void OnCurrentClipChange(string value)
	{
	}
}
