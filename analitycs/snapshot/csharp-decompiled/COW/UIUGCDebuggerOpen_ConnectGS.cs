using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;
using UnityEngine.Networking;
using message;
using tcp;

namespace COW;

public class UIUGCDebuggerOpen_ConnectGS : MonoBehaviour
{
	public class HTTP_CreateRoomResp
	{
		public int RetCode;

		public ulong ServiceRoomID;

		public string ServerAddr;

		public string ErrorString;

		public string Secret;

		public string UDPHeadSecret;

		public uint MapID;

		public uint GameMode;

		public uint GroupMode;

		public string GameDataUrl;

		public uint ResourceLevel;

		public bool IsRejoin;
	}

	public delegate bool RunGameAction(string serverAdd, ulong serviceRoomID, string secret, string udpHeadSecret, uint mapid, uint gamemode, uint groupmode, uint resourceLevel, bool isRejoin);

	private sealed class _003CFetchAllMatchInfoCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string serverIPPort;

		public List<long> matchIDs;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFetchAllMatchInfoCoroutine_003Ed__11(int _003C_003E1__state)
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

	private sealed class _003CGetEntityData_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string serverIPPort;

		public ulong serviceRoomID;

		public string entityID;

		private Uri _003Curl_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetEntityData_003Ed__15(int _003C_003E1__state)
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

	private sealed class _003CStartProfiler_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string serverIPPort;

		public ulong serviceRoomID;

		private Uri _003Curl_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartProfiler_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CStartReqest_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string serverIPPort;

		public byte[] ugcLevelData;

		public ulong accountID;

		public uint mapid;

		public string nickName;

		public uint gamemode;

		public uint groupMode;

		public uint teamIndex;

		public bool isGotoPositionAfterStart;

		public Vector3 gotoPosition;

		public uint clientCount;

		public uint resourceAllowLevel;

		public string localDatabase;

		public uint[] botCountByTeam;

		public long matchid;

		public string mapCDNUrl;

		public bool isStrictMode;

		public string workshopCode;

		public uint activeSkill;

		public int petID;

		public int petSkillID;

		public string localDatabasePath;

		public List<string> breakpoints;

		public List<uint> tokensID;

		public List<uint> tokesnNum;

		public List<uint> tokensValidID;

		public uint gemsCount;

		public int isPremium;

		public RunGameAction runGameAction;

		private Uri _003Curl_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartReqest_003Ed__10(int _003C_003E1__state)
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

	private sealed class _003CWrapFetchAllMatchInfo_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCDebuggerOpen_ConnectGS _003C_003E4__this;

		public string serverIPPort;

		public List<long> matchIDs;

		public Action<List<long>> callback;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWrapFetchAllMatchInfo_003Ed__5(int _003C_003E1__state)
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

	public static ulong LastServiceRoomID;

	public static bool DirectCntGSMode;

	public static bool OnlyRejoin;

	public static UIUGCDebuggerOpen_ConnectGS BeginConnect(string httpIPPort, string mapCDNUrl, long matchid, uint teamid, UGCDebugStartReq req, CLAJGBDHLFE settings, uint activeSkill, int petID, int petSkillID)
	{
		return null;
	}

	public static void FetchAllMatchInfo(string serverIPPort, Action<List<long>> callback = null)
	{
	}

	private IEnumerator WrapFetchAllMatchInfo(string serverIPPort, List<long> matchIDs, Action<List<long>> callback = null)
	{
		return null;
	}

	public static bool LoadGame(string serverAdd, ulong serviceRoomID, string secret, string udpHeadSecret, uint mapid, uint gamemode, uint groupmode, uint resourcelevel, bool isRejoin)
	{
		return false;
	}

	public static bool LoadOfflineGame(string url, uint mapid, uint gamemode, EditorConnectionMode editorConnectionMode = EditorConnectionMode.None, string workshopCode = "", string originalWorkshopCode = "")
	{
		return false;
	}

	public IEnumerator StartReqest(RunGameAction runGameAction, string serverIPPort, ulong accountID, uint mapid, string nickName, uint gamemode, bool isGotoPositionAfterStart, Vector3 gotoPosition, uint[] botCountByTeam, byte[] ugcLevelData, long matchid = 0L, string mapCDNUrl = "", List<string> breakpoints = null, uint groupMode = 0u, uint teamIndex = 0u, bool isStrictMode = false, uint clientCount = 1u, string workshopCode = "", uint activeSkill = 0u, int petID = 0, int petSkillID = 0, List<uint> tokensID = null, List<uint> tokesnNum = null, List<uint> tokensValidID = null, uint resourceAllowLevel = 0u, uint gemsCount = 0u, int isPremium = 0, string localDatabase = null, string localDatabasePath = "")
	{
		return null;
	}

	public IEnumerator FetchAllMatchInfoCoroutine(string serverIPPort, List<long> matchIDs)
	{
		return null;
	}

	public IEnumerator StartProfiler(string serverIPPort, ulong serviceRoomID)
	{
		return null;
	}

	public static string ConvertPropValue2String(object value)
	{
		return null;
	}

	public static UIUGCDebuggerOpen_ConnectGS BeginGetEntityData(string httpIPPort, string entityID)
	{
		return null;
	}

	public IEnumerator GetEntityData(string serverIPPort, ulong serviceRoomID, string entityID)
	{
		return null;
	}

	public static void SendToGetEntityData(string entityID)
	{
	}
}
