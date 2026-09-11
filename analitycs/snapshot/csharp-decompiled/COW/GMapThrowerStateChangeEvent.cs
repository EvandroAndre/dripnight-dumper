using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class GMapThrowerStateChangeEvent : GEvent
{
	public ulong UniqueID;

	public uint ItemId;

	public uint LevelObjectId;

	public OPICPDCLKAG LevelObjectType;

	public Vector3 Position;

	public bool IsShow;

	public GMapThrowerStateChangeEvent(ulong uniqueID, uint itemId, uint levelObjectId, OPICPDCLKAG levelObjectType, Vector3 position)
	{
	}

	public GMapThrowerStateChangeEvent(ulong uniqueID)
	{
	}
}
