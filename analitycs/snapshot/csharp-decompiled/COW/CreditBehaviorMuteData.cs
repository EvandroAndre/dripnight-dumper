namespace COW;

public class CreditBehaviorMuteData
{
	public ulong account_id;

	public bool show_tips;

	public bool recover_volume;

	public CreditBehaviorMuteData(ulong accoutId)
	{
	}

	public bool GetFakeMuteByCreditBehaviorLevel()
	{
		return false;
	}

	public bool GetMuteByCreditBehaviorLevel()
	{
		return false;
	}
}
