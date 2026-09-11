using System;
using System.Collections.Generic;
using System.IO;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class ReplayManager : SingletonModule<ReplayManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ReplayKillEvent> _003C_003E9__69_0;

		internal int _003CGeneratePlayerHighlightEvents_003Eb__69_0(ReplayKillEvent x, ReplayKillEvent y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public ReplayManager _003C_003E4__this;

		public ReplayHighlightEvent firstHighlight;

		internal void _003CSwitchToHighlightType_003Eb__0()
		{
		}
	}

	private const int MS_TO_TICK = 10000;

	private const float S_TO_MS = 1000f;

	private FileStream m_ReplayFileStream;

	private BinaryWriter m_ReplayBinaryWriter;

	private BinaryReader m_ReplayBinaryReader;

	private ReplayData m_ReplayData;

	private ReplayInfo m_CurReplayInfo;

	private long m_GameTotalTimeMS;

	private EReplayState m_CurState;

	private bool m_IsPlayingPlayerHighlight;

	private BHGGAEEHJCO m_CurrentHighlightPlayerID;

	private ulong m_CurrentHighlightUserID;

	private int m_CurrentHighlightIndex;

	private List<ReplayHighlightEvent> m_CurrentPlayingHighlights;

	private int m_CurrentHighlightTypeIndex;

	private List<EHighLightPlayType> m_HighlightTypeOrder;

	private PlayerHighlightInfo m_CurrentPlayerHighlight;

	private bool m_IsSwitchingHighlight;

	private uint m_SwitchingHighlightDelayCall;

	private bool m_IsSingleTypeMode;

	private long m_StartTimeMS;

	private string m_MatchDateTime;

	private Action m_ReplayJumpCallBack;

	private long m_ReplayTimeMS;

	private bool m_Started;

	private Queue<ReplayData> m_ReplayDataQueue;

	private ReplayCamState m_ReplayCamState;

	private bool m_HasMatchEnd;

	private bool m_WaitWriting;

	private List<ReplayInfo> m_CachedReplayInfo;

	private bool m_Changed;

	private bool m_ReplayPaused;

	private int m_CurSpeed;

	private bool m_IsJumping;

	private long m_DestTimeMS;

	private Dictionary<int, float> m_LevelSpeedDic;

	public bool IsJumping => false;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public ReplayInfo GetCurrentReplayInfo()
	{
		return null;
	}

	public void OnStarted()
	{
	}

	public void OnEnded()
	{
	}

	private void OnRecordStarted()
	{
	}

	public void OnMatchEnd()
	{
	}

	public void OnRecordEnded()
	{
	}

	public void RecordPacket(UDPMsgPacket packet)
	{
	}

	public void LogPlayerReplayEvent(uint playerID, uint iEventID, uint serial, uint group, uint time, int weaponDataID, List<string> args, List<uint> del_serial, List<JLHEBAFCAHO> correctionInfos, uint curRound, Vector3 beKilledPlayerPos)
	{
	}

	public float CurTimeSec()
	{
		return 0f;
	}

	private long GetNowTimeMS()
	{
		return 0L;
	}

	private void OnReplayStarted()
	{
	}

	private void OnReplayEnded()
	{
	}

	public void GetReplayPackets(List<UDPMsgPacket> outPackets)
	{
	}

	public ulong GetReplayMatchID()
	{
		return 0uL;
	}

	public List<ReplayInfo> GetReplayList()
	{
		return null;
	}

	private void ReadReplayList()
	{
	}

	public ReplayInfo ReadReplayInfoByFilePath(string filePath)
	{
		return null;
	}

	public void DelReplay(ReplayInfo info)
	{
	}

	public void ResetReplay()
	{
	}

	public void StartReplay(ReplayInfo info)
	{
	}

	public void PauseReplay(bool pause)
	{
	}

	public void SetPlaySpeed(bool fast)
	{
	}

	public void GoToTimePoint(float value, Action callback = null)
	{
	}

	public long CurrentGameTime()
	{
		return 0L;
	}

	public float CurrentGameTimeSec()
	{
		return 0f;
	}

	public float CurrentProgress()
	{
		return 0f;
	}

	public long GetGameTimeMS(float value)
	{
		return 0L;
	}

	public float GetTimeRatio(float time)
	{
		return 0f;
	}

	private void GenerateAllPlayerHighlights()
	{
	}

	private void GeneratePlayerHighlightEvents(PlayerHighlightInfo playerHighlight)
	{
	}

	private void SelectFinalPlayerHighlightType(PlayerHighlightInfo playerHighlight)
	{
	}

	public PlayerHighlightInfo GetPlayerHighlight(ulong userID)
	{
		return null;
	}

	public void StartPlayerHighlight(ulong userId)
	{
	}

	public void StartPlayerHighlightByType(ulong userId, EHighLightPlayType highlightType)
	{
	}

	private void InitHighlightTypeOrder(PlayerHighlightInfo playerHighlight)
	{
	}

	private List<ReplayHighlightEvent> GetHighlightEventsByType(EHighLightPlayType type)
	{
		return null;
	}

	private void SwitchToHighlightType(EHighLightPlayType type)
	{
	}

	private bool TrySwitchToNextHighlightType()
	{
		return false;
	}

	public void NextPlayerHighlight()
	{
	}

	public bool IsPlayingPlayerHighlight()
	{
		return false;
	}

	public int GetCurrentHighlightIndex()
	{
		return 0;
	}

	public int GetTotalHighlightCount()
	{
		return 0;
	}

	public ulong GetCurrentHighlightPlayerID()
	{
		return 0uL;
	}

	public ulong GetCurrentHighlightUserID()
	{
		return 0uL;
	}

	public EHighLightPlayType GetCurrentHighlightType()
	{
		return EHighLightPlayType.None;
	}

	public int GetTotalHighlightTypeCount()
	{
		return 0;
	}

	public int GetCurrentHighlightTypeIndex()
	{
		return 0;
	}

	public void StopPlayerHighlight()
	{
	}

	private void CheckAndSwitchPlayerHighlight()
	{
	}

	public bool IsRecordState()
	{
		return false;
	}

	public bool IsReplayState()
	{
		return false;
	}

	public List<ReplayEvent> GetReplayEventList()
	{
		return null;
	}

	public List<ReplayEvent> GetReplayEvents()
	{
		return null;
	}

	private void _003CGoToTimePoint_003Eb__62_0()
	{
	}
}
