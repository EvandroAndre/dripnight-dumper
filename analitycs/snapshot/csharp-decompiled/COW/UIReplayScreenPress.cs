using System;
using UnityEngine;

namespace COW;

public class UIReplayScreenPress : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__8_0;

		internal void _003COnPress_003Eb__8_0()
		{
		}
	}

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected Collider mCollider;

	[NonSerialized]
	protected UIButton mButton;

	[NonSerialized]
	protected bool mPressed;

	[NonSerialized]
	protected uint m_DelayCallID;

	public bool IsActive;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnPress(bool isPressed)
	{
	}
}
