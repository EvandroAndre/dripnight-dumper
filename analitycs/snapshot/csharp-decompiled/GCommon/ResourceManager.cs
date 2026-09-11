using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using COW.GamePlay;
using LitJson;
using TsiU;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace GCommon;

public class ResourceManager : TSingleton<ResourceManager>
{
	public enum EResourceConfigLevelSetting : byte
	{
		None,
		Replace,
		Hide
	}

	public enum ELoadAbOption : byte
	{
		NotAb,
		AbWithName,
		AbWithPath,
		AbWithNameOrPath,
		StreamAb,
		StreamOptAb
	}

	public enum ELoadedByAvatarType : byte
	{
		None,
		LocalAvatar,
		PreviewAvatar,
		TeammateAvatar
	}

	public enum EResIconInCDNType : byte
	{
		Normal,
		HeadPic,
		BriefBanner,
		BaseBanner,
		BigIcon,
		Portrait,
		SharePortrait
	}

	public class ResourceConfigAB
	{
		public string m_path;

		public string m_abPath;

		public MethodInfo m_Modifier;

		public short m_pathIndex;

		public EResourceConfigLevelSetting m_LevelLow;

		public EResourceConfigLevelSetting m_LevelHigh;

		public ELoadAbOption m_AbOption;

		public bool IsIngameCollectionRes;

		public bool IsLobbyShowHighQualityRes;

		public bool IsAb => false;

		public string GetPath(MNMBLBKENMK s)
		{
			return null;
		}

		public string GetPath()
		{
			return null;
		}

		private static string AppendSuffix(ELoadAbOption abOpt, string path, string suffix)
		{
			return null;
		}
	}

	private class ResourceConfigStreamAB : ResourceConfigAB
	{
		public string m_streamABPath;
	}

	public class PreloadResKey : IComparable<PreloadResKey>, IEquatable<PreloadResKey>, IComparable
	{
		private int _003CModeHash_003Ek__BackingField;

		private int _003CModeHash2_003Ek__BackingField;

		private short _003CMapId_003Ek__BackingField;

		private sbyte _003CGraphicSetting_003Ek__BackingField;

		public int ModeHash
		{
			get
			{
				return _003CModeHash_003Ek__BackingField;
			}
			set
			{
				_003CModeHash_003Ek__BackingField = value;
			}
		}

		public int ModeHash2
		{
			get
			{
				return _003CModeHash2_003Ek__BackingField;
			}
			set
			{
				_003CModeHash2_003Ek__BackingField = value;
			}
		}

		public short MapId
		{
			get
			{
				return _003CMapId_003Ek__BackingField;
			}
			set
			{
				_003CMapId_003Ek__BackingField = value;
			}
		}

		public sbyte GraphicSetting
		{
			get
			{
				return _003CGraphicSetting_003Ek__BackingField;
			}
			set
			{
				_003CGraphicSetting_003Ek__BackingField = value;
			}
		}

		public PreloadResKey(Enum mode, short mapid, sbyte graphic, Enum mode2 = null)
		{
		}

		public int CompareTo(PreloadResKey other)
		{
			return 0;
		}

		public bool Equals(PreloadResKey other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public int CompareTo(object rhs)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
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

	public class PreloadResourceInfo
	{
		private ResourceID _003CResouceId_003Ek__BackingField;

		private short _003CInitCount_003Ek__BackingField;

		public ResourceID ResouceId
		{
			get
			{
				return _003CResouceId_003Ek__BackingField;
			}
			set
			{
				_003CResouceId_003Ek__BackingField = value;
			}
		}

		public short InitCount
		{
			get
			{
				return _003CInitCount_003Ek__BackingField;
			}
			set
			{
				_003CInitCount_003Ek__BackingField = value;
			}
		}

		public PreloadResourceInfo(ResourceID resId, short count)
		{
		}
	}

	public enum LoadPriority
	{
		Low,
		Normal,
		High
	}

	public enum ERefOwner
	{
		None = 0,
		Cached = 1,
		AsyncLoad = 2,
		Scene = 4,
		Uma = 8,
		UGC = 0x10
	}

	private class AssetWithRefs
	{
		public int RefOwners;

		public int RefCount;

		public bool IsRefedOtherThan(ERefOwner owner)
		{
			return false;
		}

		public static bool CountRefs(ERefOwner owner)
		{
			return false;
		}

		private static int CountRefs(int ownerBits)
		{
			return 0;
		}

		public bool HasRef(ERefOwner owner)
		{
			return false;
		}

		public void AddRefs(int ownerBits)
		{
		}

		public void AddRef(ERefOwner owner, short delta = 1)
		{
		}
	}

	private class AssetBundleWithRefs : AssetWithRefs
	{
		public AssetBundle Bundle;

		public void Reset()
		{
		}
	}

	public enum EIngameCollectionResOption
	{
		Default,
		ForceLow,
		ForceHigh
	}

	private class ResAsyncRequest
	{
		public enum ReqState : byte
		{
			Waiting,
			InProgress,
			Cached,
			Completed,
			Cancelled,
			Recycled
		}

		public ResourceID ResID;

		public string ResPath;

		public Type Type;

		public ELoadAbOption ABOption;

		public string ABPath;

		public bool Preload;

		public bool NoCache;

		public bool NoDestroy;

		public int RefOwners;

		public Dictionary<uint, Action<uint, bool, UnityEngine.Object>> Callbacks;

		public AsyncOperation AsyncOp;

		public ReqState State;

		public UnityEngine.Object CachedObj;

		public ResAsyncRequest(ResourceID resID, string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy, ERefOwner refOwner)
		{
		}

		public void Init(ResourceID resID, string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy, bool reInit, ERefOwner refOwner)
		{
		}

		public void RegisterAction(uint ticket, Action<uint, bool, UnityEngine.Object> callback)
		{
		}

		public void UnregisterAction(uint ticket)
		{
		}

		public void InvokeActions(bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	private class ResAsyncRequestV2
	{
		public enum ReqState : byte
		{
			Waiting,
			LoadingDependencies,
			LoadingAb,
			WaitLoadingAb,
			InProgress,
			Cached,
			Completed,
			Cancelled,
			Failed,
			Recycled
		}

		public enum DependenciesLoadState : byte
		{
			Loading,
			Completed,
			Failed
		}

		public LoadPriority LoadPriority;

		public float StartTimeStamp;

		public float DependencyTimeStamp;

		public bool Reported;

		public bool DependencyReported;

		public bool IsInPool;

		public ResourceID ResID;

		public string ResPath;

		public Type Type;

		public ELoadAbOption ABOption;

		public string ABPath;

		public bool Preload;

		public bool NoCache;

		public bool NoDestroy;

		public int RefOwners;

		public Dictionary<uint, Action<uint, bool, UnityEngine.Object>> Callbacks;

		private Dictionary<string, AsyncOperation> m_LoadingDependencies;

		private List<string> m_AllDependentAbs;

		public AsyncOperation AsyncOp;

		public ReqState State;

		public UnityEngine.Object CachedObj;

		public float StartTime;

		public int ResPathHash;

		public Dictionary<string, AsyncOperation> LoadingDependencies => null;

		public List<string> AllDependentAbs => null;

		public ResAsyncRequestV2(ResourceID resID, string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy, ERefOwner refOwner, LoadPriority loadPriority, int resPathHash)
		{
		}

		public void Init(ResourceID resID, string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy, bool reInit, ERefOwner refOwner, LoadPriority loadPriority, int resPathHash)
		{
		}

		public void RegisterAction(uint ticket, Action<uint, bool, UnityEngine.Object> callback)
		{
		}

		public bool IsDependOnAb(string abPath)
		{
			return false;
		}

		public void InvokeActions(bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	private class AsyncLoadPriorityList
	{
		public class AsyncRequestList
		{
			public List<ResAsyncRequestV2> asyncRequestList;

			public int Count => 0;

			public bool IsEmpty()
			{
				return false;
			}

			public ResAsyncRequestV2 First()
			{
				return null;
			}

			public void AddLast(ResAsyncRequestV2 loader)
			{
			}

			public bool Remove(ResAsyncRequestV2 loader)
			{
				return false;
			}

			public ResAsyncRequestV2 Cancel(uint ticket)
			{
				return null;
			}

			public void Clean(List<ResAsyncRequestV2> requestsToRemoveV2)
			{
			}

			public ResAsyncRequestV2 Find(string resPath, string abPath, ELoadAbOption abOpt, Type type, int resPathHash)
			{
				return null;
			}

			public ResAsyncRequestV2 Find(uint ticket)
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}

			public string _003C_003EiFixBaseProxy_ToString()
			{
				return null;
			}
		}

		public AsyncRequestList mResAsyncRequestListV2High;

		public AsyncRequestList mResAsyncRequestListV2Normal;

		public AsyncRequestList mResAsyncRequestListV2Low;

		public int Count => 0;

		public bool IsEmpty()
		{
			return false;
		}

		public ResAsyncRequestV2 First()
		{
			return null;
		}

		public void AddLast(ResAsyncRequestV2 loader)
		{
		}

		public bool Remove(ResAsyncRequestV2 loader)
		{
			return false;
		}

		public ResAsyncRequestV2 Cancel(uint ticket)
		{
			return null;
		}

		public void Clean(List<ResAsyncRequestV2> requestsToRemoveV2)
		{
		}

		public ResAsyncRequestV2 Find(string resPath, string abPath, ELoadAbOption abOpt, Type type, int resPathHash)
		{
			return null;
		}

		public ResAsyncRequestV2 Find(uint ticket)
		{
			return null;
		}
	}

	public class PreloadAssetKey
	{
		private string _003CName_003Ek__BackingField;

		private string _003CSubType_003Ek__BackingField;

		private int _003CMapId_003Ek__BackingField;

		private string _003CGraphicSetting_003Ek__BackingField;

		private int _003CPoolInitCount_003Ek__BackingField;

		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		public string SubType
		{
			get
			{
				return _003CSubType_003Ek__BackingField;
			}
			set
			{
				_003CSubType_003Ek__BackingField = value;
			}
		}

		public int MapId
		{
			get
			{
				return _003CMapId_003Ek__BackingField;
			}
			set
			{
				_003CMapId_003Ek__BackingField = value;
			}
		}

		public string GraphicSetting
		{
			get
			{
				return _003CGraphicSetting_003Ek__BackingField;
			}
			set
			{
				_003CGraphicSetting_003Ek__BackingField = value;
			}
		}

		public int PoolInitCount
		{
			get
			{
				return _003CPoolInitCount_003Ek__BackingField;
			}
			set
			{
				_003CPoolInitCount_003Ek__BackingField = value;
			}
		}

		public PreloadAssetKey(string name, int mapid, string graphic, int poolinit, string subtype = "")
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(PreloadAssetKey obj)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}
	}

	public class DataUGCAsyncAssetBundle
	{
		public string m_abName;

		public IEnumerator m_corEnumerator;

		public List<Action<AssetBundle>> m_callbacks;

		public void Resolve(AssetBundle ab)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<uint, bool, UnityEngine.Object> _003C_003E9__148_0;

		internal void _003CPreloadCabin_003Eb__148_0(uint ticket, bool success, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass258_0
	{
		public AsyncInstantiateOperation<GameObject> asyncInstantiate;

		public GameObject obj;

		public Action<GameObject> onCompleted;

		internal void _003CInstantAsync_003Eb__0(AsyncOperation _)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass490_0
	{
		public UnityEngine.Object resObj;

		public string resPath;

		public Action<uint, bool, UnityEngine.Object> callback;

		public string abPath;

		internal void _003CGetResourceByNameAndAb_003Eb__0(AssetBundle assetBundle)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass500_0
	{
		public int dependCount;

		public Action<AssetBundle> _003C_003E9__0;

		internal void _003CCorAsyncLoadUGCAssetBundle_003Eb__0(AssetBundle assetBundle)
		{
		}
	}

	private sealed class _003CCorAsyncLoadUGCAssetBundle_003Ed__500 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResourceManager _003C_003E4__this;

		public string abName;

		public DataUGCAsyncAssetBundle task;

		private _003C_003Ec__DisplayClass500_0 _003C_003E8__1;

		private string _003Curl_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCorAsyncLoadUGCAssetBundle_003Ed__500(int _003C_003E1__state)
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

	private const int CapacityResourcePaths = 20000;

	private const int CapacityResourceMappingAB = 4000;

	public const uint SpriteInCDNIconRes = 100000000u;

	public const uint CDNSpriteSplitAlphaBasicBeginResID = 2100000000u;

	private uint CDNSpriteSplitAlphaBasicResID;

	public const uint CDNSpriteWithoutAlphaBasicBeginResID = 2200000000u;

	private uint CDNSpriteWithoutAlphaBasicResID;

	private const int CapacityResourceAnoymousMapping = 65000;

	private const int CapacityResourceAnoymousNameMapping = 100;

	private const int CapacityNameMapping = 10000;

	private const int CapacityLoadedResources = 500;

	private const int CapacityPreLoadedResources = 500;

	public const string StreamAbDirName = "streaming";

	public static string StreamAbDir;

	public const string ResconfPath = "Config/Resconf";

	public const string ResconfAudioPath = "Config/Resconf_Audio";

	public const string ResconfUIPath = "Config/Resconf_UI";

	public const string ResconfPVSPath = "Config/Resconf_PVS";

	public const string LangResourceMapPath = "Config/Resconf_LangResourceMap";

	public const string LangResourceMapHotupdatePath = "Config/Resconf_LangResourceMapHotupdate";

	public const string BaseResconfPath = "Config/SplitedResconfs/BaseResconf";

	public const string PartialResconfPath = "Config/SplitedResconfs/PartialResconf";

	public const string UIResconfPath = "Config/SplitedResconfs/UIResconf";

	public const string StrBytesPath = "Config/SplitedResconfs/ResconfStrs";

	public const string PreloadconfPath = "Config/Preloadconf";

	public readonly List<string> SubResconfPaths;

	public const string ResconfPathHD = "HD/Config/Resconf";

	public const string WwiseResconfPathHD = "HD/Config/Resconf_Wwise";

	protected ResourceID m_ResourcePathsStartID;

	protected ResourceID m_ResourcePathsNextID;

	public static bool CollectionQualityIsEffect;

	protected List<string> m_ResourcePathsList;

	private List<short> m_ResourcePathsIndexList;

	private Dictionary<ResourceID, string> m_CachedResourcePath;

	private int m_ResconfVersion;

	private bool m_HasResourceIndexAB;

	private ResourceID m_ResourceCompactMappingStartID;

	private ResourceID m_ResourceCompactMappingNextID;

	private List<uint> m_CompactMappings;

	private List<string> m_AbNames;

	protected List<string> m_CompactMappingUrls;

	private List<short> m_CompactMappingUrlsIndex;

	private List<string> m_CompactMappingStreamAbs;

	private List<MethodInfo> m_CompactMappingModifiers;

	private ResourceConfigStreamAB m_TmpConfigAb;

	private Dictionary<string, uint> m_LangResourceMap;

	private ResourceID m_ResourceMappingABStartID;

	private ResourceID m_ResourceMappingABNextID;

	private List<ResourceConfigAB> m_ResourceMappingABList;

	private Dictionary<string, ResourceID> m_AbToPlaceholderReses;

	private Dictionary<int, ResourceID> m_dictAnonymousResNameHash2ID;

	private Dictionary<int, ResourceID> m_dictAnonymousResNameHash2IDTmp;

	private Dictionary<string, ResourceID> m_dictAnonymousResColHashName2ID;

	private Dictionary<string, ResourceID> m_dictAnonymousResColHashName2IDTmp;

	protected IntervalTreeDic<string> m_NameMappingTree;

	private Dictionary<ResourceID, string> m_NameMapping;

	private List<string> m_ABLoadFailed_Pathes;

	private Dictionary<PreloadResKey, ResourceID[]> m_AudioPreloadResource;

	private Dictionary<string, List<string>> m_ResconfDependencies;

	private Dictionary<PreloadResKey, PreloadResourceInfo[]> m_PreloadResource;

	private Dictionary<PreloadResKey, ResourceID[]> m_PreloadResource_PlayerAnimators;

	private HashSet<ResourceID> m_PreloadResourceID;

	private Dictionary<PreloadResKey, int[]> m_PreloadUmas;

	private bool m_HasInited;

	private bool m_HasParsed;

	private AssetBundleManifest m_ABManifest;

	private bool m_UseAssetBundle;

	[NonSerialized]
	public uint LoadErrorSizePackTimes;

	[NonSerialized]
	public int m_SyncLoadTickCount;

	[NonSerialized]
	public List<string> m_CurFrameSyncLoad;

	[NonSerialized]
	public float m_CurFrameSyncLoadTime;

	[NonSerialized]
	public List<string> m_LastFrameSyncLoad;

	[NonSerialized]
	public float m_LastFrameSyncLoadTime;

	private const int RefOwnerMaskAll = 15;

	private const int RefOwnerMaskCountRefs = 11;

	private const int RefOwnerMaskNoCountRefs = 4;

	[NonSerialized]
	public int BundleRefsGeneration;

	private Dictionary<string, UnityEngine.Object> m_LoadedResources;

	private Dictionary<string, AssetBundleWithRefs> m_ResourceBundle;

	private Dictionary<string, UnityEngine.Object> m_DontDestroyLoadedResources;

	private Dictionary<string, AssetBundle> m_DontDestroyResourceBundle;

	private Dictionary<string, UnityEngine.Object> m_PreLoadedResources;

	private Dictionary<string, AssetBundle> m_PreLoadedResourceBundles;

	private Dictionary<string, string> m_StreamAbs;

	private string[] mPersisitResources;

	private MNMBLBKENMK ResQualityLevel;

	private const MNMBLBKENMK DefaultQualityLevel = MNMBLBKENMK.Total;

	public static bool UseSceneFolderAB;

	public static bool EnableRecordLoadABFailed;

	private Type mResIDType;

	private Dictionary<string, FieldInfo> mResIDFieldInfos;

	private List<ResourceRefCache> m_RefCaches;

	private ELoadedByAvatarType m_LoadedByAvatarType;

	private bool m_UseStrBytes;

	private bool m_UsingPackedNames;

	private PackedStrings m_PackedNames;

	private IntervalTree m_NameIndexTree;

	private Dictionary<ResourceID, string> m_CachedResourceNames;

	private Dictionary<ResourceID, string> m_AdditionalResourceNames;

	private bool m_UsingPackedUrls;

	private PackedResconfUrls m_PackedUrls;

	private bool m_IsFrontEndGame;

	private EIngameCollectionResOption m_IngameCollectionResOption;

	private bool hasSetRecommondedQuality;

	private MNMBLBKENMK m_RecommondedQuality;

	private ResourceID m_PreloadedCabinResID;

	private int m_RegisterThreadCount;

	private List<string> m_cacheLoadedSceneList;

	private List<ResourceID> m_OriginalIDWithOutAlphaSplit;

	private static HashSet<string> DontDestroyAbNames;

	private Dictionary<string, bool> m_CommonAbDestroy;

	private int[] m_texturIDPropertys;

	private readonly LinkedList<ResAsyncRequest> mResAsyncRequestList;

	private bool mPendingCleanUp;

	public const uint InvalidTicket = 0u;

	public const uint InstantCallTicket = 1u;

	private static uint ticketGen;

	private readonly List<ResAsyncRequest> mResAsyncRequestPool;

	private bool mTempDisablePooling;

	private List<ResAsyncRequest> requestsToRemove;

	private int m_AsyncLoadCount;

	private FTimer m_CallBackTimer;

	private AsyncLoadPriorityList asyncLoadPriorityList;

	private readonly LinkedList<ResAsyncRequestV2> mResAsyncRequestListV2;

	private readonly List<ResAsyncRequestV2> mResAsyncRequestPoolV2;

	private Dictionary<string, AsyncOperation> mAsyncLoadingAbs;

	private List<string> finishedDeps;

	private List<string> abDeps;

	private List<ResAsyncRequestV2> mRequestsToRemoveV2;

	private float m_LastPauseTime;

	private float m_PauseTime;

	private bool m_PauseAsyncLoading;

	private float m_LastPauseAsyncLoadingTime;

	private float m_PauseAsyncLoadingTime;

	public static string UILauncherPopupMessageURL;

	public static string UILauncherURL;

	public static string UIFFLogoURL;

	public static string MaxLoGoURL;

	public static string UIWebViewWindowLiteURL;

	public static string UILauncherDotURL;

	public static string LocGlobalURL;

	public static string LocLauncherURL;

	public static string LocAbConfURL;

	public static string UILauncherReviewBgURL;

	public static string LocHiFontURL;

	public static string LocBnFontURL;

	public static string LocHiFontABURL;

	public static string LocHiFontABResURL;

	public static string LocBnFontABURL;

	public static string LocBnFontABResURL;

	public const bool AdditiveHotupdate = true;

	public const string ResconfHotupdate = "Config/ResconfHotupdate";

	public StringBuilder SpriteRepeatNameInfo;

	public const string IsIngameCollectionRes_JsonName = "IsIngameCollectionRes";

	public const string IsLobbyShowHighQualityRes_JsonName = "IsLobbyShowHighQualityRes";

	private bool m_EnableResourceMapping;

	private Dictionary<string, string> m_DependenceAbs;

	private const string DisableOptResconfTxtParseGcKeyPrefix = "DISABLE_OPT_RESCONF_TXT_PARSE_GC";

	public const bool HdBuildUseStrBytes = false;

	public const bool HdBuildStrBytesIncludeHdResconf = false;

	private bool m_OptParseAndAddMember;

	private MutableString m_NameStr;

	private MutableString m_urlStr;

	private bool m_NeedResIDToName;

	private const string OptGcInProgressKey = "DISABLE_OPT_RESCONF_TXT_PARSE_GC_IN_PROGRESS";

	private uint m_LastAtlasCompactMapping;

	private static bool AssertNoOverwriteNameForResId;

	private bool m_UsingNameMappingTree;

	private List<List<string>> m_NameMappingNames;

	private List<IntervalNode> m_NameMappingRanges;

	private int m_NameMappingCurrentRangeIdx;

	private uint m_NameMappingCurrentRangeStartId;

	private uint m_NameMappingCurrentRangeNextId;

	private List<string> m_NameMappingCurrentRangeNames;

	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadAssetsList;

	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadAssetsAudio;

	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadAnimators;

	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadUmasTmpList;

	protected static List<string> m_ResourceShortPathList;

	protected bool m_NeedCompressString;

	protected bool m_NeedCompressResoucePathFromMemory;

	private StringBuilder m_StringBuilder;

	private Dictionary<ResourceID, ResourceID> m_dictRegionalReplacementRes;

	private List<string> m_RegionalReplacementResList;

	private Dictionary<string, string> ABPath2Uri;

	private List<DataUGCAsyncAssetBundle> m_ugcAsyncCoroutinue;

	private uint CDNSpriteResIDWithSplitAlpha => 0u;

	private uint CDNSpriteResIDWithOutSplitAlpha => 0u;

	public ResourceID ResourcePathsNextID => default(ResourceID);

	public ELoadedByAvatarType LoadedByAvatarType => ELoadedByAvatarType.None;

	public MNMBLBKENMK RecommondedQuality => MNMBLBKENMK.High;

	public bool ResconfHasParsed => false;

	public bool Inited => false;

	public int LoadedAbCount => 0;

	private int[] m_TextureIDPropertys => null;

	public static uint NewTicket => 0u;

	public void SetLoadedByAvatarType(bool isLocalAvatar, bool isPreviewAvatar)
	{
	}

	public void ResetLoadedByAvatarType()
	{
	}

	public void SetResQualityLevel(MNMBLBKENMK q)
	{
	}

	public MNMBLBKENMK GetResQualityLevel()
	{
		return MNMBLBKENMK.High;
	}

	public void SetIsFrontEndGame(bool val)
	{
	}

	public void SetIngameCollectionResOption(EIngameCollectionResOption opt)
	{
	}

	public bool Init(bool useAssetBundle, string[] dontDestoryResources = null)
	{
		return false;
	}

	public void Cleanup(Type ResID = null)
	{
	}

	private void ResetResourceIdFieldValues(Type ResID)
	{
	}

	public void ClearForReparseResconf()
	{
	}

	private void UnloadAllAbs()
	{
	}

	protected void ResetAllFields()
	{
	}

	public uint GetLangResourceMap(string url)
	{
		return 0u;
	}

	private void LoadLangResourceMap()
	{
	}

	public ResourceID GetPreloadedCabinResID()
	{
		return default(ResourceID);
	}

	public void PreloadCabin()
	{
	}

	public void RemoveDontDestroyRes(ResourceID resourceID)
	{
	}

	public void LoadPersisitResource(string[] dontDestoryResources)
	{
	}

	public void SwapAndReleaseAnoymousMappingTmp()
	{
	}

	public void UnregisterAnoymousMappingTmp()
	{
	}

	public void RegisterAnoymousMappingTmp()
	{
	}

	public void ResetRegisterAnoymousMappingTmp()
	{
	}

	public bool GetResourceMappingState()
	{
		return false;
	}

	private void LoadDontDestoryResource(string resPath)
	{
	}

	public void PoolInitRes(ResourceID id, int num, uint maxSize = 0u)
	{
	}

	public bool PoolContainsRes(ResourceID id)
	{
		return false;
	}

	public MNMBLBKENMK GetHighResFallbackOverrideQuality(ResourceID resID, bool enableFallback)
	{
		return MNMBLBKENMK.High;
	}

	private MNMBLBKENMK GetHighResFallbackOverrideQualityInternal(ResourceID resID)
	{
		return MNMBLBKENMK.High;
	}

	public static bool ShouldEnableHighResFallback(bool enableFallback)
	{
		return false;
	}

	private bool TryGetHighQualitySetting(ResourceID resID, out EResourceConfigLevelSetting highSetting, out bool isIngameCollectionRes)
	{
		highSetting = default(EResourceConfigLevelSetting);
		isIngameCollectionRes = default(bool);
		return false;
	}

	private static bool IsHighQuality(MNMBLBKENMK quality)
	{
		return false;
	}

	public UnityEngine.Object PoolGetRes(ResourceID id, Transform tranformParent = null, bool enableHighResFallback = false)
	{
		return null;
	}

	public bool PoolReturnRes(ResourceID id, UnityEngine.Object obj, bool worldPositionStays = true)
	{
		return false;
	}

	public string GetResourceAbName(ResourceID id)
	{
		return null;
	}

	public string GetResourceStreamAbName(ResourceID id)
	{
		return null;
	}

	public UnityEngine.Object GetResource(ResourceID id, bool notUsingABForcefully = false, Type type = null, bool noCache = false, MNMBLBKENMK override_quality = MNMBLBKENMK.Total, bool dontDestroy = false, bool dontDestroyIfInAb = false)
	{
		return null;
	}

	public UnityEngine.Object GetResource(string resPath, bool notUsingABForcefully = false, bool noCache = false, bool dontDestroy = false)
	{
		return null;
	}

	private UnityEngine.Object GetResource(string resPath, ELoadAbOption abOpt, string ab = "", Type type = null, bool noCache = false, bool dontDestroy = false, ResourceID id = default(ResourceID))
	{
		return null;
	}

	private void RecordSyncLoadInfo(float time, string url)
	{
	}

	private void ReportIOFailedLogs(string name)
	{
	}

	private UnityEngine.Object GetResourceInternal(string resPath, ELoadAbOption abOpt = ELoadAbOption.NotAb, string abPath = "", bool dontDestroy = false, Type type = null, bool noCache = false, ERefOwner refOwner = ERefOwner.None, bool isPreloadRes = false, ResourceID resID = default(ResourceID))
	{
		return null;
	}

	public bool isAbStreamFile(string abPath)
	{
		return false;
	}

	private AssetBundle LoadABImpl(string abPath)
	{
		return null;
	}

	public uint GetPlayerLoadErrorPackSize()
	{
		return 0u;
	}

	private AssetBundle GetLoadedAssetBundle(string resPath, bool dontDestroy, out AssetBundleWithRefs abWithRefs)
	{
		abWithRefs = null;
		return null;
	}

	private AssetBundle LoadABWithoutLoadingAssets(string resPath, bool dontDestroy, out AssetBundleWithRefs abWithRefs)
	{
		abWithRefs = null;
		return null;
	}

	public void RemoveSceneAB(string abPath)
	{
	}

	public void OnLoadSceneFinish(string scenePath, bool useAB)
	{
	}

	public void RecordABLoadFailed(string ab_path)
	{
	}

	public List<string> GetABLoadFailedPathes()
	{
		return null;
	}

	public void ClearABLoadFailedPathes()
	{
	}

	public AsyncOperation StartLoadingSceneAsync(string scenePath, string abPath = "", LoadSceneMode mode = LoadSceneMode.Single, bool notUsingABForcefully = false, bool forceSync = false)
	{
		return null;
	}

	public AssetBundle LoadSceneABWithoutLoadingAssets(string abPath)
	{
		return null;
	}

	public static string GetStreamABPathByABPath(string ab_path)
	{
		return null;
	}

	public string GetSceneStreamABPath(ResourceID id)
	{
		return null;
	}

	public bool IsResourceUseAB(ResourceID id, ref string abPath)
	{
		return false;
	}

	public string IsMapHasPatch(ResourceID mapSceneID)
	{
		return null;
	}

	public void FinishLoadingScene(ResourceID id)
	{
	}

	public AsyncOperation StartLoadingSceneAsync(ResourceID id, LoadSceneMode mode = LoadSceneMode.Single, bool notUsingABForcefully = false, bool need_modify = false)
	{
		return null;
	}

	public AsyncOperation UnloadSceneAsync(ResourceID id, bool checkIsLoaded = false)
	{
		return null;
	}

	private PreloadResourceInfo[] GetPreladResources(Dictionary<PreloadResKey, PreloadResourceInfo[]> preloadResource, Enum gametype, Enum modetype, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	private PreloadResourceInfo[] GetPreladResources(Dictionary<PreloadResKey, PreloadResourceInfo[]> preloadResource, Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	private ResourceID[] GetPreladResources(Dictionary<PreloadResKey, ResourceID[]> preloadResource, Enum gametypeormode, Enum subtype, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	private static void GetPreloadResourceInternal(Dictionary<PreloadResKey, ResourceID[]> preloadResource, Enum gametypeormode, Enum subtype, int mapid, int graphicsetting, List<ResourceID> result)
	{
	}

	private List<int> GetPreladResources(Dictionary<PreloadResKey, int[]> preloadResource, Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	private static void AddResourceIDNoDuplicated(List<ResourceID> result, ResourceID[] ret)
	{
	}

	private static void AddResourceIDNoDuplicated(List<PreloadResourceInfo> result, PreloadResourceInfo[] ret)
	{
	}

	private static void AddResourceIDNoDuplicated(List<int> result, int[] ret)
	{
	}

	private int GetInstantCountFromResultArray(PreloadResourceInfo[] ret, ResourceID resource)
	{
		return 0;
	}

	public int GetPreloadResourcePoolInstantCount(ResourceID resource, Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return 0;
	}

	private static void GetPreloadResourcePoolDic(Dictionary<ResourceID, PreloadResourceInfo> result, PreloadResourceInfo[] ret)
	{
	}

	private ResourceID[] GetPreladResourceNoDuplicated(PreloadResourceInfo[] preloadArray)
	{
		return null;
	}

	public void SetPreloadResource(ResourceID[] preloadResource)
	{
	}

	public ResourceID[] GetPreloadResource(Enum gametype, Enum modetype, int mapid = -1, int graphicsetting = -1, Dictionary<ResourceID, PreloadResourceInfo> preloadpoolinitdic = null)
	{
		return null;
	}

	public ResourceID[] GetPreloadResource(Enum gametypeormode, int mapid = -1, int graphicsetting = -1, Dictionary<ResourceID, PreloadResourceInfo> preloadpoolinitdic = null)
	{
		return null;
	}

	public ResourceID[] GetPreloadAudioResource(Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	public ResourceID[] GetPreloadPlayerAnimatorsResource(Enum key, Enum gamemode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	public List<int> GetPreloadUmaResources(Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	public string GetPath(ResourceID resourceID, MNMBLBKENMK rq)
	{
		return null;
	}

	public string GetPath(ResourceID resourceID)
	{
		return null;
	}

	public List<ResourceID> GetResourceIDs()
	{
		return null;
	}

	public bool CheckNeedAlphaSplit(ResourceID id)
	{
		return false;
	}

	public ResourceID GetItemSpriteCDNResourceIDByItemID(uint itemID, bool withOutAlphaSplit = false)
	{
		return default(ResourceID);
	}

	public ResourceID GetIconCDNResourceIDAnonymous(bool splitAlpha = false)
	{
		return default(ResourceID);
	}

	public bool CheckThisCDNSpriteResNeedSplitAlpha(ResourceID resID)
	{
		return false;
	}

	public string GetAtlasOrSpriteResourceIDName(ResourceID ResID, bool InLogErr = true)
	{
		return null;
	}

	private bool TryGetAnonymousResourceIDByName(string strResid, int hashKey, out ResourceID ret)
	{
		ret = default(ResourceID);
		return false;
	}

	public ResourceID GetResourceIDByName(Type ResID, string strResid, bool InLogErr = true, bool needReflect = true)
	{
		return default(ResourceID);
	}

	private static bool IsPathWithSuffix(string url)
	{
		return false;
	}

	public AsyncOperation ClearAllLoadedResource(bool includingPreloadResource = true, bool clearPool = true, bool unloadAb = true, bool cancelAsyncs = true)
	{
		return null;
	}

	public void ClearLoadedResourceRefs()
	{
	}

	public void ClearResource(ResourceID id, bool isUnloadAsset = true)
	{
	}

	private void ClearResource(ResourceConfigAB config, bool isUnloadAsset = true)
	{
	}

	private bool ClearResource(string path, bool isUnloadAsset = true)
	{
		return false;
	}

	private bool ClearPreLoadedResources(string path)
	{
		return false;
	}

	public bool ClearLoadedResources(string path, bool isUnloadAsset = true)
	{
		return false;
	}

	public void ClearAndUnloadLoadedResources(string path)
	{
	}

	public void ClearPreloadResources()
	{
	}

	private void ClearAllLoadedResourceInternal(bool includingPreloadResource, bool clearPool = true, bool unloadAb = true)
	{
	}

	public void UnloadBundleResourceByPath(string path, bool unloadLoadedAssets = false)
	{
	}

	public bool ForceUnloadPrefabReferenceAssets(ResourceID id)
	{
		return false;
	}

	public bool CheckIsPreloadRes(ResourceID id)
	{
		return false;
	}

	public bool PreloadResouce(ResourceID id)
	{
		return false;
	}

	private void PreloadAbInNeed(string abPath)
	{
	}

	public UnityEngine.Object GetResourceNoCache(ResourceID id)
	{
		return null;
	}

	public UnityEngine.Object GetResourceByNameAndAb(string resPath, string abPath, bool preload, bool noCache, ERefOwner refOwner)
	{
		return null;
	}

	protected UnityEngine.Object GetResourceNoCache(string path, bool notUsingABForcefully = false)
	{
		return null;
	}

	public ResourceID AddPlaceholderResForAb(string ab)
	{
		return default(ResourceID);
	}

	public ResourceID GetPlaceholderResForAb(string ab)
	{
		return default(ResourceID);
	}

	private bool LoadResconfDependenciesInNeed(string ab, bool recursive = false)
	{
		return false;
	}

	private bool InDontDestroyAbs(string ab)
	{
		return false;
	}

	public bool NeedDownloadOptionalBundle(bool assertInSingleBundle, ResourceID[] ids)
	{
		return false;
	}

	public bool NeedDownloadOptionalBundle(ResourceID id)
	{
		return false;
	}

	public bool NeedDownloadOptionalBundle(string ab)
	{
		return false;
	}

	public List<string> GetResourceDependencies(string ab)
	{
		return null;
	}

	public static UnityEngine.Object InstantObj(UnityEngine.Object obj, Transform trans = null, bool stayworldpos = false)
	{
		return null;
	}

	public static GameObject InstantPrefab(UnityEngine.Object obj, Transform parent = null, bool setPosAndRot = false, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion))
	{
		return null;
	}

	public static GameObject Instant(UnityEngine.Object obj, Transform parent = null, bool setPosAndRot = false, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion), bool CollectionIsEffect = false)
	{
		return null;
	}

	public static void InstantAsync(GameObject obj, Action<GameObject> onCompleted, Transform parent = null, bool setPosAndRot = false, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion))
	{
	}

	public static GameObject InstantByResId(ResourceID resId, Transform parent = null, bool setPosAndRot = false, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion), MNMBLBKENMK quality = MNMBLBKENMK.Total)
	{
		return null;
	}

	public void UnLoadResource(ResourceID resId)
	{
	}

	public void UnloadAnimClip(ResourceID resId, bool includeAnimRef = true)
	{
	}

	public void UnloadSplashTexture()
	{
	}

	public ResourceRefCache CreateRefCache()
	{
		return null;
	}

	public void ReleaseRefCache(ResourceRefCache cache)
	{
	}

	private bool ResourceContains(ResourceID resourceID)
	{
		return false;
	}

	private bool TryGetResourceConfigAB(ResourceID resourceID, out ELoadAbOption opt, out string ab)
	{
		opt = default(ELoadAbOption);
		ab = null;
		return false;
	}

	private bool TryGetResourceStreamAB(ResourceID resourceID, out bool isAb, out string streamAb)
	{
		isAb = default(bool);
		streamAb = null;
		return false;
	}

	private bool TryGetResourceConfigABOrStreamAB(ResourceID resourceID, out ELoadAbOption opt, out string ab, out bool isAb, out string streamAb)
	{
		opt = default(ELoadAbOption);
		ab = null;
		isAb = default(bool);
		streamAb = null;
		return false;
	}

	private string GetResourcePath(ResourceID resourceID, string respath, short indexer)
	{
		return null;
	}

	private string GetResourcePath(ResourceID resourceID, uint index, bool compact)
	{
		return null;
	}

	private MNMBLBKENMK GetDefaultQuality(MNMBLBKENMK quality, bool isIngameCollectionRes)
	{
		return MNMBLBKENMK.High;
	}

	public MNMBLBKENMK GetLobbyResQuality()
	{
		return MNMBLBKENMK.High;
	}

	public bool TryGetResourceConfigABOrUrl(ResourceID resourceID, MNMBLBKENMK quality, out ELoadAbOption opt, out string ab, out string url, out ResourceConfigAB cfg)
	{
		opt = default(ELoadAbOption);
		ab = null;
		url = null;
		cfg = null;
		return false;
	}

	public bool IsLobbyShowHighQualityRes(ResourceID resourceID)
	{
		return false;
	}

	private AssetBundleWithRefs GetResourceBundleWithRefs(string abPath)
	{
		return null;
	}

	public void AddAbRefCount(ERefOwner owner, string ab, short delta)
	{
	}

	public int UnloadUnRefedAbs(ERefOwner owner)
	{
		return 0;
	}

	private void SetAndUsePackedUrls(PackedResconfUrls r)
	{
	}

	private void SetAndUsePackedNames(PackedStrings r, IntervalTree tree)
	{
	}

	private void ClearMemForPackedNameUrls()
	{
	}

	private void ClearPackedUrlAndNames()
	{
	}

	public void OnManualGC(bool emergency)
	{
	}

	private void ResetTicketGen()
	{
	}

	private void RecycleRequest(ResAsyncRequest request)
	{
	}

	private ResAsyncRequest PoolGetRequest(ResourceID resID, string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy, ERefOwner refOwner)
	{
		return null;
	}

	public uint GetResource(uint ticket, ResourceID id, Action<uint, bool, UnityEngine.Object> callback, bool notUsingABForcefully = false, Type type = null, bool noCache = false, bool isPreload = false, LoadPriority loadPriority = LoadPriority.Normal, bool dontDestroy = false, MNMBLBKENMK quality = MNMBLBKENMK.Total)
	{
		return 0u;
	}

	public uint GetResource(uint ticket, string resPath, Action<uint, bool, UnityEngine.Object> callback, bool notUsingABForcefully = false, bool noCache = false, LoadPriority loadPriority = LoadPriority.Normal)
	{
		return 0u;
	}

	public uint GetResourceByNameAndAb(uint ticket, string resPath, string abPath, Action<uint, bool, UnityEngine.Object> callback, bool preload, bool noCache, ERefOwner refOwner, LoadPriority loadPriority = LoadPriority.Normal)
	{
		return 0u;
	}

	public void CancelAsyncResLoad(uint ticket)
	{
	}

	public void UpdateAsyncLoadingRes()
	{
	}

	public void CleanUpAsyncLoadResRequests(bool cleanUpPool = false)
	{
	}

	private void HandlePendingCleanUp()
	{
	}

	private void ClearListWithRecycle()
	{
	}

	private void PumpAsyncResLoadRequestQueue()
	{
	}

	public UnityEngine.Object FindLoadedResource(ResourceID resId)
	{
		return null;
	}

	private UnityEngine.Object FindLoadedResource(string resPath)
	{
		return null;
	}

	private uint EnqueueRequest(uint ticket, string resPath, Action<uint, bool, UnityEngine.Object> callback, ELoadAbOption abOpt, string abPath = "", Type type = null, bool preload = false, bool noCache = false, bool dontDestroy = false, ERefOwner refOwner = ERefOwner.None, ResourceID resID = default(ResourceID))
	{
		return 0u;
	}

	private AsyncOperation GetResourceAsyncImpl(ResAsyncRequest req)
	{
		return null;
	}

	private void OnAsyncGetResCompleted(ResAsyncRequest req)
	{
	}

	private void RecycleRequestV2(ResAsyncRequestV2 request)
	{
	}

	private AsyncOperation ReleaseAsyncOperation(AsyncOperation asyncOp)
	{
		return null;
	}

	private ResAsyncRequestV2.DependenciesLoadState UpdateDependenciesLoadState(ResAsyncRequestV2 req)
	{
		return ResAsyncRequestV2.DependenciesLoadState.Loading;
	}

	private ResAsyncRequestV2 PoolGetRequestV2(ResourceID resID, string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy, ERefOwner refOwner, LoadPriority loadPriority, int resPathHash)
	{
		return null;
	}

	public uint GetResourceV2(uint ticket, ResourceID id, Action<uint, bool, UnityEngine.Object> callback, bool notUsingABForcefully = false, Type type = null, bool noCache = false, bool isPreload = false, LoadPriority loadPriority = LoadPriority.Normal, bool dontDestroy = false, MNMBLBKENMK quality = MNMBLBKENMK.Total)
	{
		return 0u;
	}

	public uint GetResourceV2(uint ticket, string resPath, Action<uint, bool, UnityEngine.Object> callback, bool notUsingABForcefully = false, bool noCache = false, LoadPriority loadPriority = LoadPriority.Normal)
	{
		return 0u;
	}

	public uint GetResourceByNameAndAbV2(uint ticket, string resPath, string abPath, Action<uint, bool, UnityEngine.Object> callback, bool preload, bool noCache, ERefOwner refOwner, LoadPriority loadPriority = LoadPriority.Normal)
	{
		return 0u;
	}

	public void CancelAsyncResLoadV2(uint ticket)
	{
	}

	private void RecordRequestStartTime(ResAsyncRequestV2 req)
	{
	}

	private void RecordDependcyStartTime(ResAsyncRequestV2 req)
	{
	}

	private void ResetAsyncLoadCount()
	{
	}

	private void CheckRequestTimeOut(ResAsyncRequestV2 req)
	{
	}

	public void ProcessPauseTime(bool paused)
	{
	}

	private bool UpdateSingleRequest(ResAsyncRequestV2 req)
	{
		return false;
	}

	public void PauseAsyncLoading()
	{
	}

	public void ResumeAsyncLoading()
	{
	}

	public void SetCallBackTime(uint milliSeconds)
	{
	}

	private void ProcessRequest()
	{
	}

	private void ScheduleLoader(ResAsyncRequestV2 loader)
	{
	}

	public void UpdateAsyncLoadingResV2()
	{
	}

	public void CleanUpAsyncLoadResRequestsV2(bool cleanUpPool = false)
	{
	}

	private void ClearListWithRecycleV2()
	{
	}

	public bool UpdateLoadPriority(uint ticket, LoadPriority loadPriority)
	{
		return false;
	}

	public void EnqueueAsyncCallback(LoadPriority pri, Action<uint, bool, UnityEngine.Object> callback)
	{
	}

	private uint EnqueueRequestV2(uint ticket, string resPath, Action<uint, bool, UnityEngine.Object> callback, ELoadAbOption abOpt, string abPath = "", Type type = null, bool preload = false, bool noCache = false, bool dontDestroy = false, ERefOwner refOwner = ERefOwner.None, LoadPriority loadPriority = LoadPriority.Normal, ResourceID resID = default(ResourceID))
	{
		return 0u;
	}

	private AsyncOperation LoadABWithoutLoadingAssetsAsync(string abPath)
	{
		return null;
	}

	private void GetResconfDependencies(string ab, ref List<string> deps, bool includingSelf = false)
	{
	}

	private bool LoadDependenciesAsync(ResAsyncRequestV2 req)
	{
		return false;
	}

	private void StepToNextAsyncImpl(ResAsyncRequestV2 req)
	{
	}

	private bool IsAbNeededByRequests(string abPath)
	{
		return false;
	}

	private bool OnAssetBundleLoaded(string abPath, bool noDestroy, AsyncOperation asyncOp, ResAsyncRequestV2.ReqState state)
	{
		return false;
	}

	private bool OnAssetBundleLoaded_Web(string abPath, bool noDestroy, UnityWebRequestAsyncOperation cr, ResAsyncRequestV2.ReqState state)
	{
		return false;
	}

	private bool OnAsyncGetResCompleted(ResAsyncRequestV2 req)
	{
		return false;
	}

	public bool GetTicketState(uint ticket, out AsyncOperation op, out byte state, out string abPath)
	{
		op = null;
		state = default(byte);
		abPath = null;
		return false;
	}

	public void PrintAsyncLoadingState()
	{
	}

	public AssetBundle GetLoadedAssetBundle(string abPath)
	{
		return null;
	}

	public static UnityEngine.Object LauncherLoadResource(string path)
	{
		return null;
	}

	public static UnityEngine.Object LauncherLoadLocFont(LocLang lang)
	{
		return null;
	}

	public static UnityEngine.Object LauncherLoadLocABResource(string ABpath, string resPath)
	{
		return null;
	}

	public Texture2D GetOverrideTexture(string path)
	{
		return null;
	}

	public Material GetOverrideMaterial(string path)
	{
		return null;
	}

	public static Texture2D LoadHDTexture(string path)
	{
		return null;
	}

	protected void InitNeedResIDToName()
	{
	}

	private static string GetDisableKey()
	{
		return null;
	}

	private static bool IsOptResconfTxtParseGcEnabled()
	{
		return false;
	}

	private static void SetOptGcInProgress(bool inProgress)
	{
	}

	public bool ParseResourceConf(Type ResID, Type EnumGame, Type EnumMode, bool needLoadOldCsvResID = false)
	{
		return false;
	}

	public void PostParseResconf()
	{
	}

	protected bool ParseResourceConfInternal(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, bool overwrite = false)
	{
		return false;
	}

	private bool ParseResourceConfAsJson(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, bool overwrite = false)
	{
		return false;
	}

	private bool LoadAndAskIsUsingSplitedResconfs()
	{
		return false;
	}

	private void UnloadSplitedResconfs()
	{
	}

	protected bool ParseSplitedResourceConf(Type ResID, Type EnumGame, Type EnumMode, string baseConfPath, List<string> subconfPaths, bool overwrite = false)
	{
		return false;
	}

	private bool ParseResourceAndPreloadConf(Type ResID, Type EnumGame, Type EnumMode, bool overwrite = false)
	{
		return false;
	}

	private bool ParseAllTypeResourceConf(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, bool overwrite = false)
	{
		return false;
	}

	private bool ParseAllTypeResourceConfAsJson(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, bool overwrite = false)
	{
		return false;
	}

	private bool ParsePartialResourceConfAsJson(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, JsonData JObjRoot, List<string> abNames, bool overwrite = false)
	{
		return false;
	}

	private bool ParsePreloadConfAsJson(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, JsonData JObjRoot, bool overwrite = false)
	{
		return false;
	}

	private void parseResourceTag(List<string> abs, Type ResID, JsonData dataWithTag, out string url, out string ab, out string stream_ab, out ELoadAbOption isAB, out string deps, out EResourceConfigLevelSetting lowSetting, out EResourceConfigLevelSetting highSetting, out MethodInfo modifier, out bool nameHashCollided, out bool isIngameCollectionRes, out bool isLobbyShowHighQualityRes)
	{
		url = null;
		ab = null;
		stream_ab = null;
		isAB = default(ELoadAbOption);
		deps = null;
		lowSetting = default(EResourceConfigLevelSetting);
		highSetting = default(EResourceConfigLevelSetting);
		modifier = null;
		nameHashCollided = default(bool);
		isIngameCollectionRes = default(bool);
		isLobbyShowHighQualityRes = default(bool);
	}

	private ResourceID parseAndAddResourceMapping(Type ResID, string strName, string url, string ab, string stream_ab, ELoadAbOption isAB, EResourceConfigLevelSetting lowSetting, EResourceConfigLevelSetting highSetting, MethodInfo modifier, bool needResIDToName, bool overwrite, bool nameHashCollided, bool forAtlas, int abIdx = 0, short compressUrlIndex = -1, bool isBinaryConfig = false, bool encryption = false, bool isIngameCollectionRes = false, bool isLobbyShowHighQualityRes = false)
	{
		return default(ResourceID);
	}

	public void AddResourceMapping(string resPath, ResourceID resourceID)
	{
	}

	public void AddResourceAnoymousMapping(string resName, int hashKey, bool anonymous, ResourceID resourceID, bool nameHashCollided)
	{
	}

	public void AddResconfDependenciesInNeed(string ab, string deps)
	{
	}

	protected void InitNameMappingTree(bool enable)
	{
	}

	private void AddNameMappingToTree(ResourceID IDdefined, string strName)
	{
	}

	private void SaveBackNameMappingCacheValues()
	{
	}

	private int CountNameMappingNames()
	{
		return 0;
	}

	protected void PostAddNameMappingToTree()
	{
	}

	protected void InitPreloadDics()
	{
	}

	private void ParsePreloadResIds(Type EnumGame, Type EnumMode, bool overwrite)
	{
	}

	private void ParsePreloadUmas(Type EnumGame, Type EnumMode, bool overwrite)
	{
	}

	private void AddPreloadList(Type EnumGame, Type EnumMode, List<KeyValuePair<PreloadAssetKey, List<string>>> enumToResNames, Dictionary<PreloadResKey, ResourceID[]> dst, bool forAudio = false, Dictionary<PreloadResKey, PreloadResourceInfo[]> dstcnt = null, Type EnumSubMode = null, bool overwrite = false)
	{
	}

	private static void AddPreloadDic(Dictionary<PreloadResKey, ResourceID[]> dst, Dictionary<PreloadResKey, PreloadResourceInfo[]> dstcnt, int memoryLevel, List<ResourceID> resIDs, ref ResourceID[] resIDArray, ref PreloadResourceInfo[] poolInstResArray, PreloadAssetKey preloadKey, Enum itemEnum, Enum subModeEnum = null, bool overwrite = false)
	{
	}

	private void ParseResNames(List<string> resNames, List<ResourceID> resIDs, bool forAudio = false)
	{
	}

	protected void InitResFieldsDict(Type ResID)
	{
	}

	private FieldInfo GetResFieldInfoByName(string name)
	{
		return null;
	}

	public static List<string> parseJsonStrList(JsonData JObjRoot, string name)
	{
		return null;
	}

	public static List<string> ParseResourceAbNames(JsonData JObjRoot)
	{
		return null;
	}

	private static List<string> ParseStreamNameAbs(JsonData JObjRoot)
	{
		return null;
	}

	private static List<string> ParseStreamAbPathes(JsonData JObjRoot)
	{
		return null;
	}

	private static void ParseStreamAbs(JsonData JObjRoot, ref Dictionary<string, string> dst)
	{
	}

	private bool IsResourceConfInTxtFormat(TextReader tr)
	{
		return false;
	}

	private int ParseResourceConfTxtVersion(string markLine)
	{
		return 0;
	}

	private bool ParseResourceConfAsTxt(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, bool overwrite = false)
	{
		return false;
	}

	private bool ParseAllTypeResourceConfAsTxt(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, bool overwrite = false)
	{
		return false;
	}

	private bool ParsePartialResourceConfAsTxt(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, List<string> abNames, bool overwrite = false)
	{
		return false;
	}

	private static bool TryCreateMutableStringReader(TextReader tr, out TextReaderExt trExt)
	{
		trExt = null;
		return false;
	}

	private static bool TryGetStreamReaderPosition(StreamReader sr, out long position)
	{
		position = default(long);
		return false;
	}

	private static bool TryGetStreamReaderIntField(StreamReader sr, out int value, string[] names)
	{
		value = default(int);
		return false;
	}

	private bool ParsePreloadConfAsTxt(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, bool overwrite = false)
	{
		return false;
	}

	public static List<string> ReadStringList(TextReader tr, string countKey = null)
	{
		return null;
	}

	private static void ReadStringList(TextReader tr, List<string> ret, string countKey = null)
	{
	}

	private static int ReadCountLine(TextReader tr, string countKey = null)
	{
		return 0;
	}

	private void ParseAndAddMember(TextReaderExt tr, Type ResID, List<string> abNames, bool overwrite, bool forAtlas)
	{
	}

	public void ParseResconfHotupdate(Type ResID, Type EnumGame, Type EnumMode)
	{
	}

	private bool DisableStrBytesForBuild()
	{
		return false;
	}

	private void SetStrBytesFlagsForResconfBase(int option)
	{
	}

	private void PrepareStrBytesBeforeAdditionalResconfs()
	{
	}

	private void SetStrBytesFlagsForResconfHotupdate(int option)
	{
	}

	private void PrepareStrBytesForPostParse()
	{
	}

	private bool LoadStrBytes(bool loadNames)
	{
		return false;
	}

	private void ReadResConfig(string configpath, ref List<string> reslist)
	{
	}

	private void InitResourceShortPathList()
	{
	}

	public bool NeedCompressStringFromMemory()
	{
		return false;
	}

	protected string DecompressResourcePath(string resPath, short index = -1)
	{
		return null;
	}

	public ResourceID GetRegionalReplacementResId(ResourceID resId)
	{
		return default(ResourceID);
	}

	public static GameObject InstantByRegionalResId(ResourceID resId, Transform parent = null, bool setPosAndRot = false, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion), MNMBLBKENMK quality = MNMBLBKENMK.Total)
	{
		return null;
	}

	public ResourceID GetOrRegisterResourceID(string resName, string resPath = null, string resABPath = "")
	{
		return default(ResourceID);
	}

	public void AddDependency(string ab, string[] abDependencies)
	{
	}

	public uint GetResourceByNameAndAb(uint ticket, string resPath, string abPath, Action<uint, bool, UnityEngine.Object> callback, bool preload = false, bool noCache = false, bool refOwner = false)
	{
		return 0u;
	}

	public UnityEngine.Object SyncLoadResourceByNameAndAb(string resPath, string abPath)
	{
		return null;
	}

	public void MappingAssetBundleUri(string abPath, string uri)
	{
	}

	public void UnLoadAB(string resPath, bool isDeep = false)
	{
	}

	private void AsyncLoadUGCAssetBundle(string abName, Action<AssetBundle> callback)
	{
	}

	private AssetBundle SyncLoadUGCAssetBundle(string abName)
	{
		return null;
	}

	private DataUGCAsyncAssetBundle GetDataUGCAsyncAssetBundle(string abName)
	{
		return null;
	}

	private IEnumerator CorAsyncLoadUGCAssetBundle(string abName, DataUGCAsyncAssetBundle task)
	{
		return null;
	}

	private void UpdateUGCAsyncLoading()
	{
	}
}
