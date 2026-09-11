using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UILobbyV2ReserveAndObserveWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum EFriendStatusType
	{
		None,
		CanInvite,
		CanJoinGroup,
		CanInviteAndJoin
	}

	private UILobbyV2ReserveAndObserveWndView m_View;

	private UIModelTeamReserve m_ModelTeamReserve;

	private UIModelFriendObserve m_ModelFriendObserve;

	private UIModelFriends m_ModelFriends;

	protected UIModelSceneEdit m_ModelSceneEdit;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UGCSimpleDownloadTask m_ResDownloadTask;

	private FriendAccountInfo m_FriendInfo;

	private SceneEditSlotInfo m_SlotInfo;

	private MapConfigData m_MapConfig;

	private ulong m_AccountID;

	private uint m_MapConfigID;

	private uint m_CurMatchMode;

	private uint m_CurGameMode;

	private string m_CurWorkshopCode;

	private bool m_IsDownloading;

	private EFriendStatusType m_FriendStatusType;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIPopupMessageBoxController m_MesBoxCtrl;

	private bool m_IsCoolingDown;

	private bool m_CanJoinUGCHalfway;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnReserveBtnClick()
	{
	}

	private void OnObserveBtnClick()
	{
	}

	private void OnWorkshopReserveBtnClick()
	{
	}

	private void OnInviteBtnClick()
	{
	}

	private EGroup.InviteeType GetInviteeTypeForFriend()
	{
		return EGroup.InviteeType.InviteeType_NONE;
	}

	private void InitCreateGroupToInviteData()
	{
	}

	private void InviteFriend()
	{
	}

	private void OnJoinBtnClick()
	{
	}

	private bool CheckCanInviteOrJoin()
	{
		return false;
	}

	private void RefreshInviteBtnState()
	{
	}

	private void OnCancelMatch()
	{
	}

	public void SetReserveDefaultBtnState()
	{
	}

	public void SetInviteDefaultBtnState()
	{
	}

	public void SetViewData(ulong accountID, uint mapConfigID, uint matchMode, uint gameMode, FriendAccountInfo friendInfo = null, uint friendStatusType = 0u)
	{
	}

	private void SetLineActive()
	{
	}

	private void SetInviteState(FriendAccountInfo friendInfo = null, EFriendStatusType friendStatusType = EFriendStatusType.None)
	{
	}

	public void SetReserveStatus()
	{
	}

	public void SetPosition(Vector3 itemPos)
	{
	}

	private bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void SetUGCHalfwayJoinState(FriendAccountInfo friendInfo)
	{
	}

	private void RefreshUGCHalfJoinBtn()
	{
	}

	private void OnJoinUGCGameBtnClick()
	{
	}

	private void _003COnObserveBtnClick_003Eb__27_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003COnJoinBtnClick_003Eb__33_2()
	{
	}

	private void _003COnJoinBtnClick_003Eb__33_3()
	{
	}

	private void _003COnJoinBtnClick_003Eb__33_0()
	{
	}

	private void _003COnJoinBtnClick_003Eb__33_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
