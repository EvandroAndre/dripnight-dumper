using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

namespace GCommon;

public class ConfigDataManager : SingletonModule<ConfigDataManager>
{
	private delegate void AddInstanceToICollection(CSVBaseData o);

	private sealed class _003C_003Ec__DisplayClass85_0<T> where T : CSVBaseData, new()
	{
		public ICollection<T> result;

		internal void _003CSerializeBinary_003Eb__0(CSVBaseData obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public ICollection<CSVBaseData> result;

		internal void _003CSerializeBinary_003Eb__0(CSVBaseData obj)
		{
		}
	}

	public bool UnLoadNoCacheConfigText;

	public List<Exception> CSVExceptions;

	private static readonly object m_CSVExceptionsSync;

	private Dictionary<int, List<CSVBaseData>> m_ConfigDataLists;

	private Dictionary<int, Dictionary<string, CSVBaseData>> m_ConfigDataItemss;

	private Dictionary<int, Dictionary<string, CSVBaseData>> m_ConfigDataItemssOriginal;

	private Dictionary<int, AnonymousCSVAsyncDataMap> m_AsyncConfigDataItemss;

	private Dictionary<int, ResourceID> m_ConfigLoadResID;

	private Dictionary<ResourceID, bool> m_ResMT;

	private int m_NeedMTResCount;

	private object m_ResourceIDTextDicSync;

	private Dictionary<ResourceID, TextReader> m_ResourceIDTextDic;

	public static int MainThreadId;

	private List<Type> m_CacheTypesNeedsUnload;

	private int m_CompletedWorkItemCount;

	private static int m_WorkItemCount;

	private HashSet<ResourceID> m_ReadBinaryConfig;

	private HashSet<ResourceID> m_EncyptionConfig;

	private static Dictionary<uint, List<CSVBaseData>> m_MultiThreadConfig;

	private bool MultiThreadContainerAlive;

	public static bool MultiThreadLoadAlive;

	private Queue<ThreadPrama> m_PreloadTaskQueue;

	private bool m_AllTaskAllocated;

	private object m_PreloadTaskLock;

	private static readonly object[] EmptyObjectArray;

	private List<TextReader> m_WaitDisposeReaders;

	public List<UnityEngine.Object> m_WaitUnloadResources;

	private const int DecryptionBufferSize = 61440;

	private byte[] m_DecryptionBuffer;

	public int m_DecryptorBlockSize;

	public ICryptoTransform m_Decryptor;

	private Thread[] m_PreloadCSVThread;

	public bool IsMainThread => false;

	public void AddWaitUnloadResource(UnityEngine.Object resource)
	{
	}

	public void IncrementCompletedWorkItem()
	{
	}

	public void AddException(Exception e)
	{
	}

	public void WaitAllCSVEvent(bool needWarmUp = true)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void InitCsvDecryptionCache()
	{
	}

	public void ReleaseCsvDecryptionCache()
	{
	}

	private byte[] AcquireSharedBuffer()
	{
		return null;
	}

	private void ReleaseSharedBuffer(byte[] buffer)
	{
	}

	public void AddReadBinrayConfigResID(ResourceID resID)
	{
	}

	public void AddEncryptionConfigResID(ResourceID resID)
	{
	}

	public void Clear()
	{
	}

	public TextReader LoadCsvText(ResourceID resID, ref byte[] sharedBuffer)
	{
		return null;
	}

	public TextReader LauncherLoadCsvText(string path, ref byte[] sharedBuffer)
	{
		return null;
	}

	public List<T> LoadCSVNoCache<T>(ResourceID resID, bool isDashboardCheck = false) where T : CSVBaseData, new()
	{
		return null;
	}

	public List<CSVBaseData> LauncherLoadCSVNoCache(Type dataType, string path)
	{
		return null;
	}

	public List<CSVBaseData> LoadCSVNoCache(Type dataType, ResourceID resID)
	{
		return null;
	}

	public List<T> LoadCSVNoCacheCapSize<T>(ResourceID resID) where T : CSVBaseData, new()
	{
		return null;
	}

	public List<T> LoadCSVDataByStream<T>(StreamReader stream) where T : CSVBaseData, new()
	{
		return null;
	}

	public void LoadCSVNoCache<T>(ResourceID resID, ref List<T> result) where T : CSVBaseData, new()
	{
	}

	public void LoadCSVNoCache(Type dataType, ResourceID resID, List<CSVBaseData> result)
	{
	}

	public void LoadCSVNoCache<T>(ResourceID resID, Dictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
	}

	public void LoadCSVNoCacheCapSize<T>(ResourceID resID, out List<T> result) where T : CSVBaseData, new()
	{
		result = null;
	}

	public void LoadCSVNoCacheCapSize<T>(ResourceID resID, out Dictionary<uint, T> result, int capsize = 0) where T : CSVBaseData, IGetId, new()
	{
		result = null;
	}

	public void LoadCSVNoCacheCapSize<T>(ResourceID resID, out IntervalTreeDic<T> result, bool sorted, int capsize = 0) where T : CSVBaseData, IGetId, new()
	{
		result = null;
	}

	public void LoadCSV(Type dataType, ResourceID resID)
	{
	}

	public void SetCacheTypesNeedsUnload(ref List<Type> CacheTypes)
	{
	}

	private bool IsCacheTypesNeedsUnload(Type t)
	{
		return false;
	}

	public List<CSVBaseData> GetDataList<T>() where T : CSVBaseData
	{
		return null;
	}

	public List<CSVBaseData> GetDataList(Type dataType)
	{
		return null;
	}

	public Dictionary<string, CSVBaseData> GetDataDictionary<T>() where T : CSVBaseData
	{
		return null;
	}

	public Dictionary<string, CSVBaseData> GetDataDictionary(Type dataType)
	{
		return null;
	}

	public T GetData<T>(string key) where T : CSVBaseData
	{
		return null;
	}

	private static string GetDataListsKey(Type dataType)
	{
		return null;
	}

	public void OverwriteData<T>(string key, T data) where T : CSVBaseData
	{
	}

	public void CleanOverwriteData()
	{
	}

	private string GetDataItemKey<T>(string pKey) where T : CSVBaseData
	{
		return null;
	}

	public static List<T> ParseCSV<T>(string csvText) where T : CSVBaseData, new()
	{
		return null;
	}

	public static List<CSVBaseData> ParseCSV(Type dataType, string csvText)
	{
		return null;
	}

	public static List<T> ParseCSV<T>(TextReader csvText) where T : CSVBaseData, new()
	{
		return null;
	}

	public static List<CSVBaseData> ParseCSV(Type dataType, TextReader csvText)
	{
		return null;
	}

	public static List<T> ParseCSVCapSize<T>(TextReader csvText) where T : CSVBaseData, new()
	{
		return null;
	}

	private static int LineCount(string str)
	{
		return 0;
	}

	public static void ParseCSV<T>(TextReader csvText, out List<T> result) where T : CSVBaseData, new()
	{
		result = null;
	}

	public static void ParseCSV<T>(TextReader reader, ICollection<T> result) where T : CSVBaseData, new()
	{
	}

	public static void ParseCSV(Type dataType, TextReader reader, ICollection<CSVBaseData> result)
	{
	}

	public static void ParseCSV<T>(TextReader csvText, out Dictionary<uint, T> result, int capSize) where T : CSVBaseData, IGetId, new()
	{
		result = null;
	}

	public static void ParseCSV<T>(TextReader reader, IDictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
	}

	public static void SerializeBinary<T>(StreamReader reader, IDictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
	}

	public static void SerializeBinary<T>(StreamReader reader, out Dictionary<uint, T> result, int capSize) where T : CSVBaseData, IGetId, new()
	{
		result = null;
	}

	private static void SerializeBinary(Type dataType, StreamReader reader, AddInstanceToICollection addToCollectionFunc)
	{
	}

	private static string DeserializeExceptionMessage(Type dataType, Exception e)
	{
		return null;
	}

	public static void SerializeBinary<T>(StreamReader reader, ICollection<T> result) where T : CSVBaseData, new()
	{
	}

	public static void SerializeBinary(Type dataType, StreamReader reader, ICollection<CSVBaseData> result)
	{
	}

	public T LoadScriptObject<T>(ResourceID resID) where T : ScriptableObject
	{
		return null;
	}

	private void UnLoadCachedConfigByDataType(Type _type)
	{
	}

	public void UnloadCachedConfigs(List<Type> typeList)
	{
	}

	public void UnLoadCSVManually<T>()
	{
	}

	public void ReloadCachedConfigs(List<Type> typeList)
	{
	}

	public void ProcessCSVText(ResourceID resID, Type type, TextReader csvText)
	{
	}

	private void AsyncLoadAnnoymousCSV(ResourceID resID, Type type)
	{
	}

	public void AddCSVText(ResourceID resID, TextReader reader)
	{
	}

	public void RemoveCSVText(ResourceID resID)
	{
	}

	private bool IsCSVLoaded(Type _type)
	{
		return false;
	}

	private void AddLoadedCSV(Type _type, ResourceID resID, ref List<CSVBaseData> result)
	{
	}

	private void AddItemss(Type _type, out Dictionary<string, CSVBaseData> tmpDic)
	{
		tmpDic = null;
	}

	public void MultiThreadPreloadCSVData(List<KeyValuePair<ResourceID, Type>> preloadCSVInfo, Action mainThreadWork, bool Wait = true)
	{
	}

	public void ReleaseMultiThreadConfigMemory()
	{
	}

	private void InitPreloadWork(int configCount)
	{
	}

	private void EndPreloadWork()
	{
	}

	private void AllocateWork(List<KeyValuePair<ResourceID, Type>> preloadCSVInfo)
	{
	}

	private void PrepareThread()
	{
	}

	private void ReleaseThread(Thread[] threadContainer)
	{
	}

	private void PreloadCSVDataWork()
	{
	}

	private void EnqueuePreloadTaskQueue(ThreadPrama param)
	{
	}

	private ThreadPrama DequeuePreloadTaskQueue()
	{
		return null;
	}

	private static List<T> GetCSVListFromMultiThreadLoad<T>(uint resourceID) where T : CSVBaseData, new()
	{
		return null;
	}

	private static List<CSVBaseData> GetCSVListFromMultiThreadLoad(uint resourceID)
	{
		return null;
	}

	private bool GetCSVDictFromMultiThreadLoad<T>(uint resourceID, IDictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
		return false;
	}

	private static Dictionary<uint, T> GetCSVDictFromMultiThreadLoad<T>(uint resourceID) where T : CSVBaseData, IGetId, new()
	{
		return null;
	}

	private void AddPreloadCSVToLoadedContainer(Type dataType, List<CSVBaseData> preloadResult, uint resID)
	{
	}

	private void LoopCallAfterParseData<T>(List<T> result) where T : CSVBaseData
	{
	}

	private void LoopCallAfterParseData<T>(ICollection<T> result) where T : CSVBaseData
	{
	}

	private static bool CallAfterParseData(CSVBaseData data, int lineIndex)
	{
		return false;
	}

	public bool IsBinaryCSV(uint resID)
	{
		return false;
	}

	public bool IsEncyptionCSV(uint resID)
	{
		return false;
	}
}
