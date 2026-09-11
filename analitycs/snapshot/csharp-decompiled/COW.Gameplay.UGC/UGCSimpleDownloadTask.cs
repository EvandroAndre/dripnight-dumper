using System.Collections.Generic;
using GCommon;

namespace COW.Gameplay.UGC;

public class UGCSimpleDownloadTask
{
	public string Url;

	public string ShareCode;

	public UGCResInfo ResInfo;

	public List<UGCResInfo> ResInfos;

	public bool IsDownloadInGame;

	public UGCOptionalResConfigData.EUGCOptionalResDownloadType DownloadNecessaryResType;

	public HashSet<ResourceID> AdditionalOptionalResIds;

	public List<ResourceID> OptionalResIds;

	public List<string> CustomResNames;

	public List<ResVersionInfo.FileInfo> ResFileInfos;

	public List<ResVersionInfo.FileInfo> MainResFileInfos;

	public List<ResVersionInfo.FileInfo> DLCResFileInfos;

	public List<ResVersionInfo.FileInfo> CustomResFileInfos;

	public uint MapConfigID;

	public EUGCMatchMode MatchMode;

	public bool IsCustomTag;

	public uint TagTypeId;

	public string WorkshopCode;

	public bool NeedLog;

	public string Purpose;

	public UGCSimpleDownloadTask(bool isDownloadInGame, UGCOptionalResConfigData.EUGCOptionalResDownloadType downloadNecessaryResType, string purpose = "")
	{
	}

	public bool IsEmpty()
	{
		return false;
	}
}
