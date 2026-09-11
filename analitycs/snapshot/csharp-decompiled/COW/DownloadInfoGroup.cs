using System.Collections.Generic;
using GCommon;

namespace COW;

public class DownloadInfoGroup
{
	public uint optionalReDefTypeId;

	public EDownloadContextState ShowState;

	public List<TagDownloadInfo> downloadInfoList;

	public bool CotainRecommend;

	public float downloadedSize;

	public float TotalSize;

	public float TotalZipSize;

	public int DownloadedCount;

	public int TotalCount;

	public void InitData()
	{
	}

	public float GetDownloadedSize()
	{
		return 0f;
	}

	public float GetDeletedStateDownloadedSize()
	{
		return 0f;
	}

	public float GetTotalZipSize()
	{
		return 0f;
	}

	public static EDownloadContextState GetShowPriorityState(EDownloadContextState currentState, EDownloadContextState itemState)
	{
		return EDownloadContextState.None;
	}
}
