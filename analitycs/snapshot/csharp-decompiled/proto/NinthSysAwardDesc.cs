namespace proto;

public class NinthSysAwardDesc
{
	public enum ELevel
	{
		None,
		Normal,
		Rare,
		SuperRare
	}

	public uint id;

	public AwardDesc award;

	public ELevel level;

	public bool is_privilege;

	public uint cdnid;

	public uint probability;

	public bool is_guarantee;
}
