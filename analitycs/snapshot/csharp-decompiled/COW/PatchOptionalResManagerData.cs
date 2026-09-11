using System;
using GCommon;
using proto;

namespace COW;

public class PatchOptionalResManagerData : CSVBaseData
{
	public uint OptionalReDefId;

	public bool IsDownload;

	public bool IsShow;

	public DateTime ShowTime;

	public DateTime EndTime;

	public bool HideInLogin;

	public bool HideAfterDownload;

	public bool IsDelete;

	public uint DownloadHardWare;

	public uint AutoDownloadHardWare;

	public int DownloadSortId;

	public uint GoPos;

	public string SubGopos;

	public bool ForceDownload;

	public bool NotAutoDownloadOldResource;

	public uint HotSort;

	public bool MapDownload;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public PatchOptionalResManagerData()
	{
	}

	public PatchOptionalResManagerData(PatchOptionalResManagerUpdateDesc UpdateItem)
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
