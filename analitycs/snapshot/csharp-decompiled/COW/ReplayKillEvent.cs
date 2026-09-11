using System;
using UnityEngine;

namespace COW;

[Serializable]
public class ReplayKillEvent
{
	public uint EventID;

	public uint PlayerID;

	public float TriggerPoint;

	public uint Serial;

	public uint Group;

	public int weaponDataID;

	public Vector3 position;

	public Vector3 beKilledPlayerPos;

	public uint CurRound;
}
