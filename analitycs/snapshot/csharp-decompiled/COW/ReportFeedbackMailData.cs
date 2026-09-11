using GCommon;
using proto;

namespace COW;

public class ReportFeedbackMailData : CSVBaseData
{
	public EMail.ReportMailType MailType;

	public string MailTitle;

	public string Content1;

	public string Content2;

	public string Content3;

	public string GotoUrl;

	public uint GoPos;

	public string SubGoPos;

	public string GotoKey;

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
