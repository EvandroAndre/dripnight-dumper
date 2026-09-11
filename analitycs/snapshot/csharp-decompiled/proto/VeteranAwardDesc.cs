namespace proto;

public class VeteranAwardDesc
{
	public uint id;

	public EAttendance.VeteranAwardType type;

	public uint term_id;

	public uint sort_id;

	public uint activeness_cdt;

	public AwardDesc award;

	public uint[] leave_days;

	private bool m_IsClaimed;

	private bool m_IsSpecialAward;

	public bool IsClaimed => false;

	public bool IsSpecialAward => false;

	private void OnConstructor()
	{
	}

	public void SetAwardClaimed()
	{
	}

	public void SetIsSpecialAward(bool isSpecialAward)
	{
	}
}
