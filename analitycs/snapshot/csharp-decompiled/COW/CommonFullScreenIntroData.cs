using GCommon;

namespace COW;

public class CommonFullScreenIntroData : CSVBaseData
{
	public uint ID;

	public string Title1;

	public string Title2;

	public string CDN1;

	public string Desc1;

	public string CDN2;

	public string Desc2;

	public string CDN3;

	public string Desc3;

	public string TutorialURL;

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
