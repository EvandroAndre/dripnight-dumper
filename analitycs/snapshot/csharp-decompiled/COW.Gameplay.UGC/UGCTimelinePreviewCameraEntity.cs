using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTimelinePreviewCameraEntity : UGCTimelinePreviewBaseEntity, FDACAOPGNJK
{
	public override bool Init(UGCRuntime ugcRuntime, string entityID)
	{
		return false;
	}

	protected override void OnUGCEntityRepChange(long propId, UGCSimpleValue value)
	{
	}

	public override void Destroy()
	{
	}

	public SceneEditObjectBase GetSceneEditObjectBase()
	{
		return null;
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

	public bool _003C_003EiFixBaseProxy_Init(UGCRuntime P0, string P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUGCEntityRepChange(long P0, UGCSimpleValue P1)
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}
}
