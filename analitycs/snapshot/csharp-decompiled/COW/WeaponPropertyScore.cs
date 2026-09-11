using GCommon;

namespace COW;

public class WeaponPropertyScore : CSVBaseData, IGetId
{
	public uint WeaponID;

	public string[] Update;

	public string Information;

	public uint[] ExceptScore;

	public uint SpecialMode;

	public uint[] SpecialWeaponID;

	public uint CSPrice;

	public string CSPriceDesc;

	public uint GetId()
	{
		return 0u;
	}

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
