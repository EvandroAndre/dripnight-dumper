using GCommon;

namespace COW;

public class MailData : CSVBaseData
{
	public int ID;

	public int MaxMailNum;

	public int ExpireDays;

	public int MaxReportMailNum;

	public int ReportMailExpireDays;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
