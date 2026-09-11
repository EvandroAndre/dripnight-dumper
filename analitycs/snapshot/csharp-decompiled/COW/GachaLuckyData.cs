using proto;

namespace COW;

public class GachaLuckyData
{
	public uint ChestID;

	public uint LuckyId;

	public UIModelGacha.GachaLuckyType Type;

	public uint FirstSuperPrizeDrawCount;

	public float LuckyPercent;

	public uint SuperPrizeMonthly;

	public uint MultiplePrizeAtOnce;

	public string Title;

	public string Description;

	public uint EmojiRainId;

	public uint ParamA;

	public uint ParamB;

	public uint ParamC;

	public void ProcessGainFirstSuperPrizeEarly(uint chestId, ChestLuckyRemindConfigDesc desc, uint drawCount, float luckyPercent)
	{
	}

	public void ProcessGainFirstPrizeEarly(uint chestId, ChestLuckyRemindConfigDesc desc, uint drawCount, float luckyPercent)
	{
	}

	public void ProcessAccumulatedSuperPrizesMonthly(uint chestId, ChestLuckyRemindConfigDesc desc, uint superPrizeMonthly)
	{
	}

	public void ProcessMultiplePrizesAtOnce(uint chestId, ChestLuckyRemindConfigDesc desc, uint prizeCount)
	{
	}
}
