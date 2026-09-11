using GCommon;
using UnityEngine;
using message;

namespace COW;

public class EmoteDuoInfo : CSVBaseData
{
	public uint EmoteId;

	public ResourceID PreviewDuoAnimationMale;

	public ResourceID VFXPreviewDuoMale;

	public ResourceID PreviewDuoAnimationIdleMale;

	public ResourceID PreviewDuoAnimationFeMale;

	public ResourceID VFXPreviewDuoFemale;

	public ResourceID PreviewDuoAnimationIdleFeMale;

	public DLMHJFGLGAA LocationType;

	public ResourceID DuoInviterMaleID;

	public ResourceID VFXDuoMaleInviteID;

	public ResourceID DuoInviterMaleIdleID;

	public ResourceID VFXDuoMaleInviteIdleID;

	public ResourceID DuoInviteeMaleID;

	public ResourceID DuoInviteeMaleIdleID;

	public ResourceID DuoInviterFemaleID;

	public ResourceID VFXDuoFemaleInviteID;

	public ResourceID DuoInviterFemaleIdleID;

	public ResourceID VFXDuoFemaleInviteIdleID;

	public ResourceID DuoInviteeFemaleID;

	public ResourceID DuoInviteeFemaleIdleID;

	public float DistanceValue;

	public ResourceID DuoMaleInviteID;

	public ResourceID DuoMaleInviteIdleID;

	public ResourceID DuoFemaleInviteID;

	public ResourceID DuoFemaleInviteIdleID;

	public ResourceID SFXResourceID;

	public ResourceID FreezeLoopSFXResourceID;

	public uint IsFollowEmote;

	public Vector3 LobbyPositionOffsetParam;

	public Vector3 PreviewPositionParam;

	public Vector3 LobbyPreviewPositionParam;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static bool IsDuoEmote(uint emoteId)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
