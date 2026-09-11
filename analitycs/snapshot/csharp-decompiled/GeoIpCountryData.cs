using GCommon;

public class GeoIpCountryData : CSVBaseData
{
	public string CountryCode;

	public bool IsBlackBlood;

	public bool IsNoBlood;

	public bool IsNoGacha;

	public bool Is18AgeShow;

	public bool IsNotPPTOP;

	public int DefaultBlood;

	public bool IsNoLBS;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
