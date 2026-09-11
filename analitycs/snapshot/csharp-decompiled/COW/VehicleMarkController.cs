using System;
using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class VehicleMarkController : MonoBehaviour
{
	private LevelVehicle m_BindVehicle;

	private Func<bool> m_ShowCond;

	private Camera m_mainCamera;

	private Vector3 m_invisiblePos;

	public Vector3 scaleOrg;

	public float FixedSize;

	public float MinScale;

	public float MaxScale;

	private Vector3 m_TargetPos;

	private void Awake()
	{
	}

	public void SetScaleOrg(float x, float y, float z)
	{
	}

	public void BindVehicle(LevelVehicle lvVehicle, Func<bool> cond)
	{
	}

	protected Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private void LateUpdate()
	{
	}
}
