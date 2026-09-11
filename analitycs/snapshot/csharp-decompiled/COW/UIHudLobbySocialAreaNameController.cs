using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIHudLobbySocialAreaNameController : UIHudNameBaseController, IHudNameController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ResourceID> _003C_003E9__105_2;

		internal int _003CRefreshDownLoadTeammateEquipmentContainer_003Eb__105_2(ResourceID a, ResourceID b)
		{
			return 0;
		}
	}

	private UIHudLobbySocialAreaNameView m_View;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private UILobbySocialAreaTitleCommonController m_LobbySocialTitleCtrl;

	private UILeaderBoardTitleCommonController m_CommonTitleCtrl;

	private UIHudLobbySociaAreaNameTitleSelectionController m_TitleSelectionCtrl;

	private UIHudLobbyLWQueueStateController m_QueueStateCtrl;

	private UIHudLobbySocialAreaTitleCarryHitController m_CarryHitTitleCtrl;

	private UINewDownloadInfoController m_DownloadCtrl;

	protected List<ResourceID> m_needDownLoadTeammateResList;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelGroup m_ModelGroup;

	private UIModelFriends m_ModelFriends;

	private UIModelLobbySocial m_ModelLobbySocial;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelPrime m_ModelPrime;

	private uint m_CommonTitleDelayCallID;

	private BHGGAEEHJCO m_BindPlayer;

	private bool m_LastRelationshipVisible;

	private bool m_LastIsTeammate;

	private bool m_LastIsFriend;

	private BitArrayBoolean m_IsTitleContainerVisible;

	private const uint TITLE_CONTAINER_FLAG_TITLE = 1u;

	private const uint TITLE_CONTAINER_FLAG_QUEUE_STATE = 2u;

	private const uint TITLE_CONTAINER_FLAG_CARRY_HIT = 4u;

	private const int DEFAULT_NAME_PANEL_DEPTH = 0;

	public const int LOCAL_PLAYER_NAME_PANEL_DEPTH = 1;

	private readonly Vector3 m_NameWorldOffset;

	private bool m_NameLabelStyleCached;

	private bool m_NameLabelApplyGradient;

	private NGUIText.GradientType m_NameLabelGradientType;

	private Color m_NameLabelGradientTop;

	private Color m_NameLabelGradientBottom;

	private UILabel.Effect m_NameLabelEffectStyle;

	private UILabel.Effect m_NameLabelEffectStyle2;

	private Vector2 m_NameLabelEffectDistance;

	private Vector2 m_NameLabelEffectDistance2;

	private Color m_NameLabelEffectColor;

	private Color m_NameLabelEffectColor2;

	public ELobbyLWQueueState QueueState => ELobbyLWQueueState.None;

	public UINewDownloadInfoController DownloadCtrl => null;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ResetUIs()
	{
	}

	private void ApplyNamePanelDepth(bool isLocalPlayer)
	{
	}

	private void CacheNameLabelOriginalStyle()
	{
	}

	private void RestoreNameLabelOriginalStyle()
	{
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	private Vector3 GetPlayerNameWorldPosition(Player player)
	{
		return default(Vector3);
	}

	private float GetSocialLobbyDeformHudNameHeightOffset(Player player)
	{
		return 0f;
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	public void UnbindPlayer()
	{
	}

	public void RefreshQueueState(byte zoneIndex, int queuePosition, bool isDefender)
	{
	}

	public void SetTeleportingState(byte zoneIndex)
	{
	}

	public void HideQueueState()
	{
	}

	private void EnsureQueueStateCtrl()
	{
	}

	private bool IsBindPlayerInCarryState()
	{
		return false;
	}

	private bool IsQueueStateClear()
	{
		return false;
	}

	private void OnCarryBattleHitNtf(uint hitPlayerID, uint hitCount)
	{
	}

	private void OnCarryStateChangedNtf()
	{
	}

	private void RefreshBindPlayerCarryHit()
	{
	}

	private void RefreshCarryHit(Player player)
	{
	}

	private void RefreshCarryHit(uint hitCount)
	{
	}

	private void ShowCarryHit(uint hitCount)
	{
	}

	private void HideCarryHit()
	{
	}

	private void SetQueueStateShowing(bool isShowing)
	{
	}

	private void SetTitleContainerVisible(bool visible)
	{
	}

	private void SetTitleContainerState(uint flag, bool state)
	{
	}

	private void ApplyPlayerName(Player player)
	{
	}

	private void ApplyPlayerPrimeNameStyle(Player player)
	{
	}

	private void RefreshLocalPlayerPrimeNameStyle()
	{
	}

	private void ApplyPrimeNameStyleByState(bool isPrimeNameColor)
	{
	}

	private bool RefreshRelationshipContainer(Player player)
	{
		return false;
	}

	private void RefreshBindPlayerRelationshipContainer()
	{
	}

	private void RefreshPrivilegeIcon(Player player)
	{
	}

	private void RefreshLocalPlayerPrivilegeFromModel()
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void RefreshPlayerName()
	{
	}

	public void RefreshTitle()
	{
	}

	public bool TryShowTitleAcquireGuide()
	{
		return false;
	}

	private void FinishTitleAcquireGuide()
	{
	}

	private bool ShowTitleSelection()
	{
		return false;
	}

	private void OnNameBtnClick()
	{
	}

	private void OnTitleBtnClick()
	{
	}

	public void CloseTitleSelection()
	{
	}

	public void OnTitleSelectionChosen(proto.ESocialHall.TitleType chosenTitleType)
	{
	}

	private string GetBindUserIdString()
	{
		return null;
	}

	private bool IsLocalBindPlayer()
	{
		return false;
	}

	private void SetVoiceSpeaking(bool isSpeaking)
	{
	}

	private void OnPlayerVoiceStateChange(object[] data)
	{
	}

	private void OnOwnPlayerVoiceStateChange(object[] data)
	{
	}

	public void RefreshLocalPlayerBadgeFromModel()
	{
	}

	private void RefreshTitleByChosenType(Player player)
	{
	}

	private void RefreshTitleByChosenType(Player player, proto.ESocialHall.TitleType chosenType)
	{
	}

	private void RefreshLobbySocialTitle(proto.ESocialHall.TitleType chosenType)
	{
	}

	private void HideLobbySocialTitle()
	{
	}

	private LeaderBoardTitleShowingParams GetShowParamsByGroupMatchMode(tcp.LeaderboardTitleInfo titleInfos, TitleAccountParams titleAccountParams)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	private LeaderBoardTitleShowingParams GetShowParamsByGroupMatchModeFromCachedList(List<InGameLeaderBoardTitleInfo> infos, bool isFirstRankTitleReceive, bool isFirstPeakTitleReceive, TitleAccountParams titleAccountParams)
	{
		return default(LeaderBoardTitleShowingParams);
	}

	public void RefreshDownloadButtonOnProfileChanged()
	{
	}

	private void RefreshDownLoadTeammateEquipmentContainer()
	{
	}

	private void HideDownLoadTeammateEquipmentContainer()
	{
	}

	private void EnsureDownloadCtrl()
	{
	}

	private static List<uint> GetItemIdsNeedDownLoadFromTeammate(BaseProfileInfo profile)
	{
		return null;
	}

	public float GetNeedDownloadSize()
	{
		return 0f;
	}

	public void DownLoadOneTeamateEquipment()
	{
	}

	private void DownLoadOneTeamateEquipmentClick()
	{
	}

	private void DownLoadAllTeamateEquipmentClick()
	{
	}

	private void OnClickDownloadBtn()
	{
	}

	private Player GetBindPlayer()
	{
		return null;
	}

	private static bool IsSameResList(List<ResourceID> a, List<ResourceID> b)
	{
		return false;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnGroupChangeRefreshTitle(object[] args)
	{
	}

	private void OnLeaderBoardTitleReadyRefreshTitle(object[] args)
	{
	}

	private void OnTitleAcquireGuide()
	{
	}

	private void RefreshTitleForBoundPlayer(bool requireInGroupOrLocal)
	{
	}

	private void OnSocialHallChooseTitleNtf(uint playerId, uint chosenTitleType)
	{
	}

	public void ShowCommonTitle(uint titleId)
	{
	}

	private void OnCommonTitleShowEnd()
	{
	}

	private void CancelCommonTitleDelayCall()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CTryShowTitleAcquireGuide_003Eb__85_0()
	{
	}

	private void _003CSetVoiceSpeaking_003Eb__94_0(bool _)
	{
	}

	private void _003CRefreshDownLoadTeammateEquipmentContainer_003Eb__105_0(bool _)
	{
	}

	private void _003CRefreshDownLoadTeammateEquipmentContainer_003Eb__105_1(bool _)
	{
	}

	private void _003CHideDownLoadTeammateEquipmentContainer_003Eb__106_0(bool _)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}
}
