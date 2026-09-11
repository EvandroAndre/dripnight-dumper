using GCommon;

namespace COW;

public class CSPeakTournamentData : CSVBaseData
{
	public uint SeasonStart;

	public ResourceID MainPageIconUIFX;

	public ResourceID PreModeIconUIFX;

	public ResourceID ModeIconUIFX;

	public uint Level;

	public ResourceID LadderIconUIFX;

	public ResourceID BigIcon;

	public ResourceID Icon;

	public uint UpperBound;

	public uint LowerBound;

	public uint SeasonEnd;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
