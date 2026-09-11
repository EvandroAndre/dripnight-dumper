using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GCommon;

public class ResVersionInfo
{
	public class FileInfo
	{
		public enum OpState
		{
			Local,
			Download,
			Cache,
			CacheUnzipped
		}

		public string FullName;

		public string m_Hash;

		private string m_ZipHash;

		public long Size;

		public long ZipSize;

		public OpState State;

		public bool IsCompressed;

		public ResFileType FileType;

		public bool IsInSingleList;

		public bool IsRecommendFile;

		public List<uint> BelongTagList;

		public long HaveDownloadedSize;

		public bool IsOldResourceFile;

		public bool IsASTC;

		public string AstcHash;

		public string AstcZipHash;

		public long AstcSize;

		public long AstcZipSize;

		public string DateInfo;

		public bool isFormLocalAssetBundle;

		private string m_CDNExt;

		private string m_UnzipExt;

		public string Hash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ZipHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Print()
		{
			return null;
		}

		public FileInfo Clone()
		{
			return null;
		}

		public string GetFullNameWithCDNExt(bool need_cache = true)
		{
			return null;
		}

		public string GetFullNameWithUnzipExt(bool need_cache = true)
		{
			return null;
		}

		public void AddFileBelongTag(uint tag)
		{
		}

		public void RemoveFileBelongTag(uint tag)
		{
		}

		public void ClearTagTable(uint tag)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public ResHotUpdater updaterInst;

		public DownloadContext download_context;

		public ResVersionInfo _003C_003E4__this;

		public string releaseVersion;

		public Action<bool> onVersionInfoLoaded;

		internal void _003CLoad_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}

		internal void _003CLoad_003Eb__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public ResVersionInfo _003C_003E4__this;

		public ResHotUpdater updaterInst;

		public DownloadContext download_context;

		public Action<bool> forceUpdateErrorCallBack;

		public Action<bool> onFileInfoLoaded;

		internal void _003CLoadFileInfo_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}

		internal void _003CLoadFileInfo_003Eb__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public ResFileType fileType;

		internal bool _003CParseFile_003Eb__0(int element)
		{
			return false;
		}
	}

	public uint MajorVersion;

	public uint MinorVersion;

	public uint EmbedMajorVersion;

	public uint EmbedMinorVersion;

	public uint OptionalVersion;

	private bool m_IsRemote;

	private bool m_IsUsingEmbed;

	private bool m_EnableABHotUpdatesOptimize;

	private bool m_EnableSaveFileOptimize;

	private ResFileType m_MaxSkipType;

	private Dictionary<string, FileInfo> m_FileInfos;

	private Dictionary<int, Dictionary<string, FileInfo>> m_FileInfoListMapWithType;

	private Dictionary<int, long> m_StoredFileSizeMapWithType;

	private StringBuilder m_StringFormatBuilder;

	private char[] m_WriteToFileArray;

	private byte[] m_TransferCharToByte;

	public ResVersionInfo(bool isRemote, bool saveFileOptimize)
	{
	}

	public void SetEnabelHotUpdateOptimize(bool enableOptimize)
	{
	}

	public void LoadFromString(DownloadContext downloadContext, ResHotUpdater updaterInst, string removeVersion, string releaseVersion)
	{
	}

	public void Load(ResHotUpdater updaterInst, string versionInfoPath, Action<bool> onVersionInfoLoaded, string releaseVersion)
	{
	}

	public void LoadFileInfo(ResHotUpdater updaterInst, string fileInfoPath, Action<bool> onFileInfoLoaded, Action<bool> forceUpdateErrorCallBack = null)
	{
	}

	public bool LoadLocalFileInfo(ResHotUpdater updaterInst, int[] targetFileType = null)
	{
		return false;
	}

	public string GetVersionString()
	{
		return null;
	}

	public string GetOptionVersionString()
	{
		return null;
	}

	public Dictionary<string, FileInfo> GetFileInfoListWithType(ResFileType fileType)
	{
		return null;
	}

	public void AddFileInfo(FileInfo fileInfo)
	{
	}

	public bool FindFileInfo(string fullName, out FileInfo result)
	{
		result = null;
		return false;
	}

	private bool HaveEnoughStorage()
	{
		return false;
	}

	public ResErrorCode SaveFileInfo(ResHotUpdaterContext context)
	{
		return ResErrorCode.OK;
	}

	public ResErrorCode SaveFilleInfo_Old(ResHotUpdaterContext context)
	{
		return ResErrorCode.OK;
	}

	public ResErrorCode SaveFileinfo_Optimize(ResHotUpdaterContext context)
	{
		return ResErrorCode.OK;
	}

	public ResErrorCode SaveVersionInfo(ResHotUpdaterContext context, ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return ResErrorCode.OK;
	}

	public ResErrorCode Save(ResHotUpdater updaterInst, ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return ResErrorCode.OK;
	}

	private bool ParseVersion(string content, ref uint majorVersion, ref uint minorVersion, ref uint optionalVersion)
	{
		return false;
	}

	public Dictionary<string, FileInfo> GetFileInfos()
	{
		return null;
	}

	private bool ParseFile(string content, int[] targetFileTypes = null, bool from_local = false, bool from_localAssetBundle = false)
	{
		return false;
	}

	public long GetStoredFileSize(ResFileType type)
	{
		return 0L;
	}
}
