using System;
using GCommon;

namespace COW;

public class DateFormatByDiffRegionDataManager : SingletonModule<DateFormatByDiffRegionDataManager>
{
	public enum DateFormataType
	{
		YMD,
		MD,
		YMDHMS,
		MDHMS,
		HM,
		MDHM,
		YMDHM
	}

	private string m_DateFormatWithYear;

	private string m_DateFormatNoYear;

	private bool m_HasReverse;

	private const string DATE_FORMAT_HMS = " HH:mm:ss";

	private const string DATE_FORMAT_HM = "HH:mm";

	public string LocalDateFormatWithYear => null;

	public string LocalDateFormatNoYear => null;

	public bool ReserveMonthAndDay => false;

	protected override void OnInit()
	{
	}

	public DateTime GetDateTimeByTimeSpan(double timeSpan)
	{
		return default(DateTime);
	}

	public string GetDateStringByTimeSpan(double timeSpan, DateFormataType dateType)
	{
		return null;
	}

	public string GetDateStringByOriginalStr(string originalStr, DateFormataType dateType)
	{
		return null;
	}

	public string GetDateFormat(DateFormataType dateType)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
