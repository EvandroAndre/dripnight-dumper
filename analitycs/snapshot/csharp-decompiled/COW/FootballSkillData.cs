using GCommon;

namespace COW;

public class FootballSkillData : CSVBaseData
{
	public uint ID;

	public uint SkillID;

	public string Name;

	public string Description;

	public string Params;

	public ResourceID IconRes;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
