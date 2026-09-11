using COW.GamePlay;
using GCommon;

namespace COW;

internal class NotificationData : GEvent
{
	public NotifyShowDataSimple ShowData;

	public NotifyShowDataKill KillData;

	public NotificationType NotifyType;

	public uint ParamUint;

	public byte Priority;

	public bool Skip;

	public bool Weak;

	public NotificationData(NotificationType type)
	{
	}

	public void SetParamUint(uint scannerMarkExtraCoin)
	{
	}

	public void SetData(MatchModelKillData pData, byte localTeamId)
	{
	}

	public void SetKillData(bool isHeadShot, BHGGAEEHJCO victimPlayerID, BHGGAEEHJCO killerID, int killStack, uint scannerMarkAddCoin, NotificationKillType type)
	{
	}

	public NotifyShowDataKill SetBossDead(NotificationKillType boosDead)
	{
		return null;
	}

	public void SetKillData(int weaponID, uint scannerMarkAddCoin, NotificationKillType metropolisKill)
	{
	}

	public void SetAssistKnockDown()
	{
	}
}
