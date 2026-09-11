using COW.GamePlay;
using UnityEngine;

public class PreparePhaseCameraPivot : MonoBehaviour, FDACAOPGNJK
{
	private Transform m_CachTransform;

	private void Awake()
	{
	}

	public Vector3 GetCameraTrackableEntityPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		return default(Vector3);
	}

	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		return default(Quaternion);
	}

	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	public bool IsCameraTrackableEntityAlive()
	{
		return false;
	}
}
