using System;
using UnityEngine;

namespace COW;

[Serializable]
public class ReplayDeadEvent
{
	public uint PlayerID;

	public uint EventID;

	public float TriggerPoint;

	public uint Group;

	public Vector3 position;

	public uint CurRound;
}
