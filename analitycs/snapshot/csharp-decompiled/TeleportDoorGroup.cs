using COW.GamePlay;
using UnityEngine;

public class TeleportDoorGroup : MonoBehaviour
{
	public LevelTeleportDoor[] levelTeleportDoors;

	public bool ProvideBuff;

	public int BuffID;

	public void CheckGroupIsValid()
	{
	}

	private void LogError(string message)
	{
	}
}
