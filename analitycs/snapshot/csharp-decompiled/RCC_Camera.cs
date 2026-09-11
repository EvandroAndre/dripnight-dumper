using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCC_Camera : MonoBehaviour
{
	public enum CameraMode
	{
		TPS,
		FPS,
		WHEEL,
		FIXED
	}

	private sealed class _003CFixShakeDelayed_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RCC_Camera _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFixShakeDelayed_003Ed__36(int _003C_003E1__state)
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

	public Transform playerCar;

	private Rigidbody playerRigid;

	private Camera cam;

	public GameObject pivot;

	private GameObject boundCenter;

	public CameraMode cameraMode;

	public float distance;

	public float height;

	private float heightDamping;

	private float rotationDamping;

	public float targetFieldOfView;

	public float minimumFOV;

	public float maximumFOV;

	public float hoodCameraFOV;

	public float wheelCameraFOV;

	public float maximumTilt;

	private float tiltAngle;

	internal int cameraSwitchCount;

	private Vector3 targetPosition;

	private float speed;

	private Vector3 localVector;

	private Vector3 collisionPos;

	private Quaternion collisionRot;

	private float index;

	public Transform _playerCar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void GetPlayerCar()
	{
	}

	public void SetPlayerCar(GameObject player)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void TPS()
	{
	}

	public void Collision(Collision collision)
	{
	}

	public void FixShake()
	{
	}

	private IEnumerator FixShakeDelayed()
	{
		return null;
	}
}
