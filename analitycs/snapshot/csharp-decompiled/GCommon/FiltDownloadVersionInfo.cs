using System.Collections.Generic;

namespace GCommon;

public class FiltDownloadVersionInfo : DownloadVersionInfo
{
	private Dictionary<string, ResVersionInfo.FileInfo> m_NoFiltFileInfos;

	public FiltDownloadVersionInfo(bool isRemote, ResDownloadType download_type)
		: base(isRemote: false, ResDownloadType.None)
	{
	}

	protected override bool ParseFile(string content, bool from_local = false)
	{
		return false;
	}

	public override ResErrorCode SaveFileInfo(ResUpdateDownloadContext context)
	{
		return ResErrorCode.OK;
	}

	public override void ClearFileInfoList()
	{
	}

	public Dictionary<string, ResVersionInfo.FileInfo> GetNoFiltInfoList()
	{
		return null;
	}

	public void AddPrefiltFileInfo(ResVersionInfo.FileInfo fileInfo)
	{
	}

	protected virtual string[] FiltFifleInfo(string content)
	{
		return null;
	}

	private void GeneratePreFiltFileInfo(string content, bool from_local = false)
	{
	}

	public bool FindNoFiltFileInfo(string fullName, out ResVersionInfo.FileInfo result)
	{
		result = null;
		return false;
	}
}
