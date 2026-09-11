using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

public class UIModelUGCDatabase : UIBaseModel
{
	public enum ETableType
	{
		Leaderboard,
		DataStorage
	}

	public class LeaderboardShowMetaData
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<LeaderboardShowHeader> _003C_003E9__8_0;

			internal int _003CInit_003Eb__8_0(LeaderboardShowHeader x, LeaderboardShowHeader y)
			{
				return 0;
			}
		}

		public readonly string WorkshopCode;

		public string LeaderboardName;

		public string AssociationStorageName;

		public bool ShowDataStorage;

		public bool ShowPlatformProfile;

		public bool ShowSelf;

		public List<LeaderboardShowHeader> Headers;

		public LeaderboardShowMetaData(string workshopCode)
		{
		}

		public void Init(WorkshopLeaderboard leaderboard)
		{
		}
	}

	public class LeaderboardShowHeader
	{
		public int ShowIndex;

		public ETableType TableType;

		public uint DataIndex;

		public string ShowName;

		public void CopyFrom(IABCPLLBHCE headerInfo)
		{
		}
	}

	protected class LeaderboardCache
	{
		public WorkshopLeaderboard Leaderboard;

		public WorkshopDataStorage DataStorage;

		public double UpdateTimeMs;

		public readonly string WorkshopCode;

		public LeaderboardCache(string workshopCode)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopLeaderboardContent> _003C_003E9__27_1;

		internal int _003CRequestGetWorkshopLeaderboard_003Eb__27_1(WorkshopLeaderboardContent x, WorkshopLeaderboardContent y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIModelUGCDatabase _003C_003E4__this;

		public string workshopCode;

		internal void _003CRequestGetAssociationDataStorage_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UIModelUGCDatabase _003C_003E4__this;

		public string workshopCode;

		public uint requestID;

		internal void _003CRequestGetWorkshopDataStorageByKey_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public UIModelUGCDatabase _003C_003E4__this;

		public uint requestID;

		internal void _003CRequestGetDataStoragePlatformInfos_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_LeaderboardChanged = 2u;

	public const uint PropID_AssociationDataStorageChanged = 4u;

	public const uint PropID_PlatformInfosChanged = 8u;

	public const uint PropID_DataStorageChanged = 16u;

	private Dictionary<string, WorkshopDataStorage> m_DataStorageDict;

	private Dictionary<ulong, DataStoragePlatformInfo> m_PlatformInfoDict;

	private Dictionary<string, LeaderboardCache> m_LeaderboardCacheDict;

	private UniqueIDGenerator m_RequestIDGenerator;

	private bool m_PlatformLeaderboardSwitch;

	public bool PlatformLeaderboardSwitch
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public WorkshopLeaderboard GetLeaderboardFromCache(string workshopCode, string leaderboardName)
	{
		return null;
	}

	public WorkshopLeaderboardContent GetLeaderboardContentFromCache(string workshopCode, string leaderboardName, string key)
	{
		return null;
	}

	public bool FindLeaderboardContentFromCache(string workshopCode, string leaderboardName, string key, out int index, out WorkshopLeaderboardContent content)
	{
		index = default(int);
		content = null;
		return false;
	}

	public WorkshopDataStorage GetAssociationDataStorageFromCache(string workshopCode, string sheetName)
	{
		return null;
	}

	public WorkshopDataStorageContent GetDataStorageContentByKey(string workshopCode, string sheetName, string key)
	{
		return null;
	}

	public DataStoragePlatformInfo GetPlatformInfo(ulong accountId)
	{
		return null;
	}

	public bool HasPlatformInfo(ulong accountId)
	{
		return false;
	}

	public void ClearLeaderboardCache(string workshopCode, string leaderboardName)
	{
	}

	public string DatabaseDataToString(BEPEOKLEMIP data)
	{
		return null;
	}

	public void RequestGetWorkshopLeaderboard(string workshopCode, string leaderboardName)
	{
	}

	public void RequestGetAssociationDataStorage(string workshopCode, string sheetName, IEnumerable<WorkshopLeaderboardContent> leaderboardItor)
	{
	}

	public uint RequestGetWorkshopDataStorageByKey(string workshopCode, string sheetName, string keyStr)
	{
		return 0u;
	}

	public uint RequestGetDataStoragePlatformInfos(List<ulong> accountIds)
	{
		return 0u;
	}

	public DataStoragePlatformInfo ToPlatformInfo(BaseProfileInfo info)
	{
		return null;
	}

	protected LeaderboardCache GetLeaderboardCache(string workshopCode, string leaderboardName)
	{
		return null;
	}

	private string GetCacheKey(string workshopCode, string tableName)
	{
		return null;
	}

	private void _003CRequestGetWorkshopLeaderboard_003Eb__27_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
