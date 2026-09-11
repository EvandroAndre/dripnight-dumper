using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

internal class UGCBasicCameraEntity : MonoBehaviour
{
	private UGCBasicCameraRepItem m_BasicCameraRepItem;

	private UGCTransformRepItem m_TransformRepItem;

	private Player m_MountPlayer;

	private PHLHIEGPMMK m_MountObserver;

	public string EntityID;

	private UGCTransformModule m_TrsModule;

	private Camera m_Camera;

	private Transform m_CachedCameraTrs;

	private Transform m_CachedTrs;

	private UGCTransformModule TrsModule => null;

	public Vector3 WorldPos => default(Vector3);

	public Quaternion WorldRot => default(Quaternion);

	public float Fov => 0f;

	public int CameraProjectionMode => 0;

	public float OrthographicSize => 0f;

	public int CullingMask => 0;

	private Camera Camera => null;

	private Transform CachedCameraTrs => null;

	private Transform CachedTrs => null;

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public static UGCBasicCameraEntity Create(string entityID)
	{
		return null;
	}

	private void CameraProjectionModeChangeEvent(int newValue)
	{
	}

	private void FovChangeEvent(float newValue)
	{
	}

	private void OrthographicSizeChangeEvent(float newValue)
	{
	}

	private void CullingMaskChangeEvent(int newValue)
	{
	}

	private void LocalPositionChangeEvent(Vector3 newValue)
	{
	}

	private void LocalRotationQChangeEvent(Quaternion newValue)
	{
	}

	private void OnParentChange(string parentEntityID)
	{
	}

	public void Mount(Player mountPlayer)
	{
	}

	public void UnMount(Player mountPlayer)
	{
	}

	public void Mount(PHLHIEGPMMK mountObserver)
	{
	}

	public void UnMount(PHLHIEGPMMK mountObserver)
	{
	}

	private bool IsValid(bool force = false)
	{
		return false;
	}
}
