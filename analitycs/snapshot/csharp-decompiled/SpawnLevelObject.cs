using System.Collections.Generic;
using UnityEngine;

public class SpawnLevelObject : MonoBehaviour
{
	public TriggerActionSpawnLevelObjectType LevelObjectType;

	public float ZoneRadius;

	public float Duration;

	public bool SelfCanTrigger;

	public bool TeammatesCanTrigger;

	public List<int> BuffID;
}
