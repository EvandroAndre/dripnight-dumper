using System;
using System.Collections;
using System.Collections.Generic;
using Lean.Touch;
using UnityEngine;

namespace COW;

public class UIHDStandLobbyInputHandler : MonoBehaviour
{
	public enum RotateType
	{
		None,
		Scene,
		Avatar
	}

	private enum MouseButton
	{
		Left,
		Right,
		Middle,
		None
	}

	private sealed class _003CMoveReducer_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float speed;

		public UIHDStandLobbyInputHandler _003C_003E4__this;

		private int _003Cdirection_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveReducer_003Ed__37(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private readonly string MouseHorizontalAxisName;

	private readonly string MouseVerticalAxisName;

	private readonly string MouseScrollAxisName;

	public float PanMovementSensitivity;

	private Vector2 m_LastTouchPos;

	private Vector2 m_DownTouchPos;

	private float m_LastRotationAngle;

	private Vector3 m_MouseTouchStartPoint;

	private bool m_InputEnable;

	private float m_DownTime;

	private float m_LastGotoYardTime;

	private Vector3 _position;

	private Quaternion _rotation;

	public Transform _avatarTransform;

	private UIMaleAvatar m_avatar;

	public Transform m_petTransform;

	private int m_fingerIndex;

	private RotateType m_CurrentRotateType;

	private float m_DpiFactor;

	private const float IPHONE_DPI = 326f;

	private Coroutine m_CameraReducer;

	private bool InputEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void FingerSet(LeanFinger finger)
	{
	}

	private void FingerDown(LeanFinger finger)
	{
	}

	private void FingerUp(LeanFinger finger)
	{
	}

	private void LateUpdate()
	{
	}

	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return false;
	}

	private void RotateLobbyScene(float angledelta = 0f)
	{
	}

	public void SetEnableState(bool flag)
	{
	}

	private bool CheckIsTouchAvatar(Vector2 touchPos)
	{
		return false;
	}

	private IEnumerator MoveReducer(float speed)
	{
		return null;
	}
}
