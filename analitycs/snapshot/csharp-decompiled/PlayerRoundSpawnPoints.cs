using System.Collections.Generic;
using UnityEngine;

public class PlayerRoundSpawnPoints : MonoBehaviour
{
	public enum EPlayerSpawnType
	{
		SpawnTypePVE,
		SpawnTypeCS,
		SpawnTypeTDM,
		SpawnTypeAR,
		SpawnTypeNone
	}

	public int RoundId;

	public int TeamIndex;

	public BoxCollider SpawnAreaTrigger;

	public List<BoxCollider> SpawnAreaTriggerList;

	public BoxCollider ReviveSpawnAreaTrigger;

	public List<PlayerSpawnPoint> RoundSpawnPoints;

	public List<PlayerSpawnPoint> ReviveSpawnPoints;

	public EPlayerSpawnType PlayerSpawnType;
}
