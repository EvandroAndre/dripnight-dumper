using GCommon;
using UnityEngine;

namespace COW;

internal class DetailTipsShowEvent : GEvent
{
	public Vector3 ItemPos;

	public string Description;

	public Vector3 LocalPosOffset;

	public DetailTipsShowEvent(Vector3 itemPos, string description, Vector3 LocalPosOffset)
	{
	}
}
