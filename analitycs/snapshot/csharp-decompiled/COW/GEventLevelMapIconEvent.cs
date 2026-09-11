using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class GEventLevelMapIconEvent : GEvent
{
	public uint ObjectId;

	public Vector3 Pos;

	public bool ShowOrHide;

	public BHGGAEEHJCO OwnerID;

	public OPICPDCLKAG ObjectType;

	public string MinimapIcon;

	public static GEventLevelMapIconEvent LevelMapIconEvent;

	public GEvent Reset(uint objectId, bool show, OPICPDCLKAG eType)
	{
		return null;
	}

	public GEvent Reset(uint objectId, bool show, OPICPDCLKAG eType, Vector3 pos, BHGGAEEHJCO pId, string icon = "")
	{
		return null;
	}
}
