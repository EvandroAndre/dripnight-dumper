using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class KillCamManager : SingletonModule<KillCamManager>
{
	public class ReportData
	{
		public ulong UserID;

		public BHGGAEEHJCO PlayerID;

		public string NickName;

		public int MainReasonIndex;

		public List<int> SubReasonIndex;
	}

	private sealed class _003CFinalShotDelayCo_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KillCamManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFinalShotDelayCo_003Ed__105(int _003C_003E1__state)
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

	private static readonly string DATA_PATH;

	private Queue<KillCamData> m_KillCamDataQueue;

	private List<byte> m_KillCamDataByteList;

	private int m_KillCamDataByteListReadPos;

	private bool m_DataReady;

	private uint m_KillCamTimeMS;

	private bool m_IsKillCamShowing;

	private ulong m_KillCamKillID;

	private int m_FirstMsgTime;

	private int m_LastMsgTime;

	private uint m_BaseTime;

	private uint m_DestTime;

	private uint m_DeathTips;

	private bool m_IsKillData;

	private EKillCamState m_CurState;

	private bool m_CurMatchKillCamEnabled;

	private bool m_CurMatchAutoKillCamEnabled;

	private float m_CurMatchAutoKillCamDelayTime;

	private bool m_HasReqStartKillCam;

	private bool m_HasReqEndKillCam;

	private uint m_EnterKillCamCount;

	private bool m_DebugEnableKillCamDump;

	private MemoryStream m_KillCamMemoryStream;

	private FastBinaryReader m_KillCamBinaryReader;

	private float m_LastRevivedTime;

	private const string DEATH_REPLAY_VOICE_FALLBACK_LANG = "en";

	private Dictionary<uint, DeathReplayTips> m_DeathReplayTipsDic;

	private Dictionary<uint, Dictionary<string, ResourceID>> m_DeathReplayTipVoiceDic;

	private byte[] m_KillCamTmpByteArray;

	private static float nextClearResRefTime;

	private uint m_SelfPlayerID;

	private ulong m_SelfUserID;

	private uint m_DamagerPlayerID;

	private bool m_HasMatchEnd;

	private KillCamData m_CachedMatchEndData;

	private int m_LatestEnterStage;

	private ReportData m_CachedReportData;

	private IEnumerator m_CurrentRunningCo;

	protected override void OnInit()
	{
	}

	private void CacheDeathReplayTipVoice(DeathReplayTips tip)
	{
	}

	private static string GetDeathReplayVoiceLang(string voiceName)
	{
		return null;
	}

	private static string GetCurrentDeathReplayVoiceLang()
	{
		return null;
	}

	private static string NormalizeDeathReplayVoiceLang(string lang)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	public void SetState(EKillCamState state)
	{
	}

	public void ResetState()
	{
	}

	public bool IsDuringSwitchState()
	{
		return false;
	}

	public bool IsPlayToKillCam()
	{
		return false;
	}

	public bool IsKillCamToPlay()
	{
		return false;
	}

	public void OnRecKillCamData(MMMIKMNGICH result, List<byte> data, bool isKillCam)
	{
	}

	private void FillKillCamDataWithQueue()
	{
	}

	private void FillKillCamDataNoQueue()
	{
	}

	private void EnqueueCamData(KillCamData data)
	{
	}

	public void StartKillCam()
	{
	}

	public void StopKillCam()
	{
	}

	public void GetKillCamPackets(List<UDPMsgPacket> outPackets)
	{
	}

	private void FillPacketsWithQueue(List<UDPMsgPacket> outPackets)
	{
	}

	private void FillPacketsNoQueue(List<UDPMsgPacket> outPackets)
	{
	}

	public bool IsJumping()
	{
		return false;
	}

	public bool IsKillCamShowing()
	{
		return false;
	}

	public void OnStarted()
	{
	}

	public void OnEnded()
	{
	}

	public void RequestKillCam()
	{
	}

	public void UnLoadUnusedAssets()
	{
	}

	public void GarbageCollection()
	{
	}

	public void SetKillCamConfig(bool enabled, bool autoKillCam, float delayTime)
	{
	}

	public bool IsKillCamEnabled()
	{
		return false;
	}

	public bool IsAutoKillCamEnabled()
	{
		return false;
	}

	public float AutoKillCamDelayTime()
	{
		return 0f;
	}

	public void RecordKillCamInfo(BHGGAEEHJCO damagePlayerID, int weaponDataID)
	{
	}

	public bool IsSelf(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public uint GetSelfPlayerID()
	{
		return 0u;
	}

	public ulong GetSelfUserID()
	{
		return 0uL;
	}

	public uint GetDamagerPlayerID()
	{
		return 0u;
	}

	public bool KilledByOthers()
	{
		return false;
	}

	public void SetLastRevivedTime()
	{
	}

	public bool IsRevivedRecently()
	{
		return false;
	}

	public bool InWhiteList(uint message)
	{
		return false;
	}

	public UDPMsgPacket CloneData(UDPMsgPacket packet)
	{
		return null;
	}

	public void SetMatchEndBeforeKillCam(bool end, UDPMsgPacket packet)
	{
	}

	public void SetMatchEndDuringKillCam(bool end, UDPMsgPacket packet)
	{
	}

	public void ForceHandleMatchEndMsg()
	{
	}

	private void ForceHandleMatchEndMsgWithQueue()
	{
	}

	private void ForceHandleMatchEndMsgNoQueue()
	{
	}

	public bool IsMatchEnd()
	{
		return false;
	}

	public void OnLocalShowMatchEnd()
	{
	}

	public FastBinaryReader GetKillCamBinaryReader()
	{
		return null;
	}

	public MemoryStream GetKillCamMemoryStream()
	{
		return null;
	}

	public void SetLatestEnterStage(int stage)
	{
	}

	public int GetLatestEnterStage()
	{
		return 0;
	}

	public uint GetPlayedTimes()
	{
		return 0u;
	}

	public void SetReportData(ReportData data)
	{
	}

	public ReportData GetReportData()
	{
		return null;
	}

	public void ClearReportData()
	{
	}

	public bool HasPendingDeathDetail()
	{
		return false;
	}

	public uint GetDeathDetail()
	{
		return 0u;
	}

	public void SetDeathDetail(uint deathTips)
	{
	}

	private bool IsDeathDetailHiddenByRank()
	{
		return false;
	}

	private bool HasReachedDeathDetailBRRankRequirement()
	{
		return false;
	}

	private bool HasReachedDeathDetailCSRankRequirement()
	{
		return false;
	}

	public DeathReplayTips GetDeathDetailConfig()
	{
		return null;
	}

	public void PlayDeathDetailVoice()
	{
	}

	private ResourceID GetDeathDetailVoiceResourceID()
	{
		return default(ResourceID);
	}

	private void CancelFinalShotDelayCo()
	{
	}

	private IEnumerator FinalShotDelayCo()
	{
		return null;
	}

	public bool IsFinalShot()
	{
		return false;
	}

	public void EnableKillCamDump(bool enable)
	{
	}

	public void DebugSaveKillCamData()
	{
	}

	public void DebugPlayKillCamData(string name, bool skipJump)
	{
	}

	private void DebugCheckPath()
	{
	}

	public void KillCamSimReconnect()
	{
	}
}
