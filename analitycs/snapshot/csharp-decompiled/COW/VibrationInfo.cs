using GCommon;

namespace COW;

public class VibrationInfo : CSVBaseData
{
	public int ID;

	public long[] OldPattern;

	public long[] Timings;

	public int[] Amplitudes;

	public int IosVibrateID;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
