using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCDownloadInfo
{
	private static uint IdCounter;

	private uint _003CId_003Ek__BackingField;

	public Action<int> Callback;

	public List<UGCDownloadResourceInfo> DownloadResourceInfos;

	public uint Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		private set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	private static uint GetNewId()
	{
		return 0u;
	}

	public void Clear()
	{
	}

	public List<UGCDownloadResourceInfo> CollectRepeatedResourceInfos(UGCDownloadResourceInfo downloadResourceInfo)
	{
		return null;
	}

	public UGCDownloadResourceInfo CheckDownloadingByOther(UGCDownloadResourceInfo downloadResourceInfo)
	{
		return null;
	}
}
