using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeRunSpawnData
{
	public uint AutoID;

	public List<Transform> spawnPoints;

	public List<Transform> refRetreatPoints;
}
