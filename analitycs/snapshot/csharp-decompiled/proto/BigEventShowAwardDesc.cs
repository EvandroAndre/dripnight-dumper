namespace proto;

public class BigEventShowAwardDesc
{
	public enum ShowType
	{
		ShowTypeNone,
		ShowTypeWarmUpReward,
		ShowTypeBasicReward,
		ShowTypeRandomReward,
		ShowTypeBigPrizeReward
	}

	public ELimitedEvent.EventID event_id;

	public AwardDesc award;

	public ELottery.RareType rare_type;

	public uint cdnid;

	public string cdnloc;

	public ShowType show_type;
}
