using GCommon;

namespace COW;

public class AvatarTagData : CSVBaseData
{
	private uint m_TagID;

	private uint m_PreTagID;

	private string m_Key;

	private string m_TagColor;

	private string m_Desc;

	public uint TagID => 0u;

	public uint PreTagID => 0u;

	public string Key => null;

	public string TagColor => null;

	public string Decs => null;

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
