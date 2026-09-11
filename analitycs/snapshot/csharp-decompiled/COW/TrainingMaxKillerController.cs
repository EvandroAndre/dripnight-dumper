using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class TrainingMaxKillerController : MonoBehaviour
{
	private BHGGAEEHJCO m_BindPlayer;

	private Camera m_mainCamera;

	private Vector3 m_invisiblePos;

	public Vector3 scaleOrg;

	public float FixedSize;

	public float MinScale;

	public float MaxScale;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetScaleOrg(float x, float y, float z)
	{
	}

	protected virtual void OnTrainingZoneChanged(object[] param)
	{
	}

	private void OnTrainingMaxKillChange(object[] data)
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
