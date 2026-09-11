using UnityEngine;

namespace COW.GamePlay;

public class UGCSingleTeleportDoor : UGCLevelAutoTeleportDoor
{
	public bool TeleportActive;

	public uint TargetDoorId;

	public bool IsStartPoint;

	public GameObject EditEffect;

	protected override void OnStart()
	{
	}

	public void ResetArrowRot(Vector3 MNBPEEDKIAD)
	{
	}

	public override void BecomeAlone()
	{
	}

	public override bool RemoveDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_BecomeAlone()
	{
	}

	public bool _003C_003EiFixBaseProxy_RemoveDynamicallyForUGC(string P0)
	{
		return false;
	}
}
