using GCommon;

namespace COW;

public class WorkShopPlayerStartTag : CSVBaseData, IGetId
{
	public int[] Select_1_Genre;

	public int[] Select_2_Genre;

	public int[] Select_2_Tag;

	public string Select_2_Pic;

	public string Select_2_Key;

	public string Select_1_Key;

	public int[] Select_1_Tag;

	public string Select_1_Pic;

	public int ID;

	public int Weight;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
