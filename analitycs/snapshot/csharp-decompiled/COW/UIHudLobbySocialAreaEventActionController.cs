using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbySocialAreaEventActionController : UIBaseController
{
	public enum EEventActionType
	{
		None = 0,
		DancePoolJoin = 1,
		DancePoolStart = 2,
		CarryPlayer = 3,
		LobbyLWRecruit = 5,
		SpectatorCam = 6,
		ExitCarryPlayer = 8,
		ExitDancePool = 9,
		DancePoolDJInteract = 10,
		GetOnChair = 11,
		GetOffChair = 12,
		GetOnSeesaw = 13,
		GetOffSeesaw = 14,
		EnterCatapult = 15,
		LeaveCatapult = 16,
		CatapultLaunch = 17,
		TakePhoto = 18,
		ShowTargetPlayer = 20,
		DuoEmoteJoin = 21,
		CooperateEmoteJoin = 22,
		FollowEmote = 23,
		SuperEmoteInteractive = 24,
		RewardPoolLook = 25,
		RewardPoolClaim = 26,
		ResetDeform = 27,
		LobbyLWInteract = 29,
		FollowMoveEmote = 30,
		Exit = 99
	}

	private class EventActionRes
	{
		public string Icon;

		public string LocKey;
	}

	public const string LocKeySeesawSeatOccupied = "T_54_ZP_NINTH_SYS_CROWDED";

	public const string LocKeyDancePoolSoftClose = "T_54_JC_SOCIALHUB_PLAYZONECLOSE";

	private static readonly Dictionary<uint, EventActionRes> s_ActionResMap;

	private UIHudLobbySocialAreaEventActionView m_View;

	public EEventActionType m_CurrentType;

	private BHGGAEEHJCO m_TargetPlayerID;

	private bool m_GetOnSeesawInteractGray;

	private VisualInstanceHolder m_BtnVFXHolder;

	private ResourceID m_BtnVFXResourceID;

	private UIHudLobbySocialAreaTargetPlayerActionController m_TargetCtrl;

	public EEventActionType CurrentType => EEventActionType.None;

	public BHGGAEEHJCO TargetPlayerID => default(BHGGAEEHJCO);

	public Vector2 GetBtnSize()
	{
		return default(Vector2);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool IsLobbySocialObjectType(EEventActionType actionType)
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void ApplyActionButtonIconColor(Color color)
	{
	}

	private bool IsShowTargetPlayerType(EEventActionType t)
	{
		return false;
	}

	public void ShowAction(EEventActionType type, BHGGAEEHJCO targetPlayerID, EventLogger.ESocialHubPersonalInfoTriggerSource source = EventLogger.ESocialHubPersonalInfoTriggerSource.None)
	{
	}

	private void SetBtnColor(EEventActionType type)
	{
	}

	public bool IsGetOnSeesawSeatOccupiedGray()
	{
		return false;
	}

	private void SetVFX(EEventActionType type)
	{
	}

	private void PlayBtnVFX(ResourceID resourceID)
	{
	}

	private void TryReleaseDanceVFXHolder()
	{
	}

	public void HideAction()
	{
	}

	private void ApplyRes(EventActionRes res)
	{
	}

	private void TryApplyEmoteJoinIconOverride(EEventActionType type, BHGGAEEHJCO targetPlayerID)
	{
	}

	private void OnBtnActionClick()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnTakePhotoClick(Player lp)
	{
	}

	private void OnDancePoolDJInteractClick()
	{
	}

	private void OnLobbyLWInteractClick()
	{
	}

	private void OnResetDeformClick()
	{
	}

	private void OnCatapultLaunchClick(Player lp)
	{
	}

	private void OnLobbySocialObjectActionClick(Player lp)
	{
	}

	private void Log9AnniversarySceneInteraction(OPICPDCLKAG triggerType, uint triggerID)
	{
	}

	private void ShowEmoteJoinFailTips(EEventActionType type)
	{
	}

	private void OnEmoteJoinActionClick(Player lp)
	{
	}

	private void OnDancePoolStartClick(Player lp)
	{
	}

	private void OnDancePoolJoinClick(Player lp)
	{
	}

	private bool TryBlockDancePoolBySoftClose()
	{
		return false;
	}

	private void OnCarryPlayerClick(Player lp)
	{
	}

	private void OnLobbyLWRecruitClick(Player lp)
	{
	}

	private void OnSpectatorCamClick(Player lp)
	{
	}

	private void OnRewardPoolLookClick()
	{
	}

	private void OnRewardPoolClaimClick()
	{
	}

	private void OnExitClick(Player lp)
	{
	}

	private void SetIconSprite(EEventActionType type)
	{
	}

	private void SetCloseBtnState(EEventActionType type)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
