using System.Collections.Generic;
using COW.GamePlay;
using message;

namespace COW;

public class UILobbySocialAreaActionArbiter
{
	private readonly UIHudLobbySocialAreaEventActionController m_UseBtnCtrl;

	private readonly UIHudLobbySocialAreaEventActionController m_SubUse1Ctrl;

	private readonly UIHudLobbySocialAreaTargetPlayerController m_TargetPlayerCtrl;

	private UIHudLobbySocialAreaEventActionController.EEventActionType m_TriggerType;

	private uint m_TriggerTargetId;

	private EventLogger.ESocialHubPersonalInfoTriggerSource m_TriggerSource;

	private UIHudLobbySocialAreaEventActionController.EEventActionType m_RewardType;

	private UIHudLobbySocialAreaEventActionController.EEventActionType m_RegionType;

	private readonly List<uint> m_FollowMoveOwners;

	private EventLogger.ESocialHubPersonalInfoTriggerSource m_FollowMoveSource;

	private uint m_FollowMoveLoggedOwnerId;

	private bool _003CIsAnyActionVisible_003Ek__BackingField;

	private bool _003CHasPendingActionButton_003Ek__BackingField;

	private bool _003CIsFollowMoveVisible_003Ek__BackingField;

	private bool m_PlayerInfoActive;

	private uint m_PlayerInfoTargetId;

	private EventLogger.ESocialHubPersonalInfoTriggerSource m_PlayerInfoSource;

	private bool m_IsCameraMode;

	public bool IsAnyActionVisible
	{
		get
		{
			return _003CIsAnyActionVisible_003Ek__BackingField;
		}
		private set
		{
			_003CIsAnyActionVisible_003Ek__BackingField = value;
		}
	}

	public bool HasPendingActionButton
	{
		get
		{
			return _003CHasPendingActionButton_003Ek__BackingField;
		}
		private set
		{
			_003CHasPendingActionButton_003Ek__BackingField = value;
		}
	}

	public bool IsFollowMoveVisible
	{
		get
		{
			return _003CIsFollowMoveVisible_003Ek__BackingField;
		}
		private set
		{
			_003CIsFollowMoveVisible_003Ek__BackingField = value;
		}
	}

	public UILobbySocialAreaActionArbiter(UIHudLobbySocialAreaEventActionController useBtnCtrl, UIHudLobbySocialAreaEventActionController subUse1Ctrl, UIHudLobbySocialAreaTargetPlayerController targetPlayerCtrl)
	{
	}

	public void SetCameraMode(bool isCameraMode)
	{
	}

	private bool ShouldHideInCameraMode(UIHudLobbySocialAreaEventActionController.EEventActionType type)
	{
		return false;
	}

	private bool ShouldBlockUseAndSubUse1ByPlayerState()
	{
		return false;
	}

	private bool CanShowFollowMoveFallback(uint targetId)
	{
		return false;
	}

	public void RefreshAction()
	{
	}

	public void SetTriggerAction(UIHudLobbySocialAreaEventActionController.EEventActionType rawType, uint targetId, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	public void ClearTriggerAction()
	{
	}

	public void SetReward(UIHudLobbySocialAreaEventActionController.EEventActionType type)
	{
	}

	public void SetRegion(UIHudLobbySocialAreaEventActionController.EEventActionType type)
	{
	}

	public void AddFollowMove(uint ownerId, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	public void RemoveFollowMove(uint ownerId)
	{
	}

	private void TryLogFollowMoveShown(uint targetId)
	{
	}

	public void ShowPlayerInfo(uint targetId, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	public void HidePlayerInfo()
	{
	}

	public void HideAll()
	{
	}

	private HGILDDIDAIG GetPlayerTriggerSeatPhase(Player localPlayer)
	{
		return HGILDDIDAIG.ESeesawPhase_Idle;
	}

	private BHGGAEEHJCO GetPlayerTriggerSeatPlayerID(Player localPlayer)
	{
		return default(BHGGAEEHJCO);
	}

	private void Refresh()
	{
	}
}
