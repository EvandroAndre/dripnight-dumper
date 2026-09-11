using System;
using UnityEngine;

namespace COW;

[Serializable]
public class ReplayHighlightEventPeriod
{
	public float TriggerPoint;

	public Vector3 BeKilledPlayerPos;

	public ReplayHighlightEventPeriod Clone()
	{
		return null;
	}
}
