using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudObserverInteractionController : UIBaseController, IUIModelDataChangeObserver
{
	private enum EObserverRewardState
	{
		None,
		Normal,
		BeginObserverdCannotAccept,
		GameLimit,
		DayLimit
	}

	private BHGGAEEHJCO m_TargetPlayerID;

	private ulong m_TargetUserID;

	private string m_LockRegion;

	private string m_TargetPlayerName;

	private float m_EmojiSendTime;

	private float m_TargetUserLikeEndTime;

	private float m_TargetUserRewardEndTime;

	private float m_TargetUserEmojiEndTime;

	private bool m_NeedFirstShowGift;

	private UIModelFriendObserve m_ModelFriendObserver;

	private bool m_CanShowSendWnd;

	private bool m_IsFriendObserver;

	private bool m_IsTargetFriend;

	private bool m_IsTrackTeammateFriend;

	private bool m_IsShowRewardBtn;

	protected UIHudObserverInteractionView m_View;

	private UIHudObserverRewardWndController m_ObserverRewardCtrl;

	private const string CAN_ADD_FRIEND = "UI_Icon_Friend";

	private const string ALREADY_ADDED_FRIEND = "UI_Icon_Friend_02";

	private const string CAN_RESERVE = "FF_Icon_Ingame_Reservation";

	private Color RESERVING_COLOR;

	private const string RESERVED = "FF_Icon_Ingame_Determine";

	private const string RESERVE_REJECTED = "FF_Icon_Ingame_Ban";

	private const string ALREADY_LIKED = "UI_icon_like_02";

	private Color ALREADY_LIKED_COLOR;

	private Color NORMAL_LIKED_COLOR;

	private const string HAVE_NOT_LIKED = "UI_icon_like";

	private bool m_IsLikeInCd;

	private bool m_IsRewardInCd;

	private bool m_IsEmojiInCd;

	private List<UIHudObserverStickerItem> observerStickerItems;

	private Dictionary<ulong, float> m_PlayerLikeEndTime;

	private Dictionary<ulong, float> m_PlayerRewardEndTime;

	private EObserverRewardState m_ObserverRewardState;

	private ulong m_ReceiverPlayerID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitStaticAtlasSprites()
	{
	}

	private void SetObserverEmojiSprite(UISprite sprite, string resourceName)
	{
	}

	public void RefreshSomeUIVisable()
	{
	}

	private void SetBtnRewardState()
	{
	}

	public void OnObserverSwitch(object[] data)
	{
	}

	public void RefreshCD()
	{
	}

	private void Update()
	{
	}

	private void RefreshLikeCD()
	{
	}

	private void RefreshRewardCD()
	{
	}

	public void OnOpenReviveUI(object[] param)
	{
	}

	private void OnObserverReward(object[] data)
	{
	}

	private void OnRewardFailed()
	{
	}

	private void ShowRewardSuccessView(uint rewardID)
	{
	}

	private void RefreshRewardBtnView()
	{
	}

	private bool CheckIsLastSendReward()
	{
		return false;
	}

	private void UpdateRewardState()
	{
	}

	private void RefreshLikeBtn()
	{
	}

	private void RefreshFriendIcon()
	{
	}

	private void OnLikeClick()
	{
	}

	private void OnAddFriendOrReserveClick()
	{
	}

	private void SendReward()
	{
	}

	private void OnRewardClick()
	{
	}

	private void OnReportCheatSent(object[] param)
	{
	}

	private void onReportClick()
	{
	}

	private void InitEmojiAndGiftTable()
	{
	}

	private void OnEmojiClick()
	{
	}

	private void OnEmojiSend(string resName, uint sendType)
	{
	}

	public void HideRewardWnd()
	{
	}

	public void StickerHide()
	{
	}

	private void ReSetEmoji()
	{
	}

	private void OnShowEmojiGuide(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
