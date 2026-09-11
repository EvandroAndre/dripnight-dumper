using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine.Networking;

namespace COW.Gameplay.UGC;

public class UGCResUpdateDownloadContext : ResUpdateDownloadContext
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string fileName;

		internal bool _003CDeleteFilesCache_003Eb__0(ResVersionInfo.FileInfo a)
		{
			return false;
		}
	}

	public const uint UGC_CUSTOM_RES_RE_DEF_ID = 999u;

	public const uint UGC_CUSTOM_RES_RE_DEF_ID_SHORTTIME = 998u;

	public const uint UGC_CUSTOM_RES_RE_DEF_ID_LONGTIME = 997u;

	public const uint UGC_CUSTOM_RES_TAB_ID = 9u;

	private UGCDownloadVersionInfo m_UGCLocalVersionInfo;

	public static bool IsUGCCustomResOptionalID(uint id)
	{
		return false;
	}

	public UGCResUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously, bool savefilesWithouFiles = false)
		: base(null, ResDownloadType.None, 0)
	{
	}

	public override void StartGetLocalVersion(Action<ResDownloadType> on_version_check_finished = null)
	{
	}

	protected void OnFileInfoLoaded(bool result)
	{
	}

	public override void InitLocalFileInfoState()
	{
	}

	public override void BigFileDownload(ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded, bool addLoaderFirst = false)
	{
	}

	public void RegisterFileInfo(List<ResVersionInfo.FileInfo> fileInfos)
	{
	}

	public void UpdateAddFileInfo()
	{
	}

	private void RemoveLocalFileInfo(ResVersionInfo.FileInfo fileInfo)
	{
	}

	public void RemoveTagFilesPair(uint tag, ResVersionInfo.FileInfo fileInfo, bool updateToDeleted)
	{
	}

	protected override string GetFileRelativePath(ResVersionInfo.FileInfo fileInfo)
	{
		return null;
	}

	public override string GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo fileInfo, ResVersionInfo.FileInfo.OpState targetState, bool need_cache = true)
	{
		return null;
	}

	protected override void DeleteFilesCache(List<ResVersionInfo.FileInfo> needDeleteFiles)
	{
	}

	private void UpdateFileInfoForDelete(ResVersionInfo.FileInfo fileInfo)
	{
	}

	protected override void SaveLocalVersionInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_StartGetLocalVersion(Action<ResDownloadType> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitLocalFileInfoState()
	{
	}

	public void _003C_003EiFixBaseProxy_BigFileDownload(ResVersionInfo.FileInfo P0, string P1, Action<UnityWebRequest, ResWithTempFileLoader> P2, bool P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetFileRelativePath(ResVersionInfo.FileInfo P0)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo P0, ResVersionInfo.FileInfo.OpState P1, bool P2)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeleteFilesCache(List<ResVersionInfo.FileInfo> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SaveLocalVersionInfo()
	{
	}
}
