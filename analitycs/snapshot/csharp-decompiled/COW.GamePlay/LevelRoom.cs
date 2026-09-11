using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class LevelRoom : BaseLevelObject
{
	public int LevelID;

	public List<LevelRoom> neighborRooms;

	public List<PVEAISpawnPoint> AISpawnPointList;

	public bool IsNotAutoActive;

	private BoxCollider OPBJMFCMFLK;

	protected override string GetObjectTag()
	{
		return null;
	}

	private void Awake()
	{
	}
}
