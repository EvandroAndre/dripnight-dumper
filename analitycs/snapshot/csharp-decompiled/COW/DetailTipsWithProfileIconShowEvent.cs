using GCommon;
using UnityEngine;

namespace COW;

internal class DetailTipsWithProfileIconShowEvent : GEvent
{
	public Vector3 ItemPos;

	public string Description;

	public Vector3 LocalPosOffset;

	public DetailTipsWithProfileIconShowEvent(Vector3 itemPos, string description, Vector3 LocalPosOffset)
	{
	}
}
