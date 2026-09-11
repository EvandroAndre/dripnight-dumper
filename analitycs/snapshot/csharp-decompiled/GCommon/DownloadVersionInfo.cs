using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GCommon;

public class DownloadVersionInfo
{
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public ResUpdateDownloadContext update_context;

		public Action<bool> onVersionInfoLoaded;

		public DownloadVersionInfo _003C_003E4__this;

		internal void _003CLoadVersionInfo_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}

		internal void _003CLoadVersionInfo_003Eb__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public ResUpdateDownloadContext downloadContext;

		public DownloadVersionInfo _003C_003E4__this;

		public Action<bool> onFileInfoLoaded;

		internal void _003CLoadFileInfo_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}

		internal void _003CLoadFileInfo_003Eb__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	protected bool m_IsRemote;

	public bool m_UsedOld;

	public uint Version;

	public int FileInfoRow;

	public uint EtcVersion;

	public uint AstcVersion;

	public bool NeedUpdate;

	public bool LocalFileInfoError;

	public bool FileInfoWasEncrypted;

	public EDownloadPackState PackState;

	public HashSet<int> FileTypeList;

	protected Dictionary<string, ResVersionInfo.FileInfo> m_FileInfos;

	private List<ResVersionInfo.FileInfo> m_TempFileInfoList;

	protected List<ResVersionInfo.FileInfo> m_NeedToSaveFileInfos;

	protected HashSet<string> m_DepFiles;

	protected Dictionary<uint, List<ResVersionInfo.FileInfo>> m_TagFileInfoMap;

	protected bool m_CanSaveFilesStateWithoutFiles;

	protected ResDownloadType ShowResDownloadType;

	private bool m_HaveLoadedLocalFileInfo;

	private bool m_EnableLoadLocalFileinfoCacheOnce;

	protected bool m_EnableParseFileOptimize;

	protected bool m_EnableSaveFileinfoOptimize;

	protected int m_ParseLinePresetLength;

	public static uint AstcTypeOffset;

	public static int ErrorFormatStrDebugLen;

	protected bool m_EnableDownloadVersionLocalFileinfoOptimize;

	private MutableString m_sbLine;

	private MutableString m_sbDetailInfo;

	private StringBuilder m_FormatString;

	private char[] m_WriteToFileCharArray;

	private byte[] m_TransferCharToBytes;

	public DownloadVersionInfo(bool isRemote, ResDownloadType download_type, bool canSaveFilesWithoutFiles = false)
	{
	}

	public void LoadVersionInfo(ResUpdateDownloadContext update_context, string versionInfoPath, Action<bool> onVersionInfoLoaded)
	{
	}

	public void LoadFromString(ResUpdateDownloadContext downloadContext, string version_string, bool from_remote = false)
	{
	}

	protected bool ParseVersion(string content, ref uint _version)
	{
		return false;
	}

	public void LoadFileInfo(ResUpdateDownloadContext downloadContext, string fileInfoPath, Action<bool> onFileInfoLoaded)
	{
	}

	protected bool LoadLocalFileInfo_Optimize(ResUpdateDownloadContext downloadContext)
	{
		return false;
	}

	protected bool LoadLocalFileInfo_Normal(ResUpdateDownloadContext downloadContext)
	{
		return false;
	}

	protected bool TryReadEncryptedFileInfo(string cachedFileInfoFile, ResUpdateDownloadContext downloadContext, out string content)
	{
		content = null;
		return false;
	}

	protected bool ShouldEncryptFileInfo(ResUpdateDownloadContext downloadContext)
	{
		return false;
	}

	protected bool TryWriteEncryptedFileInfo(string cachedFileInfoFile, string content, ResUpdateDownloadContext downloadContext)
	{
		return false;
	}

	public bool LoadLocalFileInfo(ResUpdateDownloadContext downloadContext)
	{
		return false;
	}

	protected bool ParseFile_Normal(string content, bool from_local = false)
	{
		return false;
	}

	protected virtual void ParseFileNormalExtra(ResVersionInfo.FileInfo fileInfo, string[] items)
	{
	}

	protected bool ParseFile_Optimize(string content, bool from_local = false)
	{
		return false;
	}

	protected void ProcessDetailLineInFileInfo(string content, bool from_local)
	{
	}

	private bool processFileinfo(ResVersionInfo.FileInfo fileinfo, MutableString infoStr, uint index)
	{
		return false;
	}

	protected virtual bool ProcessFileInfoExtra(ResVersionInfo.FileInfo fileInfo, MutableString infoStr, uint index)
	{
		return false;
	}

	protected virtual bool ParseFile(string content, bool from_local = false)
	{
		return false;
	}

	public string GetVersionString()
	{
		return null;
	}

	public static bool HaveEnoughStorage()
	{
		return false;
	}

	public virtual Dictionary<string, ResVersionInfo.FileInfo> GetFileInfoList()
	{
		return null;
	}

	public HashSet<string> GetDepFileNames()
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> FrequentlyGetDownloadFileInfoList(bool forceUpdate = false)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetNeedDownloadFileInfo()
	{
		return null;
	}

	public void ClearVersion()
	{
	}

	public virtual void ClearFileInfoList()
	{
	}

	public void ClearFileInfos()
	{
	}

	public void ClearFilesState(List<string> fileInfoNames)
	{
	}

	public virtual bool FindFileInfo(string fullName, out ResVersionInfo.FileInfo result)
	{
		result = null;
		return false;
	}

	public void AddFileInfo(ResVersionInfo.FileInfo fileInfo)
	{
	}

	public void AddTagFilePair(uint tag, List<ResVersionInfo.FileInfo> fileInfo_List)
	{
	}

	public void AddTagFilePair(uint tag, ResVersionInfo.FileInfo fileInfo)
	{
	}

	public void RemoveTagFilePair(uint tag, ResVersionInfo.FileInfo fileInfo)
	{
	}

	public virtual ResErrorCode SaveFileInfo(ResUpdateDownloadContext context)
	{
		return ResErrorCode.OK;
	}

	public ResErrorCode SaveFileInfo_Old(ResUpdateDownloadContext context)
	{
		return ResErrorCode.OK;
	}

	protected virtual string FileInfoToString(ResVersionInfo.FileInfo fileInfo)
	{
		return null;
	}

	public ResErrorCode SaveFileInfo_Optimize(ResUpdateDownloadContext context)
	{
		return ResErrorCode.OK;
	}

	protected virtual void FileInfoToStringBuilder(ResVersionInfo.FileInfo fileInfo, ref StringBuilder sb)
	{
	}

	protected void FileInfoToStringBuilderCommon(ResVersionInfo.FileInfo fileInfo, ref StringBuilder sb)
	{
	}

	public ResErrorCode SaveVersionInfo(ResUpdateDownloadContext context)
	{
		return ResErrorCode.OK;
	}

	public ResErrorCode Save(ResUpdateDownloadContext context)
	{
		return ResErrorCode.OK;
	}

	public void SetNewFileInfos(Dictionary<string, ResVersionInfo.FileInfo> fileinfoDict)
	{
	}
}
