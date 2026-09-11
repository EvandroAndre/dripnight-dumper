using System;
using System.Collections;
using System.Collections.Generic;
using TsiU;
using UnityEngine;
using UnityEngine.Networking;
using message;

namespace COW.Gameplay.UGC;

public class UGCResourceForGameData : TSingleton<UGCResourceForGameData>
{
	public enum EPackageOrABType
	{
		assetbundle,
		package,
		binary,
		gamedata
	}

	public enum EVFSFileType
	{
		None,
		LocalFile,
		Memory
	}

	public class PackageOrABFileInfo
	{
		public enum EDownloadStatus
		{
			prepare,
			downloading,
			downloadFailed,
			downloaded
		}

		public EPackageOrABType FileType;

		public string DownloadUrl;

		public string LocalUrl;

		public string VersionOrMD5;

		public string UUID;

		public bool IsNeedLoadData;

		public byte[] DownloadedData;

		public EDownloadStatus DownloadStatus;

		public int GuessFileSize;

		public string SHA1;

		public int DownloadPriority;

		public EVFSFileType IsVFSFile;
	}

	private class LoadedPackageInfo
	{
		public string UUID;

		public string CorrectedUUID;

		public int Version;

		public List<string> MappingABPathList;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BCEMGIAPCNA> _003C_003E9__21_0;

		internal int _003CParserDownloadFileList_003Eb__21_0(BCEMGIAPCNA a, BCEMGIAPCNA b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public List<PackageOrABFileInfo> fileList;

		public Action<int> callback;
	}

	private sealed class _003C_003Ec__DisplayClass49_1
	{
		public PackageOrABFileInfo p;

		public string realUrl;

		public _003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals1;

		internal void _003CSimulateDownloadEngine_003Eb__0(string url, byte[] data)
		{
		}
	}

	private sealed class _003CSimulateDownloadOneFile_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<string, byte[]> callback;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSimulateDownloadOneFile_003Ed__50(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private List<PackageOrABFileInfo> m_gameDataFileList;

	private List<PackageOrABFileInfo> m_firstNeedFileList;

	private List<PackageOrABFileInfo> m_secondNeedFileList;

	private IAJBFCOJONG m_cacheGameDataPackageInfo;

	private PDNPIMFAGEN m_cacheDownloadDesc;

	private MonoBehaviour MonoRoot;

	private bool m_isLoading;

	private bool m_isLoadToResourceManager;

	private Action<int> m_allPreparedCallback;

	private static string _hd_endfix;

	private Dictionary<string, string> ABInfo2Sha1;

	private List<LoadedPackageInfo> m_loadedPackageInfoList;

	public static string FabUUID_StdLibrary;

	public static string Fab_StdLibraryFile;

	public bool IsLoading
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Init(MonoBehaviour coroutinueRoot, bool enableResourceChangeNotify = true)
	{
	}

	private void CallAllPreparedCallback(int code)
	{
	}

	public UGCResourceForGameData(bool isDisableLoadToResourceManager)
	{
	}

	public UGCResourceForGameData()
	{
	}

	private static bool SkipForHD(CPFJPDBMDMP fileDesc, BCEMGIAPCNA packageDesc, out string mappingPath)
	{
		mappingPath = null;
		return false;
	}

	public static void ParserDownloadFileList(PDNPIMFAGEN downloadDescList, bool downloadNotNecessaryFileWithMap, List<PackageOrABFileInfo> outNeedDownloadFileList, List<List<PackageOrABFileInfo>> outNeedDownloadNotNecessaryFileList)
	{
	}

	private void Clear()
	{
	}

	public static void Cleanup()
	{
	}

	public void LoadFromGameDataWithDeserializedData(GNHAFLDPNJI resContentData, PDNPIMFAGEN downloadDesc, Action<int> callback)
	{
	}

	private CPFJPDBMDMP GetDownloadFileDesc(BCEMGIAPCNA packageDesc, string subfileID)
	{
		return null;
	}

	public void LoadFromGameData(IAJBFCOJONG gameDataPackageInfo, PDNPIMFAGEN downloadDescList, Action<int> callback = null)
	{
	}

	private void AddUnityAssetBundleNeed(JBBDIJHHPLK package, BCEMGIAPCNA packageDesc, List<PackageOrABFileInfo> targetList, List<PackageOrABFileInfo> abFileInfos = null)
	{
	}

	private BCEMGIAPCNA GetDownloadDesc(PDNPIMFAGEN gameDataPackageInfo, string uuid)
	{
		return null;
	}

	public void OnPackageDownloaded(string packageUUID, string localFile, byte[] fileData, List<PackageOrABFileInfo> abFileInfos = null)
	{
	}

	private void OnFirstDownloaded(int code)
	{
	}

	private void OnAllFileDownloaded(int code)
	{
	}

	public PackageOrABFileInfo GetDownloadedFileInfo(string UUID, string versionOrSha1)
	{
		return null;
	}

	public PackageOrABFileInfo GetDownloadedFileInfoBySHA1(string UUID, string sha1)
	{
		return null;
	}

	public void LoadToResourceManager()
	{
	}

	public void LoadOnePackageToResourceManager(PackageOrABFileInfo packageFileInfo)
	{
	}

	public void LoadOnePackageToResourceManager(JBBDIJHHPLK packageData)
	{
	}

	private LoadedPackageInfo GetLoadedPackageInfo(string UUID)
	{
		return null;
	}

	private static bool HackedIsStdLibraryPackage(JBBDIJHHPLK packageData)
	{
		return false;
	}

	private static bool isVersionControlPackage(BCEMGIAPCNA desc, out string retUUID)
	{
		retUUID = null;
		return false;
	}

	private void LoadPackageImpl(JBBDIJHHPLK packageData, string localFilePath)
	{
	}

	private void UnloadMappingAssetBundle(LoadedPackageInfo loadedPackageInfo)
	{
	}

	private void AutoMappingAssetBundleLocalPathInternal(string packageUUID, JBBDIJHHPLK packageData, LoadedPackageInfo loadedPackageInfo)
	{
	}

	private void SubmitToDownloadEngine(List<PackageOrABFileInfo> fileList, bool isCallbackWhenPackageDownloaded, Action<int> callback)
	{
	}

	private void SimulateDownloadEngine(List<PackageOrABFileInfo> fileList, bool isCallbackWhenPackageDownloaded, Action<int> callback)
	{
	}

	private IEnumerator SimulateDownloadOneFile(string url, Action<string, byte[]> callback)
	{
		return null;
	}
}
