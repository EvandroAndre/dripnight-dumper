using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCProjectileTrajectory : MonoBehaviour
{
	private string m_EntityID;

	private Vector3 m_StartPoint;

	private Vector3 m_InitialVelocity;

	private float m_CustomGravity;

	private float m_DragCoefficient;

	private Vector3 m_Acceleration;

	private float m_DurationTimeS;

	private List<object> m_LayerMask;

	private string m_CustomMaterial;

	private float m_Width;

	private UGCProjectileTrajectoryRepItem m_RepItem;

	private LineRenderer m_LineRenderer;

	public static UGCProjectileTrajectory Create(string entityID)
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	private void OnStartPointChangeEvent(Vector3 startPoint)
	{
	}

	private void OnInitialVelocityChangeEvent(Vector3 initialVelocity)
	{
	}

	private void OnCustomGravityChangeEvent(float customGravity)
	{
	}

	private void OnDragCoefficientChangeEvent(float dragCoefficient)
	{
	}

	private void OnAccelerationChangeEvent(Vector3 acceleration)
	{
	}

	private void OnDurationTimeMSChangeEvent(int durationTimeMS)
	{
	}

	private void OnLayerMaskChangeEvent(List<object> layerMask)
	{
	}

	private void OnCustomMaterialChangeEvent(string customMaterial)
	{
	}

	private void OnWidthChangeEvent(float width)
	{
	}

	private void UpdateProjectileTrajectory()
	{
	}

	private void _003CUpdateProjectileTrajectory_003Eb__23_0(bool succ, UGCMaterial resObj)
	{
	}
}
