using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW.Gameplay;

internal class MultiplePlayerWereWolvesGame : GAJPGHGIIIK
{
	public enum EChatShowType
	{
		Normal,
		Vote,
		DeadInfo,
		RoundInfo
	}

	public class WereWolvesChatEasyListInfo
	{
		public BHGGAEEHJCO PlayerId;

		public string ChatString;

		public int SendTime;

		public EChatShowType ChatShowType;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<BHGGAEEHJCO, Player>, PlayerWereWolves> _003C_003E9__58_0;

		public static Func<PlayerWereWolves, bool> _003C_003E9__58_1;

		internal PlayerWereWolves _003CGetAlivePlayerCount_003Eb__58_0(KeyValuePair<BHGGAEEHJCO, Player> playerPair)
		{
			return null;
		}

		internal bool _003CGetAlivePlayerCount_003Eb__58_1(PlayerWereWolves wPlayer)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public BHGGAEEHJCO playerId;

		internal bool _003CFilterInvalidChatInfo_003Eb__0(WereWolvesChatEasyListInfo chatInfo)
		{
			return false;
		}
	}

	public Dictionary<int, Color32> PlayerColorMap;

	private EIJKPAKPLMO m_TaskManager;

	private WereWolvesBodyManager m_BodyManager;

	private List<WereWolvesChatEasyListInfo> m_ChatInfos;

	private GFEJDOOEGFB m_VoteManager;

	private Dictionary<string, WereWolvesRoleData> m_RoleMap;

	private List<WereWolvesQuickChatData> m_QuickChatList;

	private Dictionary<uint, WereWolvesQuickChatData> m_QuickChatDataDic;

	private List<WereWolvesQuickChatData> m_QuickChatNoTargetList;

	private List<WereWolvesQuickChatData> m_QuickChatTargetList;

	private float m_LastChatTime;

	private bool m_IsPlayerManualMute;

	private bool m_IsInitedCameraPivot;

	private GameObject m_LocalPlayerCircleEffect;

	private int m_ClientChatRound;

	private AudioResource m_loopAlertSound;

	private List<PreparePhaseCameraPivot> m_PreparePhaseCameraPivotList;

	private CDJJBJOBOKM m_CachedMatchEndInfo;

	public List<WereWolvesChatEasyListInfo> ChatInfos => null;

	public WereWolvesBodyManager BodyManager => null;

	public Dictionary<string, WereWolvesRoleData> RoleDatas => null;

	public JMJGFNCIPMI GameOverFlag => JMJGFNCIPMI.EWereWolvesGameOverState_NoOver;

	public List<WereWolvesQuickChatData> QuickChatList => null;

	public List<WereWolvesQuickChatData> QuickChatNoTargetList => null;

	public List<WereWolvesQuickChatData> QuickChatTargetList => null;

	public bool InChatCD => false;

	public bool IsPlayerManualMute
	{
		set
		{
		}
	}

	public CDJJBJOBOKM CachedMatchEndInfo => null;

	public EIJKPAKPLMO GetTaskManager()
	{
		return null;
	}

	public GFEJDOOEGFB GetVoteManager()
	{
		return null;
	}

	public override Type GetUISceneType()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public override void OnAddPlayer(Player p)
	{
	}

	public override ResourceID[] GetPreloadResourceIDSeq()
	{
		return null;
	}

	public override ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	public override ResourceID[] GetAudioPreloadResourceID()
	{
		return null;
	}

	public override List<int> GetPreloadUmaResource()
	{
		return null;
	}

	private void ChooseLocalPlayerPrepareCameraPivot(Vector3 playerForward)
	{
	}

	private void SpawnLocalPlayerCircleEffect(Transform playerTrans)
	{
	}

	private void InitRoleData()
	{
	}

	public uint GetCurrentWolfCount()
	{
		return 0u;
	}

	public uint GetAllWolfCount()
	{
		return 0u;
	}

	public uint GetCurrentPoint()
	{
		return 0u;
	}

	public uint GetCivilWinPoint()
	{
		return 0u;
	}

	public int GetVoteCenterCDEndTimeMs()
	{
		return 0;
	}

	public int GetGameEndTimeMs()
	{
		return 0;
	}

	public uint GetCurrentPhase()
	{
		return 0u;
	}

	protected override void InitGRIData()
	{
	}

	private void OnPhaseChanged(uint oldValue, uint newValue)
	{
	}

	private void OnPointChanged(uint oldValue, uint newValue)
	{
	}

	public override Player CreatePlayer(Transform container, ulong userID, ulong serviceGroupID, BHGGAEEHJCO playerID, bool isAI = false, object syncInfo = null)
	{
		return null;
	}

	public int GetAlivePlayerCount()
	{
		return 0;
	}

	public void OnKillCDChange(int oldValue, int newValue)
	{
	}

	private void OnAllWolfCountChange(uint oldValue, uint newValue)
	{
	}

	private void OnCurrentWolfCountChange(uint oldValue, uint newValue)
	{
	}

	public void OnSkillCDChange(int oldValue, int newValue)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnDelPlayer(uint data)
	{
	}

	public void OnAddVoteChat(BHGGAEEHJCO playerId, int votedTime, EChatShowType showType, bool needRefresh)
	{
	}

	private void PlayAlertSound()
	{
	}

	private void StopPlayAlertSound()
	{
	}

	public void OnSyncTaskAlert(IPAGKPEAPOG msg)
	{
	}

	public void OnSyncQuickChat(LGGIIHIOOAE msg)
	{
	}

	public void OnSyncChat(POPACCLCJDD msg)
	{
	}

	private int ChatCmp(WereWolvesChatEasyListInfo a, WereWolvesChatEasyListInfo b)
	{
		return 0;
	}

	public void OnSyncVoice(HBALPILFMPO msg)
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	public void RegistPreparePhaseCameraPivot(PreparePhaseCameraPivot pivot)
	{
	}

	private void OnGameOverFlagCome(uint oldValue, uint newValue)
	{
	}

	public void CachMatchEndInfo(CDJJBJOBOKM msg)
	{
	}

	public void RefreshChatCD()
	{
	}

	private void BeginTutorial()
	{
	}

	private void FilterInvalidChatInfo(BHGGAEEHJCO playerId)
	{
	}

	private void InsertRoundInfoToChatInfo()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetUISceneType()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAddPlayer(Player P0)
	{
	}

	public new ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceIDSeq()
	{
		return null;
	}

	public new ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceID()
	{
		return null;
	}

	public new ResourceID[] _003C_003EiFixBaseProxy_GetAudioPreloadResourceID()
	{
		return null;
	}

	public new List<int> _003C_003EiFixBaseProxy_GetPreloadUmaResource()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_InitGRIData()
	{
	}

	public new Player _003C_003EiFixBaseProxy_CreatePlayer(Transform P0, ulong P1, ulong P2, BHGGAEEHJCO P3, bool P4, object P5)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
