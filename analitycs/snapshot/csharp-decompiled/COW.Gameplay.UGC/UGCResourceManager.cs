using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using GCommon;
using ICSharpCode.SharpZipLib.GZip;
using TsiU;
using UnityEngine;
using UnityEngine.Networking;
using message;

namespace COW.Gameplay.UGC;

public class UGCResourceManager : TSingleton<UGCResourceManager>
{
	public class RegisterResource
	{
		public OLEDMLOHNFH item;

		public UGCResourcePackage ownerPackage;

		public bool isFreeMemory;

		public int dataSize;

		public int FreeMemory()
		{
			return 0;
		}
	}

	public class MemProfileData
	{
		public float TotalPackageDataSize;

		public float TotalUnzipPackageDataSize;

		public int PackageCount;

		public int CreateWidgetCount;

		public int CallParentEntityIDChangedCount;

		private Dictionary<int, int> m_bytesByResType;

		public override string ToString()
		{
			return null;
		}

		public void ClearWidgetProfile()
		{
		}

		public void LogWidgetProfile()
		{
		}

		public void Add(IHDACHNBFNG resType, int bytesLength)
		{
		}

		public void DumpBytesByResType()
		{
		}

		public string _003C_003EiFixBaseProxy_ToString()
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<bool, UGCResource> _003C_003E9__39_0;

		internal void _003CRegisterPackageResource_003Eb__39_0(bool succ, UGCResource resObj)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__47<T> where T : UGCResource, new()
	{
		public static readonly _003C_003Ec__47<T> _003C_003E9;

		public static Action<bool, UGCResource> _003C_003E9__47_1;

		internal void DGJCHMOEHAD(bool ENAJKKKKKDJ, UGCResource NNMLOLJLPAI)
		{
		}
	}

	private sealed class PLJKPOHGLCL<T> where T : UGCResource, new()
	{
		public UGCResourceManager KOKNHFGCGLN;

		public T ALJPNDAMMFD;

		public Action<bool> DPEDCHIGDDB;

		internal void ANHHGPGPAFI(bool DNGDMCBFMNJ)
		{
		}
	}

	private sealed class KNMGCMPDPBN<T> where T : UGCResource
	{
		public UGCResourceManager KOKNHFGCGLN;

		public T AOFCDPKJKJO;

		internal void JEIIBFIAJAN(bool DNGDMCBFMNJ)
		{
		}

		internal void HEAOEMGPLKL(uint GGAOIPIHOBP, bool LKFAPKCNACC, UnityEngine.Object KMOGBCDKPBI)
		{
		}

		internal void LIBNFGALICO(OLEDMLOHNFH GEGFOFMMNKH)
		{
		}

		internal void OKCBFFHIKKO(byte[] GIDHLAALPCO, Exception HDMEPAPIGJG)
		{
		}
	}

	private sealed class GDIEKAPBKIJ<T> where T : UGCResource
	{
		public bool HKNCFOBPHNG;

		public KNMGCMPDPBN<T> EDIPCAMGBNP;

		internal void BIBIDLNNHML(uint PFIHDHGJNLO, bool PCGMOOHAIDE, UnityEngine.Object HIMIPILNHMA)
		{
		}
	}

	private sealed class NLJBDBBGOFP<T> where T : UGCResource
	{
		public string GBPPBICNIKB;

		public GDIEKAPBKIJ<T> HIDGOLEIPLE;

		internal void PAAEKOKLIJD(uint PFIHDHGJNLO, bool PCGMOOHAIDE, UnityEngine.Object HIMIPILNHMA)
		{
		}
	}

	private sealed class CNAINCMOOGF
	{
		public UGCResource PIHDCIMLLGB;

		internal void LEFMMDGKMPM(uint GGAOIPIHOBP, bool LKFAPKCNACC, UnityEngine.Object KMOGBCDKPBI)
		{
		}
	}

	private sealed class GACLFJKIBIE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public UGCResourcePackage PONNHPBPFMA;

		public bool CKPKFMNHMOP;

		public UGCResourceManager KOKNHFGCGLN;

		private UnityWebRequest LGHHFGDOHNF;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public GACLFJKIBIE(int CBPPJACCGOH)
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

		private void FCCDBLLBMAO()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003Ccor_unload_resource_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003Ccor_unload_resource_003Ed__31(int _003C_003E1__state)
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

	public static string UrlTag_AbsUrl;

	public static string UrlTag_RelationUrl;

	private bool m_isEnableResourceChangeNotify;

	private bool m_isLoadAssetBundleAsync;

	private UGCResFFConfigs m_configs;

	private Dictionary<string, RegisterResource> UUID2PackageItem;

	private Dictionary<string, UGCResource> m_loadedResource;

	private Dictionary<string, UGCResource> m_virtualResource;

	private List<GameObject> DelegateObjectList;

	private List<UGCICodeResourcePackage> m_codePackageList;

	private UGCMaterial m_defaultMaterial;

	private UGCResourcePackage m_defaultResourcePackage;

	private Material m_virtualMaterial;

	private MonoBehaviour m_corObject;

	private Dictionary<string, UGCResourcePackage> m_loadedResourcePackage;

	private MemoryStream m_sharedWriteStream;

	private GZipInputStream m_sharedGZipStream;

	public MemProfileData m_memoryProfile;

	private int m_dynamicWebPackageID;

	private Dictionary<string, UGCResourcePackage> DynamicWebPackageMap;

	private Dictionary<object, Dictionary<string, string>> m_ResourceUsingMap_NameOrUUID;

	private Dictionary<object, Dictionary<string, ResourceID>> m_ResourceUsingMap_ResourceID;

	private List<UGCResourceLoadChunk> m_resLoadChunkList;

	private int m_totalResourceBytes;

	private int m_totalLoadedResourceBytes;

	private int m_realTotalResourceBytes;

	public static string PlatformIdentifier => null;

	public static string PlatformSubFileID => null;

	public static string PackageSubFileID => null;

	public static MHBFLGIMEPL PackagePlatformRequire => MHBFLGIMEPL.EFPRSkip;

	public static int CurrentLanguageMask => 0;

	public bool IsUseWebFile => false;

	public bool EnableRuntimeChange => false;

	public UGCResFFConfigs Configs => null;

	public MonoBehaviour CoroutinueObject => null;

	public MemoryStream ShareWriteStream => null;

	public void Init(MonoBehaviour coroutinueRoot, bool enableResourceChangeNotify = true)
	{
	}

	public void AddDelegateGO(GameObject go)
	{
	}

	public static void Cleanup()
	{
	}

	public void ClearAllPackage()
	{
	}

	private IEnumerator cor_unload_resource()
	{
		return null;
	}

	public Material GetVirtualMaterial()
	{
		return null;
	}

	private void InitDefaultResource()
	{
	}

	public void InitForStart(List<DEEOIEHKGLM> policyList)
	{
	}

	public void RegisterCodePackage(UGCResourcePackage package, UGCICodeResourcePackage codePackage)
	{
	}

	public void RegisterPackageResource(UGCResourcePackage package)
	{
	}

	public void UpdateOrAddPackageItem(UGCResourcePackage package, OLEDMLOHNFH item)
	{
	}

	public void ReleaseItemMemoryAndResource(string uuid)
	{
	}

	public OLEDMLOHNFH GetResourceDataByUUID(string uuid)
	{
		return null;
	}

	public List<OLEDMLOHNFH> GetResourceDataByType(IHDACHNBFNG resourceType)
	{
		return null;
	}

	public T GetOrAddVirtualResource<T>(string uuid, out bool isAddNew) where T : UGCResource, new()
	{
		isAddNew = default(bool);
		return null;
	}

	public T LoadResourceByUUID<T>(string uuid, Action<bool, T> callback, IUGCResourceLoadParams loadParams = null) where T : UGCResource, new()
	{
		return null;
	}

	public T LoadResourceByUUIDAsync<T>(string uuid, Action<bool, T> callback) where T : UGCResource, new()
	{
		return null;
	}

	private T LoadResourceByUUIDInternal<T>(string uuid, Action<bool, T> callback, bool useVFSAsync, IUGCResourceLoadParams loadParams = null) where T : UGCResource, new()
	{
		return null;
	}

	public List<UGCResource> GetLoadedResources()
	{
		return null;
	}

	private void invokeLoadCallback<T>(bool isSucc, T res) where T : UGCResource
	{
	}

	public void ReloadResource<T>(T res, string uuid, Action<bool, T> callback) where T : UGCResource
	{
	}

	public void ReloadResourceAsync<T>(T res, string uuid, Action<bool, T> callback) where T : UGCResource
	{
	}

	private void ReloadResourceInternal<T>(T res, string uuid, Action<bool, T> callback, bool useVFSAsync) where T : UGCResource
	{
	}

	public void ForceReloadFFBuildinResource<T>(T res, string uuid, Action<bool, T> callback) where T : UGCResource
	{
	}

	public UGCResourcePackage GetLoadedPackage(string packageUUID)
	{
		return null;
	}

	public GZipInputStream GetShareGZipStream(MemoryStream srcStream)
	{
		return null;
	}

	private void ClearSharedStream()
	{
	}

	public void BeginLoadAllPackage()
	{
	}

	public void EndLoadAllPackage()
	{
	}

	public UGCResourcePackage LoadRawResourcePackage(byte[] packageData, string localFilePath)
	{
		return null;
	}

	public UGCResourcePackage LoadFromVFSPackageMemory(byte[] vfsData)
	{
		return null;
	}

	public UGCResourcePackage LoadVFSPackage(string packageUUID, string localFilePath)
	{
		return null;
	}

	public UGCResourcePackage LoadResourcePackage(JBBDIJHHPLK packageData, string localFilePath)
	{
		return null;
	}

	private IEnumerator CorLoadPackageFromWeb(UGCResourcePackage package, bool isReload = false)
	{
		return null;
	}

	public void ReloadPackageResourceIfLoaded(UGCResourcePackage package)
	{
	}

	public void MarkResourceChanged(object target, string subLabel, string resNameOrUUID)
	{
	}

	public void MarkResourceChanged(object target, string subLabel, ResourceID resId)
	{
	}

	public bool IsResourceChanged(object target, string fieldLabel, string resNameOrUUID)
	{
		return false;
	}

	public void ClearCustomResourceUsingMap()
	{
	}

	public void loadPolicy(List<DEEOIEHKGLM> policyList)
	{
	}
}
