using System;
using UnityEngine;

public class RendererVisibilityNotifier : MonoBehaviour
{
	private Action<RendererVisibilityNotifier> m_BecameVisibleEvent;

	private Action<RendererVisibilityNotifier> m_BecameInvisibleEvent;

	public event Action<RendererVisibilityNotifier> BecameVisibleEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<RendererVisibilityNotifier> BecameInvisibleEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}
}
