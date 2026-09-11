using UnityEngine;

namespace COW.GamePlay;

public class LevelServerMiniGame : BaseLevelObject
{
	public MGAHNNBLGHN gameType;

	public float Radius;

	public Transform[] SpawnPoints;

	public Transform InviteTeleportPoint;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void InitEntityInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}
}
