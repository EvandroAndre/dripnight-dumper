using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class IngameQuickChatV2Manager : SingletonModule<IngameQuickChatV2Manager>
{
	private struct OccupyingMarkCache
	{
		public Vector3 Position;

		public uint LevelObjectId;

		public OPICPDCLKAG LevelObjectType;
	}

	public enum EQuickChatV2Type
	{
		Normal = 1,
		Enemy,
		Weapon
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BaseLevelObject, bool> _003C_003E9__32_0;

		public static Func<BaseLevelObject, bool> _003C_003E9__33_0;

		public static Func<BaseLevelObject, bool> _003C_003E9__34_0;

		internal bool _003CTryGetNearestOccupyingAirDrop_003Eb__32_0(BaseLevelObject obj)
		{
			return false;
		}

		internal bool _003CTryGetNearestOccupyingTreasury_003Eb__33_0(BaseLevelObject obj)
		{
			return false;
		}

		internal bool _003CTryGetNearestOccupyingRevivePoint_003Eb__34_0(BaseLevelObject obj)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public int tokenAtEnqueue;

		public IngameQuickChatV2Manager _003C_003E4__this;

		public uint sourcePlayerID;

		public uint configID;

		public bool playVoice;

		internal void _003COnReceiveQuickChatV2BroadcastTeam_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public IngameQuickChatV2Manager _003C_003E4__this;

		public uint configID;

		public int tokenAtEnqueue;

		public uint markPointType;

		public Vector3 position;

		public bool playQuickChatSound;

		internal void _003CTriggerSenderMarksOnReceiveBroadcast_003Eb__0()
		{
		}
	}

	private int m_MatchToken;

	private List<InGameQuickChatV2> m_ConfigList;

	private Dictionary<uint, InGameQuickChatV2> m_ConfigIdMap;

	private Dictionary<uint, InGameQuickChatV2> m_ChatIdMap;

	private Dictionary<uint, float> m_LastTriggerTimeMap;

	private float m_LastQuickChatV2VoiceTime;

	private const uint LastMatchStatsConfigIdKills = 1u;

	private const uint LastMatchStatsConfigIdRank = 2u;

	private const uint LastMatchStatsConfigIdReviveTeammate = 3u;

	private const uint HitEnemyConfigId = 19u;

	private const uint CaptainParachuteFrequentPOIConfigId = 29u;

	private const uint CaptainParachuteLastPOIConfigId = 30u;

	private const uint ExcellentBehaviorCabinConfigId = 35u;

	private const uint ExcellentBehaviorCSFirstRoundPrepareConfigId = 36u;

	private Dictionary<uint, Vector3> m_PendingMarkVoicePosition;

	private string m_CaptainParachutePendingPOI;

	private bool m_HasRecordedLandingPOI;

	private Dictionary<uint, OccupyingMarkCache> m_PendingOccupyingMarkData;

	public bool IsEnabled => false;

	private bool HasTeammates()
	{
		return false;
	}

	protected override void OnInit()
	{
	}

	public void ResetMatchState()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void OnReceiveQuickChatV2Trigger(InGameQuickChatV2Message message)
	{
	}

	private void CachePendingMarkDataForBroadcast(uint configID, Vector3 targetPosition)
	{
	}

	private static bool IsAutoPlayConfig(InGameQuickChatV2 config)
	{
		return false;
	}

	public void OnUserConfirmBubbleClick(uint configID, Vector3 targetPosition)
	{
	}

	private bool TryGetOccupyingMarkTriggerType(uint configID, out KIDIOLIHION triggerType)
	{
		triggerType = default(KIDIOLIHION);
		return false;
	}

	private bool TryGetOccupyingTarget(KIDIOLIHION triggerType, Player localPlayer, out Vector3 position, out uint levelObjectId, out OPICPDCLKAG levelObjectType)
	{
		position = default(Vector3);
		levelObjectId = default(uint);
		levelObjectType = default(OPICPDCLKAG);
		return false;
	}

	private bool TryGetNearestOccupyingAirDrop(NAHFMFGGCDN levelObjectManager, Vector3 playerPosition, out Vector3 position, out uint levelObjectId)
	{
		position = default(Vector3);
		levelObjectId = default(uint);
		return false;
	}

	private bool TryGetNearestOccupyingTreasury(NAHFMFGGCDN levelObjectManager, Vector3 playerPosition, out Vector3 position, out uint levelObjectId)
	{
		position = default(Vector3);
		levelObjectId = default(uint);
		return false;
	}

	private bool TryGetNearestOccupyingRevivePoint(NAHFMFGGCDN levelObjectManager, Vector3 playerPosition, out Vector3 position, out uint levelObjectId)
	{
		position = default(Vector3);
		levelObjectId = default(uint);
		return false;
	}

	private bool TryGetNearestOccupyingObject(Dictionary<uint, BaseLevelObject> objects, Vector3 playerPosition, out Vector3 position, out uint levelObjectId, Func<BaseLevelObject, bool> predicate)
	{
		position = default(Vector3);
		levelObjectId = default(uint);
		return false;
	}

	public bool IsAutoMarkTrigger(uint configId)
	{
		return false;
	}

	public InGameQuickChatV2 GetConfigById(uint configId)
	{
		return null;
	}

	public bool IsExcellentBehaviorConfigId(uint configId)
	{
		return false;
	}

	public void CachePendingMarkVoicePosition(uint configId, Vector3 position)
	{
	}

	private static bool IsBRRankingOrCasual()
	{
		return false;
	}

	public void TryTriggerLastMatchStatsQuickChatOnMaskClosed()
	{
	}

	private void TryTriggerLastMatchStatsQuickChat()
	{
	}

	public void TryTriggerExcellentBehaviorQuickChatOnMaskClosed()
	{
	}

	public void TryTriggerExcellentBehaviorQuickChatOnCSFirstRoundPrepare()
	{
	}

	private void TryTriggerExcellentBehaviorQuickChat(uint configId)
	{
	}

	private bool IsLocalPlayerExcellentBehavior()
	{
		return false;
	}

	public ResourceID GetResponseVoiceIDByConfigId(uint configId, uint? sourcePlayerID = null)
	{
		return default(ResourceID);
	}

	private bool ShouldProcessTrigger(byte teamID, uint sourcePlayerID, uint configID)
	{
		return false;
	}

	private void InitQuickChatV2Config()
	{
	}

	public void SendQuickChatV2Request(uint configID)
	{
	}

	private void DispatchTriggerEvent(InGameQuickChatV2Message message)
	{
	}

	private bool CheckIsInCD(uint configID)
	{
		return false;
	}

	private void RecordTriggerTime(uint configID)
	{
	}

	private bool IsNoVoiceConfig(InGameQuickChatV2 config)
	{
		return false;
	}

	private bool IsNoTextConfig(InGameQuickChatV2 config)
	{
		return false;
	}

	public void OnReceiveQuickChatV2BroadcastTeam(byte teamID, uint sourcePlayerID, uint configID, bool playVoice)
	{
	}

	private void TriggerSenderMarksOnReceiveBroadcast(uint configID, bool playVoice)
	{
	}

	private void TryPlayResponseVoice(uint configID, uint? sourcePlayerID = null)
	{
	}

	private bool IsCaptainParachutePOIModeMatched()
	{
		return false;
	}

	private bool IsConfigModeMatchedByID(uint configID)
	{
		return false;
	}

	private bool IsConfigModeMatched(InGameQuickChatV2 config)
	{
		return false;
	}

	private static bool IsModeListMatched(uint[] modeList, uint currentMode)
	{
		return false;
	}

	public void TryTriggerCaptainParachutePOIQuickChatOnMaskClosed()
	{
	}

	private void TryTriggerCaptainParachutePOIQuickChat()
	{
	}

	private void OnTeamParachuteModeChangeForQuickChat(object[] param)
	{
	}

	private void OnLocalTeammateAddedForCaptainParachute()
	{
	}

	private void TrySendCaptainParachutePOIMark(uint configID)
	{
	}

	private void DismissCaptainParachuteBubble()
	{
	}

	private void OnPlayerLandingRecordPOI(object[] param)
	{
	}

	private void _003CTryTriggerLastMatchStatsQuickChatOnMaskClosed_003Eb__41_0()
	{
	}

	private void _003CTryTriggerExcellentBehaviorQuickChatOnMaskClosed_003Eb__43_0()
	{
	}

	private void _003CTryTriggerCaptainParachutePOIQuickChatOnMaskClosed_003Eb__63_0()
	{
	}
}
