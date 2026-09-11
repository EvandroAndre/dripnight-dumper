using System.Collections.Generic;
using UnityEngine;
using message;

public class PVEAISpawnPoint : MonoBehaviour
{
	public int Id;

	public BMLKMJHLEDP SpawnAIType;

	public int SpecificPathGroupId;

	public int AttackSafeDoorId;

	public bool isGroundPoint;

	public bool isBossOnly;

	public List<int> RoundsId;

	public float SpawnIntervalTime;

	public int SpawnNum;

	private void Awake()
	{
	}
}
