using System.Collections.Generic;
using UnityEngine;

public class LobbyLWSceneExporter : MonoBehaviour
{
	public int UID;

	public int ZoneID;

	public int MaxTeamPlayerCount;

	public List<Transform> Team0SpawnPoints;

	public List<Transform> Team1SpawnPoints;

	public List<Transform> IceWallPositions;

	public List<Transform> SpawnFenceNames;

	public Transform BattleSceneTrigger;

	public Transform BattleSceneFence;
}
