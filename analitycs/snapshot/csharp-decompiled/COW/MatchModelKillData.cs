using COW.GamePlay;

namespace COW;

internal class MatchModelKillData
{
	public BHGGAEEHJCO killerId;

	public BHGGAEEHJCO beKilledID;

	public string weaponName;

	public uint hitBodyPart;

	public uint skinID;

	public int weaponDataID;

	public int killStacks;

	public uint flags;

	public int killerScore;

	public int killerTeamScore;

	public int killerHypeLvl;

	public uint scannerMarkExtraCoin;

	public EUIHudKillNotification hudKillNotificationType;

	public bool isCounterAttack;

	public bool isaAceTeam;

	public byte kingKillType;

	public ESPKillOperateNoti operate;

	public bool quitGame;

	public int FactionId;

	public int KnockdownCount;

	public uint loadoutReinforceToken;

	public MatchModelKillData()
	{
	}

	public MatchModelKillData(MatchModelKillData pData)
	{
	}

	public void Reset()
	{
	}

	public void SetKillOccurs(Player killer, Player beKilled, string weaponName, uint hitBodyPart, uint skinID, int weaponDataID, int killStacks, bool quitGame = false, uint flags = 0u, int killerScore = 0, int killerTeamScore = 0, int killerHypeLvl = 0, uint scannerMarkExtraCoin = 0u, EUIHudKillNotification hudKillNotificationType = EUIHudKillNotification.EUIHudKillNotification_Normal, bool isCounterAttack = false, bool isaAceTeam = false, byte kingKillType = 0, uint loadoutReinforceToken = 0u)
	{
	}

	public void SetTargetPlayerKillOccurs(uint hitBodyPart, int killStacks, uint flags, ESPKillOperateNoti operate, int weaponDataID, uint scannerMarkExtraCoin, BHGGAEEHJCO beKilledID, BHGGAEEHJCO KilledID, EUIHudKillNotification hudKillNotificationType, byte kingKillType, uint skinID = 0u, uint loadoutReinforceToken = 0u)
	{
	}

	public void SetKnockOtherDown(ESPKillOperateNoti operate, bool isCounterAttack, uint killerID, uint gainCoins, int knockedDownCount, uint SkinID, bool isHeadShot = false)
	{
	}
}
