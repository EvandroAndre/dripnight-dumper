using proto;

namespace COW;

public class GachaRulesPopUpIchisRecordData
{
	public ulong accountId;

	public string playerName;

	public ESharedGacha.RareType tierType;

	public long drawnTime;

	public uint rewardId;

	public uint rewardCount;

	public bool isSelf;
}
