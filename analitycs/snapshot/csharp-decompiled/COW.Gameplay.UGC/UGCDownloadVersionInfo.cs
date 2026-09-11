using System.Collections.Generic;
using System.Text;
using GCommon;

namespace COW.Gameplay.UGC;

public class UGCDownloadVersionInfo : DownloadVersionInfo
{
	protected Dictionary<string, ResVersionInfo.FileInfo> m_TempFileInfosToAdd;

	protected Dictionary<string, ResVersionInfo.FileInfo> m_TempFullFileInfos;

	public UGCDownloadVersionInfo(bool isRemote, ResDownloadType download_type, bool isDynamicProduce = false, bool canSaveFilesWithoutFiles = false)
		: base(isRemote: false, ResDownloadType.None)
	{
	}

	public override Dictionary<string, ResVersionInfo.FileInfo> GetFileInfoList()
	{
		return null;
	}

	public override bool FindFileInfo(string fullName, out ResVersionInfo.FileInfo result)
	{
		result = null;
		return false;
	}

	public void RequestAddFileInfo(List<ResVersionInfo.FileInfo> fileInfos)
	{
	}

	protected override string FileInfoToString(ResVersionInfo.FileInfo fileInfo)
	{
		return null;
	}

	protected override void FileInfoToStringBuilder(ResVersionInfo.FileInfo fileInfo, ref StringBuilder sb)
	{
	}

	protected override bool ProcessFileInfoExtra(ResVersionInfo.FileInfo fileInfo, MutableString infoStr, uint index)
	{
		return false;
	}

	protected override void ParseFileNormalExtra(ResVersionInfo.FileInfo fileInfo, string[] items)
	{
	}

	public void UpdateAddFileInfo()
	{
	}

	public void RemoveFileInfo(ResVersionInfo.FileInfo fileInfo)
	{
	}

	public void RemoveNotReadyFileInfos(string filePath)
	{
	}

	public new void RemoveTagFilePair(uint tag, ResVersionInfo.FileInfo fileInfo)
	{
	}

	public Dictionary<string, ResVersionInfo.FileInfo> _003C_003EiFixBaseProxy_GetFileInfoList()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_FindFileInfo(string P0, out ResVersionInfo.FileInfo P1)
	{
		P1 = null;
		return false;
	}

	public string _003C_003EiFixBaseProxy_FileInfoToString(ResVersionInfo.FileInfo P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_FileInfoToStringBuilder(ResVersionInfo.FileInfo P0, ref StringBuilder P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_ProcessFileInfoExtra(ResVersionInfo.FileInfo P0, MutableString P1, uint P2)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseFileNormalExtra(ResVersionInfo.FileInfo P0, string[] P1)
	{
	}
}
