namespace tcp;

public class ELbs
{
	public enum Proto
	{
		Proto_NONE,
		Proto_UPDATE_LBS_BAN_INFO_NTF
	}

	public enum BanOperation
	{
		BanOperation_NONE,
		BanOperation_BAN,
		BanOperation_UNBAN
	}
}
