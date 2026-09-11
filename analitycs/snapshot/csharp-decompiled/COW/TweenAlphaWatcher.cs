using System;
using UnityEngine;

namespace COW;

public class TweenAlphaWatcher : MonoBehaviour
{
	private TweenAlpha m_Tween;

	private float m_LastValue;

	private bool m_HasStarted;

	private Action m_OnReturnToStart;

	private const float EPSILON = 0.1f;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetOnReturnToStart(Action onReturnToStart)
	{
	}
}
