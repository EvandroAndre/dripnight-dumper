using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UINinthSYSPrivilegePlayer : MonoBehaviour
{
	private List<GameObject> m_Rewards;

	private List<GameObject> m_IdleUIFXs;

	private List<GameObject> m_BurstUIFXs;

	private GameObject m_FlyUIFX;

	private float m_ShowDuration;

	private uint m_DelayKey;

	private Action m_OnPlayComplete;

	private void OnDestroy()
	{
	}

	public void Play(Action onComplete = null)
	{
	}

	public void Stop()
	{
	}

	public GameObject GetSlot(int index)
	{
		return null;
	}

	private void CompletePlay()
	{
	}

	private void HideAll()
	{
	}
}
