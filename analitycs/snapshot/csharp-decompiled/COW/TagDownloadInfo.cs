using System.Collections.Generic;
using GCommon;

namespace COW;

public class TagDownloadInfo
{
	public uint OptionalReDefId;

	public EDownloadContextState ShowState;

	private bool m_IsShow;

	public List<uint> resTypeList;

	private List<ResVersionInfo.FileInfo> m_PackFileInfoList;

	public bool CotainRecommend;

	public bool isRecommend;

	public float DownloadedSize;

	public long TotalSize;

	public float TotalZipSize;

	public uint CategoryType;

	public bool HideAfterDownload;

	public bool HideInLogin;

	public bool CanDownload;

	public bool ForceDownload;

	public EDownloadContextMode DownloadStateMode;

	public bool NeedAddToPendingAfterDownloadSingle;

	private UIModelOptionalDownload m_Model;

	public List<ResVersionInfo.FileInfo> Cur_DownloadingSingelFileInfos;

	public bool IsAutoDownload;

	public bool NotAutoDownloadOldResource;

	public uint HotSort;

	public int DownloadSort;

	public float DeletedDownloadedSize;

	public List<string> RefWorkshopMaps;

	private HashSet<ResVersionInfo.FileInfo> m_WorkshopMapFileInfos;

	private HashSet<uint> m_WorkshopMapResTypes;

	private Dictionary<ResUpdateDownloadContext, bool> m_WorkshopMapDownloadContexts;

	private Dictionary<ResUpdateDownloadContext, HashSet<ResVersionInfo.FileInfo>> m_WorkshopMapDownloadContextTagFileMaps;

	public EDownloadContextMode LastDownloadStateMode;

	public List<ResVersionInfo.FileInfo> NeedPauseDownloadingFileInfos;

	public bool IsNeedRestartDownload;

	public DownloadInfoSourceForm DownloadFrom;

	public bool IsShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<ResVersionInfo.FileInfo> PackFileInfoList => null;

	public void InitData()
	{
	}

	public float GetDownloadedSize()
	{
		return 0f;
	}

	public bool DownloadSingleFileFinished()
	{
		return false;
	}

	public bool DownloadFileFinished()
	{
		return false;
	}

	public bool IsDownloadAll()
	{
		return false;
	}

	public void InitDownloadForm(bool isMannual, EoptionalTagDownloadTypeEntry downloadEntry)
	{
	}

	public float GetDownloadProcess()
	{
		return 0f;
	}

	public float GetDownloadedDeleteProcress()
	{
		return 0f;
	}

	public void AddCurDownloadingFileInfos(ResVersionInfo.FileInfo[] fileinfos)
	{
	}

	public void ClearCurDownloadingFileInfos()
	{
	}

	public void AddFileInfoRange(List<ResVersionInfo.FileInfo> file_InfoList)
	{
	}

	public void AddFileInfo(ResVersionInfo.FileInfo fileInfo, bool isWorkshopMapFile)
	{
	}

	public void RemoveFileInfoRange(List<ResVersionInfo.FileInfo> file_InfoList, uint tag)
	{
	}

	public void RemoveFileInfo(ResVersionInfo.FileInfo fileInfo)
	{
	}

	public void AddDownloadType(ResDownloadType resDownloadType, bool isWorkshopMapFile)
	{
	}

	public void SetPackFileInfoContent(List<ResVersionInfo.FileInfo> fileInfoList)
	{
	}

	public float GetStillNeedDownloadSize()
	{
		return 0f;
	}

	public void RecordDownloadedSizeForDelete()
	{
	}

	public float NewGetDownloadedSize()
	{
		return 0f;
	}

	public float NewGetStillNeedDownloadSize()
	{
		return 0f;
	}

	public void ClearWorkshopMapResRef()
	{
	}
}
