using System.Collections.Generic;
using GCommon;

namespace COW;

public class MutliRegionMapConfigManager : SingletonModule<MutliRegionMapConfigManager>
{
	private string MutliRegionStr;

	private CSVAsyncDataMap<uint, MutliRegionMapConfigDownload> m_OB52MutliRegionMapConfigDict;

	private Dictionary<uint, MutliRegionMapConfigDownload> m_MutliRegionMapDownloadDict;

	private Dictionary<uint, MutliRegionMapConfigDownload> MutliRegionMapDownloadDict => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public bool InitMutliRegionStr(string regionInfo)
	{
		return false;
	}

	public void InitMutliRegionMapConfigCSV()
	{
	}

	public void LoadMapconfigLoadInfo()
	{
	}

	public MutliRegionMapConfigDownload GetMapRegionDownloadInfo(uint mapID)
	{
		return null;
	}

	public bool NeedDownloadMutliRegionRes(uint mapid)
	{
		return false;
	}
}
