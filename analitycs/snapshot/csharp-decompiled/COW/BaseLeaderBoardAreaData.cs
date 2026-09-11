namespace COW;

public class BaseLeaderBoardAreaData
{
	public uint CountryId;

	public uint ProvinceId;

	public uint CityId;

	public string CountryName;

	public string ProvinceName;

	public string CityName;

	public bool IsCountrySet()
	{
		return false;
	}

	public bool IsProvinceSet()
	{
		return false;
	}

	public bool IsCitySet()
	{
		return false;
	}

	public void CLearData()
	{
	}

	public BaseLeaderBoardAreaData Clone()
	{
		return null;
	}
}
