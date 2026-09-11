using System;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class EmoteData : CSVBaseData
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CollectionPrivilegeTagData> _003C_003E9__32_0;

		internal int _003CAddPrivileges_003Eb__32_0(CollectionPrivilegeTagData x, CollectionPrivilegeTagData y)
		{
			return 0;
		}
	}

	public ResourceID LeadDancerVFX;

	public EmoteDuoInfo DuoInfo;

	public const uint PRIME_SETSHARE_LOBBY_ANIM_EMOTE_ID = uint.MaxValue;

	public List<CollectionPrivilegeTagData> Privileges;

	public uint FollowDanceLeadID;

	public ResourceID FreezeLoopSFXResID;

	public ESourceType sourceTypeKey;

	public List<ResourceID> VFXMaleIngame;

	public List<ResourceID> VFXMaleSystem;

	public List<ResourceID> VFXFemaleIngame;

	public List<ResourceID> VFXFemaleSystem;

	public int[] HideClothEffectSlots;

	public List<ResourceID> SFXResourceID;

	public string SFXResourceidleId;

	public float[] MaleFootStepPlayTiming;

	public float[] FemaleFootStepPlayTiming;

	public float[] DashMaleFootStepPlayTiming;

	public float[] DashFemaleFootStepPlayTiming;

	public string DanceJoinIcon;

	public ResourceID animationResIDMale;

	public float DashEmoteSpeed;

	public float MoveEmoteSpeed;

	public uint PreviewDanceEmoteID;

	public ResourceID AnimationMaleCameraID;

	public ResourceID FootStepsResID;

	public uint sortId;

	public uint DancePoolFollowerEmoteID;

	public ResourceID PreviewAnimationMaleCameraID;

	public float VolumeDecay;

	public ResourceID AnimationMaleIdleID;

	public float DanceDistanceValue;

	public ResourceID PreviewAnimationFemaleCameraID;

	public uint iID;

	public ResourceID DashAnimationMaleID;

	public ResourceID AnimationFemaleIdleID;

	public ResourceID AnimationFemaleCameraID;

	public ResourceID inGameSceneIconResID;

	public ResourceID DashFootStepsResID;

	public ResourceID propIDHead;

	public ResourceID propIDRight;

	public ResourceID propIDLeft;

	public ResourceID propID;

	public ResourceID animationResIDFemale;

	public uint FollowDanceID;

	public ResourceID DashAnimationFemaleID;

	public bool StayPrivilegeTag;

	public bool IsFollowMoveEmote;

	public bool InfoPrivilegeTag;

	public bool IsLeadEmoteIngame;

	public bool IsMoveEmote;

	public bool IsSoundEmote;

	public bool DynamicMoveSound;

	public bool IsShowTextEmote;

	public bool is_random;

	public bool IsDancePoolEmote;

	public bool IsLeadEmote;

	public CooperateEmoteData CooperateInfo => null;

	public bool HasFollowDanceEmote => false;

	public bool HasFollowDanceLeadEmote => false;

	public override bool AfterParseData()
	{
		return false;
	}

	private ResourceID ParseFreezeLoopSFXResourceId(string input)
	{
		return default(ResourceID);
	}

	public bool HasFreezeLoopSFX(EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None)
	{
		return false;
	}

	public ResourceID GetFreezeLoopSFXResourceID(EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None)
	{
		return default(ResourceID);
	}

	public bool IsFreezeLoopSameAsEntrySFX(EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None, int index = 0)
	{
		return false;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public CooperateEmoteData GetCooperateInfo()
	{
		return null;
	}

	public bool HasMoveEmoteDashAnimRes(bool isFemale)
	{
		return false;
	}

	public EmotionRandomEffInfo GetRandomEffRes(bool islobby, bool isFemale)
	{
		return null;
	}

	public ResourceID GetRandomEffResByIdx(bool isLobby, bool isFemale, uint idx)
	{
		return default(ResourceID);
	}

	public int GetRandomEffCnt(bool islobby, bool isFemale)
	{
		return 0;
	}

	public int GetIndexByEffRes(bool islobby, bool isFemale, ResourceID effRes)
	{
		return 0;
	}

	public bool IsBattaleFlagEmote()
	{
		return false;
	}

	public bool CanLoop(EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None)
	{
		return false;
	}

	public bool HasIdleEmotion(bool isFemale, EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None)
	{
		return false;
	}

	public ResourceID GetIdleEmotionIdleResourceID(bool isFemale, EDuoEmoteStage duoEmoteStage, bool isPreview = false)
	{
		return default(ResourceID);
	}

	public uint GetFollowMoveEmoteLeaderID()
	{
		return 0u;
	}

	public uint GetFollowMoveEmoteFollowerID()
	{
		return 0u;
	}

	public ResourceID GetEmotionResourceID(bool isFemale, EDuoEmoteStage duoEmoteStage, bool isPreview = false)
	{
		return default(ResourceID);
	}

	public ResourceID GetEmoteSoundResID(EDuoEmoteStage duoEmoteStage, int index = 0)
	{
		return default(ResourceID);
	}

	public int GetSoundResIDCount(EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None)
	{
		return 0;
	}

	public ResourceID GetSoundResID(EDuoEmoteStage duoEmoteStage)
	{
		return default(ResourceID);
	}

	public float[] GetFootStepTimeing(bool isFemale, bool isFastRun = false)
	{
		return null;
	}

	private void AddPrivilege(CollectionPrivilegeTagType type)
	{
	}

	public void AddPrivileges()
	{
	}

	private List<ResourceID> GetVfxList(bool isInGame, bool isFemale)
	{
		return null;
	}

	public ResourceID GetEffectResIdByIdx(uint idx, bool isFemale, bool isInGame)
	{
		return default(ResourceID);
	}

	public void GetAllResIds(ref List<ResourceID> resIdList)
	{
	}

	public ResourceID GetPreviewVFXResource()
	{
		return default(ResourceID);
	}

	public ResourceID GetEmoteAnimRes(bool isFemale, EDuoEmoteStage duoEmoteStage = EDuoEmoteStage.None, bool isPreview = false)
	{
		return default(ResourceID);
	}

	public List<TeammateEmoteInfo> BuildRandEffectResIdx(ulong localAccountId, List<GroupMemberInfo> member, bool isInGame)
	{
		return null;
	}

	public List<TeammateEmoteInfo> BuildCooperateEmoteInEmoteLeader(ulong accountId, bool isInGame, bool isFemale)
	{
		return null;
	}

	public List<TeammateEmoteInfo> BuildCooperateEmoteInEmoteLeader(ulong localAccountId, List<GroupMemberInfo> members, bool isInGame, bool isFemale)
	{
		return null;
	}

	public List<TeammateEmoteInfo> BuildFollowEmoteTeammateInfo(ulong accountId, bool isInGame, bool isFemale)
	{
		return null;
	}

	public List<TeammateEmoteInfo> BuildFollowEmoteTeammateInfo(ulong localAccountId, List<GroupMemberInfo> members, bool isInGame, bool isFemale)
	{
		return null;
	}

	public List<TeammateEmoteInfo> BuildRandEffectResIdxInDanceLeader(ulong localAccountId, List<GroupMemberInfo> member, bool isInGame)
	{
		return null;
	}

	public List<TeammateEmoteInfo> BuildRandEffectResIdxInDanceFollow(ulong localAccountId, List<GroupMemberInfo> member, bool isInGame)
	{
		return null;
	}

	public List<TeammateEmoteInfo> BuildRandEffectResIdx(ulong accountId, bool isFemale, bool isInGame)
	{
		return null;
	}

	private List<ResourceID> ReadResourceIdList(string columnName, string[] headers, string[] values, char separator = ';')
	{
		return null;
	}

	private List<ResourceID> ReadResourceIdList(string input)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
