using System;
using System.Collections.Generic;
using tcp;

namespace COW;

public class CSBPContext : IDisposable
{
	private CSBPStateMachine m_StateMachine;

	private List<RoomPlayerInfo> m_LeftRoomPlayerInfos;

	private Dictionary<ulong, RoomPlayerInfo> m_LeftRoomPlayerInfosMap;

	private List<RoomPlayerInfo> m_RightRoomPlayerInfos;

	private Dictionary<ulong, RoomPlayerInfo> m_RightRoomPlayerInfosMap;

	private HashSet<uint> m_UnavailableSkills;

	private uint m_LeftTeamBannedSkill;

	private uint m_RightTeamBannedSkill;

	private uint m_LeftTeamSelectedBanSkill;

	private uint m_RightTeamSelectedBanSkill;

	private List<ulong> m_NextPickPlayerIds;

	private List<ulong> m_CurrentChoosingPlayerIds;

	private ulong m_PhaseEndServerTime;

	private ulong m_LocalPlayerId;

	private ulong m_LocalTeamId;

	private bool m_IsObserver;

	private int m_PerTeamPlayerCount;

	private bool m_LockedSkill;

	private uint m_LockedSkillID;

	private List<uint> m_PickedSkillIDs;

	private ulong m_OrderTime;

	private int m_CurrentRound;

	private List<RoomBPPlayerPreSelectInfo> m_PreSelectInfos;

	private List<RoomBPPlayerPickedSkill> m_PickedSkills;

	public List<RoomPlayerInfo> LeftRoomPlayerInfos => null;

	public Dictionary<ulong, RoomPlayerInfo> LeftRoomPlayerInfosMap => null;

	public List<RoomPlayerInfo> RightRoomPlayerInfos => null;

	public Dictionary<ulong, RoomPlayerInfo> RightRoomPlayerInfosMap => null;

	public ulong LocalPlayerId => 0uL;

	public ulong LocalTeamId => 0uL;

	public bool IsObserver => false;

	public int PerTeamPlayerCount => 0;

	public ECSBPPhase CurrentPhase => ECSBPPhase.None;

	public uint LeftTeamBannedSkill => 0u;

	public uint RightTeamBannedSkill => 0u;

	public uint LeftTeamSelectedBanSkill => 0u;

	public uint RightTeamSelectedBanSkill => 0u;

	public List<ulong> NextPickPlayerIds => null;

	public List<ulong> CurrentChoosingPlayerIds => null;

	public List<uint> PickedSkillIDs => null;

	public ulong OrderTime => 0uL;

	public List<RoomBPPlayerPreSelectInfo> PreSelectInfos => null;

	public List<RoomBPPlayerPickedSkill> PickedSkills => null;

	public void Init(ulong localPlayerId, ulong localTeamId, bool isObserver, int perTeamPlayerCount)
	{
	}

	public void Dispose()
	{
	}

	public void SetPhaseEndTime(ulong serverTime)
	{
	}

	public void InitPlayerData()
	{
	}

	public float GetRemainingSeconds()
	{
		return 0f;
	}

	public ulong GetPhaseEndServerTime()
	{
		return 0uL;
	}

	public bool IsLocalPlayer(ulong playerId)
	{
		return false;
	}

	public RoomPlayerInfo GetPlayerData(ulong playerId)
	{
		return null;
	}

	public bool IsTeammate(ulong playerId)
	{
		return false;
	}

	public bool IsLocalPlayerTeamLeader()
	{
		return false;
	}

	public void RefreshPlayerOrder(RoomBPPhaseInfo phaseInfo)
	{
	}

	public void HelpPickChangeOrder(List<RoomBPOrderInfo> pickOrder)
	{
	}

	public bool IsCurrentChoosingPlayer(ulong playerId)
	{
		return false;
	}

	public bool IsTeammmateCurrentBan()
	{
		return false;
	}

	public void RefreshBanPreResult(RoomBPSkillOperateNtf resData)
	{
	}

	public void RefreshBanResult(RoomBPSkillOperateNtf resData)
	{
	}

	public void ReconnectSyncBanResult(List<RoomBPBannedSkillInfo> bannedSkills)
	{
	}

	public void RefreshPickResult(RoomBPSkillOperateNtf resData)
	{
	}

	public void ReconnectSyncPickResult(List<RoomBPPlayerPickedSkill> pickedSkills)
	{
	}

	public void RefreshShowBanResult(RoomBPPhaseInfo phaseInfo)
	{
	}

	public void RefreshOrderTime(ulong serverTime)
	{
	}

	public void RefreshPreSelectInfos(List<RoomBPPlayerPreSelectInfo> preSelectInfos)
	{
	}

	public void RefreshPickedSkills(List<RoomBPPlayerPickedSkill> pickedSkills)
	{
	}

	public bool IsTeammatePickingSkill()
	{
		return false;
	}

	public bool NeedShowPhaseChangeUI()
	{
		return false;
	}

	public string GetPhaseNameLabel()
	{
		return null;
	}

	public bool NeedShowMiddleSkillList()
	{
		return false;
	}

	public void TransitionToPhase(ECSBPPhase phase, ulong phaseEndServerTime)
	{
	}

	public bool CanPerformAction()
	{
		return false;
	}
}
