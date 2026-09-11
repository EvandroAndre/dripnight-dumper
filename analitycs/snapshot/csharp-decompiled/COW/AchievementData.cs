using GCommon;

namespace COW;

public class AchievementData : CSVBaseData
{
	public int ID;

	private string m_Description;

	public ResourceID PictureRes;

	public int Priority;

	public int Param;

	public string Description => null;

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
