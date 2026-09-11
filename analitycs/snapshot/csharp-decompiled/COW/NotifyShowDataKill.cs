using COW.GamePlay;

namespace COW;

internal class NotifyShowDataKill
{
	public NotificationKillType KillType;

	public BHGGAEEHJCO KillerID;

	public BHGGAEEHJCO BeKilledID;

	public bool IsHeadShot;

	public int WeaponDataID;

	public uint SkinID;

	public int KillStacks;

	public uint Flags;

	public uint ScannerMarkAddCoin;

	public EUIHudKillNotification hudKillNotificationType;

	public byte kingKillType;

	public int FactionId;

	public bool BossDetailShow;

	public byte EscortRuinPart;

	public string NickName;

	public int LocalTeamId;

	public bool isCounterAttack;

	public ESPKillOperateNoti Operate;

	public int KnockdownCount;

	public uint LoadoutReinforceToken;

	public void SetKillData(bool isHeadShot, BHGGAEEHJCO victimPlayerID, BHGGAEEHJCO killerID, int killStack, uint scannerMarkAddCoin, NotificationKillType type)
	{
	}

	public void SetData(MatchModelKillData pData, int id)
	{
	}

	private void CopyFrom(MatchModelKillData pData)
	{
	}

	public void Reset()
	{
	}
}
