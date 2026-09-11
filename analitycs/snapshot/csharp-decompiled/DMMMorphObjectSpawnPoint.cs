using UnityEngine;

public class DMMMorphObjectSpawnPoint : MonoBehaviour
{
	public enum SpawnPointType
	{
		Large = 1,
		Mini
	}

	public SpawnPointType SpwanPointType;

	public uint Weight;
}
