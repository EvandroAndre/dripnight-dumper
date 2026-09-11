using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon;

public class NetworkDownloadEngine : MonoBehaviour
{
	public class DownloadTextureInfo
	{
		public string Url;

		public string Name;

		public bool NeedCache;

		public Vector2 TragetSize;

		public ETextureInfoFormat ReqTextureFormat;

		public ETextureInfoDownloadType DownloadType;

		public bool IsReadable;

		public uint EndTime;

		public bool ReleaseTextureAfterLoad;

		public bool IsCDNIcon;

		public ETextureUsageType TextureUsageType;

		public ETextureType FFType;

		public double downloadCDNTimeDetal;

		public int DownloadCDNSize;

		private double dateTimeBegin;

		public int downloadFailType;

		public string downloadFailReason;

		public long WwwResponseCode;

		public bool LoadTextureImmediately;

		public Coroutine RunningCoroutine;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void RecordTextureDownloadBeginTime()
		{
		}

		public void RecordTextureDownloadFinished(uint responseCode)
		{
		}

		public void SetTextureDownloadFailedInfo(int fail_type, string fail_reason)
		{
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}
	}

	public delegate void OnDowloadFinished(ResultTextureInfo texture);

	public delegate void OnDownloadFailed(CDNDownloadFailedInfo info);

	private class CNDDownloadHanlder : DownloadHandlerScript
	{
		private const int MEM_POOL_MAX_SIZE = 5;

		private static Queue<IntPtr> REUSED_MEM_POOL;

		private IntPtr download_data;

		private IntPtr managed_download_data;

		private int download_size;

		public static void ClearMemoryCache()
		{
		}

		public void ClearMemoryData()
		{
		}

		protected override byte[] GetData()
		{
			return null;
		}

		public void GetMemoryData(out IntPtr out_mem, out int size)
		{
			out_mem = default(IntPtr);
			size = default(int);
		}

		protected override bool ReceiveData(byte[] remote_data, int dataLength)
		{
			return false;
		}

		public byte[] _003C_003EiFixBaseProxy_GetData()
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_ReceiveData(byte[] P0, int P1)
		{
			return false;
		}
	}

	private sealed class _003CDownloadImage_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDownloadEngine _003C_003E4__this;

		public DownloadTextureInfo info;

		private UnityWebRequest _003Cwww_003E5__2;

		private DownloadHandlerBuffer _003CtexDl_003E5__3;

		private byte[] _003CtexData_003E5__4;

		private string _003CfileFolderPath_003E5__5;

		private string _003CbZipFolderPath_003E5__6;

		private WWW _003Cwww_o_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownloadImage_003Ed__104(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDownloadImage_Optimized_003Ed__134 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDownloadEngine _003C_003E4__this;

		public DownloadTextureInfo info;

		private UnityWebRequest _003Cwww_003E5__2;

		private CNDDownloadHanlder _003CtexDl_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDownloadImage_Optimized_003Ed__134(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CLoadLocalImage_003Ed__127 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDownloadEngine _003C_003E4__this;

		public DownloadTextureInfo info;

		private string _003CfilePath_003E5__2;

		private WWW _003Cwww_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadLocalImage_003Ed__127(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CLoadLocalImage_Optimized_003Ed__135 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDownloadEngine _003C_003E4__this;

		public DownloadTextureInfo info;

		private string _003CfilePath_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

		private CNDDownloadHanlder _003CtexDl_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadLocalImage_Optimized_003Ed__135(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	public static string CDNAddr;

	public static bool OpenCDNDownloadSupportAstc;

	public static uint LoadImmediatelyTimeout;

	public static int DefaultTextureSize;

	protected const long HTTP_OK = 200L;

	protected const long HTTP_PartialOK = 206L;

	private static NetworkDownloadEngine _instance;

	private static int MAX_TEXTURE_SIZE;

	private const int MAX_TEXTURE_SIZE_MB = 1048576;

	private static int MAX_DATA_SIZE;

	private const int KTX_HEADER_SIZE = 12;

	private const int PVR_HEADER_SIZE = 52;

	private const int ASTC_HEADER_SIZE = 16;

	private const int FF_TAIL_LENGTH = 8;

	public const string REGEX_TEXTURE_END = "\\.((png?$)|(jpg?$)|(ktx?$)|(pvr?$)|(astc?$))";

	public const string REGEX_PLATFORM_TEXTURE_SURFFIX = "\\.(ff)?$";

	public const string REGEX_PLATFORM_TEXTURE_SURFFIX_EXTEND = "\\.(ff_extend)?$";

	public const string REGEX_PLATFORM_TEXTURE_ZIP_SURFFIX = "\\.(zip)?$";

	public const string REGEX_PLATFORM_TEXTURE_LOBBY_SURFFIX = "\\.(lobby)?$";

	public const string REGEX_ABSOLUTE_URL_SURFFIX = "^((https://)|(http://))";

	public const string REGEX_TEXTURE_CONTAIN_FF = "(.*_ffsize_)(\\d+)_(\\d+)(.*)";

	public const string STR_TEXTURE_KTX_END = ".ktx";

	public const string STR_TEXTURE_ASTC_END = ".astc";

	public const string STR_TEXTURE_JPG_END = ".jpg";

	public const string STR_TEXTURE_PNG_END = ".png";

	public const string STR_TEXTURE_PVR_END = ".pvr";

	public const string STR_PLATFORM_TEXTURE_SURFFIX = ".ff";

	public const string STR_PLATFORM_TEXTURE_SURFFIX_EXTEND = ".ff_extend";

	public const string STR_PLATFORM_TEXTURE_ZIP_SURFFIX = ".zip";

	public const string STR_PLATFORM_TEXTURE_LOBBY_SURFFIX = ".lobby";

	public const string STR_ABSOLUTE_URL_HTTP_SURFFIX = "http";

	private string m_CurrentVersionFolder;

	private string ICONCDN_FLOADER;

	private const string IMAGECAHCE_FOLDER = "ImageCache";

	private const string PREF_KEY_CURRENTVERSIONFOLDER = "CurrentVersionFolder";

	private const string PREF_KEY_CDNTEXTURESTROAGE = "CDNTextureStroage";

	private const string ZIPCAHCE_FOLDER = "zip";

	public static int MAX_MULTI_DOWNLOAD;

	public static int MAX_MULTI_CDNICON_DOWNLOAD;

	public static int MAX_LOAD_CDN_NUM;

	public static int MAX_PRELOAD_NUM;

	public static int MIN_DOWNLOAD_CDN_SIZEBYTES;

	public const string DOWNLOADED_CDNIMAGE_CACHE_KEY = "DownloadedCDNImageCacheKey";

	private Dictionary<string, ResultTextureInfo> m_LoadedImageCache;

	private List<string> m_NeedRemoveFromCacheUrl;

	private const uint LOW_MEMORY_LEVEL = 0u;

	private Queue<DownloadTextureInfo> m_NeedDownloadUrls;

	private Queue<DownloadTextureInfo> m_NeedDownloadCDNICONUrls;

	private Queue<DownloadTextureInfo> m_NeedPreDownloadCDNIconUrls;

	private Queue<DownloadTextureInfo> m_NeedLoadUrls;

	private HashSet<DownloadTextureInfo> m_RunningDownloadUrls;

	private static bool m_CDNSupportASTC;

	private int m_DownloadRecordNum;

	private int m_DownloadCDNRecordNum;

	private int m_LoadRecordNum;

	private int m_PreLoadRecordNum;

	private string image_CachePath;

	private string image_ZipCachePath;

	private string image_Icon_CachePath;

	private static readonly ulong PTR_SIZE_2;

	private static readonly ulong PTR_SIZE_3;

	private static readonly ulong PTR_SIZE_4;

	private byte[] GIF_FILE_HEAD;

	private Dictionary<string, List<OnDowloadFinished>> m_DownloadCallbackDictionary;

	private Dictionary<string, List<OnDownloadFailed>> m_DownloadFailCallbackDictionary;

	private static readonly int[] PNG_HEADER;

	private static readonly int[] KTX_HEADER;

	private static readonly int[] ASTC_HEADER;

	private static readonly int[] PVR_HEADER;

	private static byte[] ShortPaddingBuffer;

	private static byte[] m_WriteFileBuffer;

	private List<OnDowloadFinished> m_DownloadFinishedTempCallBackList;

	public static NetworkDownloadEngine Instance => null;

	public string ImageCachePath => null;

	public string ImageIconCDNCachePath => null;

	public string ImageZipCachePath => null;

	private void Init()
	{
	}

	public void InitGamvarDef(float androidCDNTextureStroage, float iosCDNTextureStroage)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void GenerateCurrentVersionFolder()
	{
	}

	public bool CheckImageLoadSuccess(string url, bool useOriginUrl = false, ETextureUsageType textureType = ETextureUsageType.None)
	{
		return false;
	}

	private void ClearCacheByVersion()
	{
	}

	public void ClearIconCDNCache()
	{
	}

	public void SetIconMAXDownloadNum(int num)
	{
	}

	private void DeleteCacheWalker(DirectoryInfo folderInfo)
	{
	}

	public string GetDownloadedImageFileName(string name)
	{
		return null;
	}

	public string GetDownloadedImageFileName(DownloadTextureInfo info)
	{
		return null;
	}

	public string GetModifyUrl(string url, ref ETextureInfoFormat format, bool useOrigin = false, ETextureUsageType textureType = ETextureUsageType.None)
	{
		return null;
	}

	public void RegisterDownloadTexture(string url, float targetWidth, float targetHeight, OnDowloadFinished finishedCallBack, bool needCache, OnDownloadFailed failedCallBack = null, bool isReadable = false, bool sameToLastUrl = false, uint endTime = uint.MaxValue, bool useOriginUrl = false, ETextureUsageType textureUsageType = ETextureUsageType.None, bool loadImmediately = false)
	{
	}

	public void RegisterDownloadTexture(DownloadTextureReqInfo reqInfo)
	{
	}

	private bool CheckUrlIsDownloading(string url)
	{
		return false;
	}

	public void DownloadMultiTextures(List<string> url_list, bool needCache = false, List<uint> end_timeList = null)
	{
	}

	public void DownloadMultiTextures(List<DownloadTextureInfo> downloadMutileInfos)
	{
	}

	public bool CheckUrlNeedDownload(string url, uint endTime = uint.MaxValue, bool useOrigin = false)
	{
		return false;
	}

	private bool CheckIsNeedDownload(string url, uint endTime = uint.MaxValue, bool isIconCDN = false)
	{
		return false;
	}

	private bool CheckIsNeedDownload(DownloadTextureInfo info)
	{
		return false;
	}

	public void UnRegisterCallBack(string url, OnDowloadFinished download_callback, bool useOriginalUrl, OnDownloadFailed download_failedCallBack = null, bool unRegisterInDestory = false, bool forceClear = false, bool releaseUnused = false, ETextureUsageType textureUsageType = ETextureUsageType.None)
	{
	}

	public void ReleaseUnuserCdnTexture(bool forceClear = false)
	{
	}

	private bool NeedClearCDN()
	{
		return false;
	}

	public void ClearImageTextureCache(EClearTextureCacheType type)
	{
	}

	private void StopCDNCoroutines(EClearTextureCacheType type)
	{
	}

	public void ClearLoadedTextureCache()
	{
	}

	public static void gunZipData(byte[] data, string filePath)
	{
	}

	private IEnumerator DownloadImage(DownloadTextureInfo info)
	{
		return null;
	}

	private bool CheckIsGIFFormat(byte[] data)
	{
		return false;
	}

	private string CreateFolderWithEndTimeAndPath(uint timeStamp, string cachePath)
	{
		return null;
	}

	private void DeleteDownloadedCDNImageCacheInfoData()
	{
	}

	private void DeleteDownloadedCDNImageCacheData()
	{
	}

	private TextureFormat CheckTextureFormatWithBytesAndUrl(byte[] bytes, DownloadTextureInfo info, out bool isPngOrJpeg)
	{
		isPngOrJpeg = default(bool);
		return (TextureFormat)0;
	}

	private bool CheckDataHeaderIsPvr(byte[] data)
	{
		return false;
	}

	private bool CheckDataHeaderIsPvr(IntPtr p, int data_size)
	{
		return false;
	}

	private TextureFormat CheckDataHeaderIsEtc(byte[] data)
	{
		return (TextureFormat)0;
	}

	private bool CheckHeaderDataisEtc(IntPtr p, int download_size)
	{
		return false;
	}

	private TextureFormat CheckDataHeadIsAstc(byte[] bytes)
	{
		return (TextureFormat)0;
	}

	private TextureFormat CheckDataHeadIsAstc(IntPtr p, int download_size)
	{
		return (TextureFormat)0;
	}

	private ResultTextureInfo CreateTexture2DWithByte(byte[] data, DownloadTextureInfo info)
	{
		return null;
	}

	private bool GetModifyTextureSizeForFF(string url, IntPtr shared_data, int download_size, int texture_size, ETextureType ffType, ETextureUsageType type, out int FFwidth, out int FFheight, out TextureSizeOtherInfo OtherInfo)
	{
		FFwidth = default(int);
		FFheight = default(int);
		OtherInfo = null;
		return false;
	}

	private int GetSharedShortDataInfoBySizeWithDataIndex(IntPtr shared_data, int data_size, int data_index)
	{
		return 0;
	}

	private bool GetModifyTextureSizeForFF(string url, byte[] data, int texture_size, ETextureType ffType, ETextureUsageType usageType, out int FFwidth, out int FFheight, out TextureSizeOtherInfo OtherInfo)
	{
		FFwidth = default(int);
		FFheight = default(int);
		OtherInfo = null;
		return false;
	}

	private int GetArrayShortDataInfoBySizeWithDataIndex(byte[] data, int data_index)
	{
		return 0;
	}

	public bool GetModifyTextureSizeForFFFromUrl(string url, out int width, out int height)
	{
		width = default(int);
		height = default(int);
		return false;
	}

	private IEnumerator LoadLocalImage(DownloadTextureInfo info)
	{
		return null;
	}

	private bool LoadLocalImage_Immediately(DownloadTextureInfo info)
	{
		return false;
	}

	private void NotifyTextureCreate(DownloadTextureInfo info, ResultTextureInfo textureInfo)
	{
	}

	private TextureFormat CheckTextureFormatWithPtrAndUrl(IntPtr bytes, int download_size, DownloadTextureInfo info, out bool isEffectiveRGB32)
	{
		isEffectiveRGB32 = default(bool);
		return (TextureFormat)0;
	}

	private ResultTextureInfo CreateTexture2DWithSharedData(IntPtr shared_data, int download_size, DownloadTextureInfo info)
	{
		return null;
	}

	private IEnumerator DownloadImage_Optimized(DownloadTextureInfo info)
	{
		return null;
	}

	private IEnumerator LoadLocalImage_Optimized(DownloadTextureInfo info)
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private void RemoveFromRuningDownloadQueue(DownloadTextureInfo info)
	{
	}

	public bool CheckUrlIsInLoadOrDownload(string url)
	{
		return false;
	}

	public static ETextureType CheckIsFFImageUrl(string url)
	{
		return ETextureType.None;
	}

	public static string CheckAndModifyUrlWithPlatFormSuffix(string url, ref ETextureInfoFormat format, ETextureUsageType eTextureType)
	{
		return null;
	}

	public static bool IsZip(string url)
	{
		return false;
	}

	public static string FixedUrlWithRelativePath(string url)
	{
		return null;
	}

	private void RecordCDNDownloadFailedInfo(DownloadTextureInfo info, long responseCode, string fail_reason)
	{
	}

	public void AddCDNDownfailEvent(DownloadTextureInfo info)
	{
	}

	private bool ProcessDownloadfinishedCallBack(List<OnDowloadFinished> downloadFinishedCallBack, ResultTextureInfo resultTexture)
	{
		return false;
	}

	private int CalAstcSizeByHeader(byte[] data, out int width, out int height)
	{
		width = default(int);
		height = default(int);
		return 0;
	}

	private int CalAstcSizeByHeader(IntPtr p, int download_size, out int width, out int height)
	{
		width = default(int);
		height = default(int);
		return 0;
	}

	private int CalETCSizeByHeader(byte[] data, out int width, out int height, out int data_index)
	{
		width = default(int);
		height = default(int);
		data_index = default(int);
		return 0;
	}

	private int CalETCSizeByHeader(IntPtr p, int data_size, out int width, out int height, out int data_index)
	{
		width = default(int);
		height = default(int);
		data_index = default(int);
		return 0;
	}

	private int CalPvrSizeByHeader(byte[] data, out int width, out int height, out int meta_data_size)
	{
		width = default(int);
		height = default(int);
		meta_data_size = default(int);
		return 0;
	}

	private int CalPvrSizeByHeader(IntPtr p, int data_size, out int width, out int height, out int meta_data_size)
	{
		width = default(int);
		height = default(int);
		meta_data_size = default(int);
		return 0;
	}

	public void DeleteSpecificUrlLoadedCache(string url)
	{
	}

	public void DeleteSpecificUrlLocalCache(string url, bool useOriginal = false, ETextureUsageType textureType = ETextureUsageType.None, uint endTime = uint.MaxValue)
	{
	}

	public string GetLocalCDNURLPath(DownloadTextureInfo info, bool forWebRequest)
	{
		return null;
	}

	private void WriteSharedDataToFileStream(IntPtr sharedData, int dataSize, FileStream fileStream)
	{
	}

	private void SetLength(IntPtr sharedData, int length)
	{
	}
}
