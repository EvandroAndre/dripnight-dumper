using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class MultiBillboard : MonoBehaviour
{
	[Serializable]
	public class BindedTransform
	{
		public Transform m_Trans;

		public Vector3 m_RotationAdjust;

		public bool m_LockPosition;

		public bool m_LockXAxis;

		public bool m_LockYAxis;

		public bool m_LockZAxis;

		[NonSerialized]
		public Vector3 m_SavedPos;

		[NonSerialized]
		public Vector3 m_SavedEuler;
	}

	private bool m_BindSelf;

	private bool m_Facing;

	private bool m_IsMainCamera;

	private Transform m_TargetMainCameraTransform;

	private bool m_MvpFirst;

	private Transform m_TargetTransform;

	public List<BindedTransform> m_BindedTransforms;

	public bool BindSelf => false;

	public bool Facing => false;

	public bool IsMainCamera => false;

	public bool MvpFirst => false;

	private Transform TargetTransform => null;

	private int FindSelf()
	{
		return 0;
	}

	private void CheckBindSelf()
	{
	}

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void processTrans(BindedTransform bindedTrans, Vector3 dirToCam)
	{
	}

	private void LateUpdate()
	{
	}
}
