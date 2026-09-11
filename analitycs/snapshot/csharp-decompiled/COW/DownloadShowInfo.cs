using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class DownloadShowInfo
{
	public DownloadShowStyle style;

	public Action onClickCommon;

	public List<ResourceID> downloadlist;

	public List<string> UGCCustomResDownloadList;

	public UGCSimpleDownloadTask UGCDownloadTask;

	public bool onlyShowIcon;

	public bool NotShowDownloadTxt;

	public bool DoNotCheck;

	public int DelayShow;

	public bool EnableDragScroll;

	public bool BigEventTemplate;

	public bool ChangeIcon;

	public uint MapConfigID;

	public string CustomStyle1PreDownloadTxt;

	public string DownloadingTxt;

	public ResDownloadType ResType;

	public UIModelOptionalDownload.EOptionalLobbyResType LobbyResType;

	public uint ResAbId;

	public bool IsInGame;

	public uint OptionalDownloadResDefID;

	public DownloadShowInfo()
	{
	}

	public DownloadShowInfo(DownloadShowStyle style, Action onClickCommon, List<ResourceID> downloadlist, bool onlyShowIcon = false, bool changeIcon = false, string downloadingTxt = "", bool enableDragScroll = false, bool inGame = false)
	{
	}

	public DownloadShowInfo(DownloadShowStyle style, ResDownloadType resType, UIModelOptionalDownload.EOptionalLobbyResType lobbyResType = UIModelOptionalDownload.EOptionalLobbyResType.None, uint resAbId = 0u, bool onlyShowIcon = false, bool doNotCheck = false, int delayShow = 0, Action onClickCommon = null, bool enableDragScroll = false, bool isTemplateBigEvent = false, bool changeIcon = false, uint mapConfigId = 0u)
	{
	}

	public DownloadShowInfo(DownloadShowStyle style, Action onClickCommon, UGCSimpleDownloadTask downloadTask, bool onlyShowIcon = false, bool changeIcon = false, string downloadingTxt = "", bool enableDragScroll = false, bool inGame = false)
	{
	}
}
