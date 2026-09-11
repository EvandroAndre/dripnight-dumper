namespace proto;

public class CSAccountAgeCtrlByStoreInfoRes
{
	public ulong account_id;

	public EAntiAddiction.AgeCtrlStatus age_status;

	public uint min_age;

	public uint max_age;

	public ulong last_validation_time;
}
