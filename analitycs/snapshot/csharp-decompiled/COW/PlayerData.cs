using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;
using proto;

namespace COW;

internal class PlayerData
{
	public BHGGAEEHJCO id;

	public ulong userId;

	public byte gsTeamId;

	public byte scTeamId;

	public byte scMemberId;

	public string nickname;

	public string originalNickName;

	public string teamname;

	public string teamnameabbr;

	public uint headicon;

	public uint teamicon;

	public uint killCount;

	public uint titleId;

	public uint damage;

	public bool isDead;

	public string area;

	public uint deadCount;

	public uint assistCount;

	public uint survival_time;

	public uint avatarID;

	public List<uint> clothes;

	public List<AccountCollectionCustomItemInfo> customData;

	public string SharerNickname;

	public HashSet<uint> ClothEffectUnlockItems;

	public uint skinColor;

	public string ClanName;

	public uint ClanBadgeID;

	public uint ClanFrameId;

	public ulong ClanID;

	public uint showWeaponId;

	public uint transformerId;

	public uint groupAnimId;

	public uint BannerId;

	public int TeamIndex;

	public Vector3 lastPosition;

	public Vector3 lastForward;

	public Dictionary<uint, int> itemDic;

	public Player player;

	public float headScale;

	public uint headAvatarID;

	public int score;

	public int factionId;

	public uint likeCount;

	public uint rank;

	public uint role;

	public BadgeInfoInGame badgeInfoInGame;

	public bool isSamoAI;

	public uint footballGoal;

	public uint footballAssist;

	public uint knockdownCount;

	public uint healingAmount;

	public uint resurrectTeammateCount;

	public uint revivalCount;

	public int tokenCount;

	public uint[] match_event_achievements;

	public uint loadoutID;

	public List<uint> originalSkill;

	public InGameLeaderBoardTitleInfo inGameLeaderBoardTitleInfo;

	public string externalIcon;

	public EAccount.ExternalIconStatus externalIconStatus;

	public EAccount.ExternalIconShowType externalIconShowType;

	public string LockRegion;

	public uint peakRankPos;

	public float CSRankRatingPoint;

	public float BRRankRatingPoint;

	public bool IsTeamMvp;

	public uint knockdownRealDamage;

	public uint headShotKillCount;

	public uint AvatarFrameId;

	public int CSPeakPoints;

	public Dictionary<uint, uint> SF50BCareerInfoDict;

	public static implicit operator BaseProfileInfo(PlayerData playerDataInfo)
	{
		return null;
	}
}
