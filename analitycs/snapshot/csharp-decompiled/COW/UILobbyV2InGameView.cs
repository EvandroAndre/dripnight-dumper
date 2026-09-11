using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2InGameView : UIBaseView
{
	public UIButton VaultBtn;

	public UIButton WeaponBtn;

	public UIWidget WeaponCustomSkinGuideWidget;

	public UIButton BuildBtn;

	public UIButton LabBtn;

	public UIButton SubSystemEntranceBtn;

	public UIButton ChatRecruitBtn;

	public UIButton RecruitTeammateBtn;

	public UIButton ChatBtn;

	public GameObject LatestMessage;

	public UILabel LatestMessageLabel;

	public UIButton ChatMessageBtn;

	public GameObject Events;

	public UISprite BooyahPassIcon;

	public GameObject BooyahPass;

	public UIButton BooyahPassBtn;

	public GameObject Mission;

	public UIButton MissionBtn;

	public UIButton EventsBtn;

	public UITable LeftBtnGroup;

	public UITable LeftEntranceGroup;

	public Transform BigEventContainer;

	public UIWidget BigEventContainerWidget;

	public Transform NewPlayerSignin;

	public UIWidget NewPlayerSigninWidget;

	public Transform PreVeteran;

	public UIWidget PreVeteranWidget;

	public Transform VeteranSignin;

	public UIWidget VeteranSigninWidget;

	public GameObject HideoutContainer;

	public TweenAlpha HideoutContainerTween;

	public UIGrid RevenueContainer;

	public Transform LobbyGacha;

	public Transform PurchaseEvent;

	public Transform MysteryMall;

	public Transform FlashStore;

	public Transform BigEventTemplate;

	public Transform RightBottomContainer;

	public UISprite EventsIcon;

	public Transform VFXContainer;

	public Animator EventsAnimator;

	public GameObject TopActivityGroup;

	public Transform IAPBundleTransform;

	public GameObject main;

	public Animation MainAnimation;

	public Transform TransformEmotePanelContainer;

	public UIButton UIButtonEmotePanelContainer;

	public BoxCollider BoxColliderEmotePanelContainer;

	public UIWidget UIWidgetEmotePanelContainer;

	public Transform AvatarPanel;

	public Transform PetAnimTrans;

	public Transform ChatRedTips;

	public GameObject SubSystemEntranceTips;

	public Transform LabTips;

	public Transform WeaponTips;

	public Transform VaultTips;

	public Transform StoreTips;

	public Transform GachaTips;

	public Transform BPTips;

	public Transform MissionTips;

	public Transform EventTips;

	public Transform BigEventContainerTemplate;

	public UIWidget BigEventContainerTemplateWidget;

	public Transform BigEventContainerFlashStore;

	public UIWidget BigEventContainerFlashStoreWidget;

	public UIWidget BuildGuideWidget;

	public UIWidget VaultGuideWidget;

	public UIWidget GachaGuideWidget;

	public UIWidget StoreGuideWidget;

	public UIGrid IAPBundleContainer;

	public TweenAlpha IAPBundleContainerTween;

	public GameObject IAPBundleContainerGameObject;

	public UISprite TopSprite;

	public UISprite RightSprite;

	public UISprite LeftSprite;

	public UISprite BottomSprite;

	public Transform Payment;

	public Transform IAPBundleChoose1From3;

	public Transform IAPBundleWeb;

	public GameObject Gacha;

	public UIButton GachaBtn;

	public GameObject Store;

	public UIButton StoreBtn;

	public GameObject Vault;

	public GameObject Weapon;

	public GameObject Build;

	public GameObject Lab;

	public GameObject LeftBottomBtnGroupBg;

	public UITable LeftContainer;

	public Transform LeftContainerTrans;

	public Transform LeftContainerInTeamTrans;

	public GameObject ChatBtnBG;

	public Transform ResidentFriendPos;

	public TweenAlpha TweenAlphaGroupMaskScene;

	public TweenAlpha TweenAlphaGroupMask;

	public UIButton FastSendGiftBtn;

	public UIGrid ChatBtnGroup;

	public UIButton OpenBtn;

	public GameObject SubSystemNew;

	public UIGrid ShoppingMallActivity;

	public Transform InviteBoxPos;

	public UINetworkTexture BooyahPassBubble;

	public UISprite BuildIcon;

	public Transform BuildTips;

	public GameObject Veteran_EventsIcon;

	public GameObject SubSystemLive;

	public Transform SpecialBtnTrans;

	public Transform LeftInTeamBtnGroup;

	public Transform LeftBottomInTeamBtnGroup;

	public UILabel LabelBp;

	public GameObject LoadoutV2Icon;

	public UISprite EventsBG;

	public GameObject ChatAndMicContainer;

	public UIButton NewChatBtn;

	public UIButton SpeakerToggle;

	public UISprite SpeakerSprite;

	public UISprite SpeakerMask;

	public UISprite SpeakerTeam;

	public UIButton MicToggle;

	public UISprite MicBan;

	public UISprite MicSprite;

	public UISprite MicMask;

	public UISprite MicTeam;

	public Transform GroupMemeberVoice;

	public GameObject HotIcon;

	public UILabel EventLabel;

	public GameObject HotBg;

	public Transform NewChatRedTips;

	public Transform ShoppingMallActivityInTeamTrans;

	public Transform ShoppingMallActivityTrans;

	public GameObject LeftTopContainer;

	public UIButton FastMessageBtn;

	public Transform FastMessageContainer;

	public GameObject MessageChatBtnBG03;

	public Transform LocalActivity;

	public UIWidget LocalActivityWidget;

	public UINetworkTexture NewPlayerStoreBubble;

	public UILabel LabelNewPlayerStore;

	public GameObject NewplayerStoreBG;

	public GameObject CommonStoreBG;

	public GameObject TopRightContainer;

	public GameObject TopRightActivityGridGameObject;

	public UIGrid TopRightActivityGrid;

	public UITable TopRightActivityTable;

	public GameObject TopRightActivityInTeamGridGameObject;

	public UIGrid TopRightActivityInTeamGrid;

	public Transform LobbyRightBigEventContainer;

	public Transform LobbyRightBigEventContainerFlashStore;

	public Transform LobbyRightBigEventContainerTemplate;

	public Transform LobbyRightLocalActivity;

	public Transform LobbyRightNewPlayerSignin;

	public Transform LobbyRightPreVeteran;

	public Transform LobbyRightVeteranSignin;

	public Transform LobbyRightGacha;

	public Transform LobbyRightPurchaseEvent;

	public Transform LobbyRightMysteryMall;

	public Transform LobbyRightFlashStore;

	public Transform LobbyRightBigEventTemplate;

	public UIWidget TopRightActivityGuideWidget;

	public GameObject SubSystemEntrance;

	public GameObject LeftBottomBtnGroupSpriteBg;

	public GameObject NoticeRecruit;

	public Transform LeftBottomBtnGroupContainer;

	public GameObject LobbyRightSpecialEntrance;

	public Transform TakePhotoPos;

	public UIWidget EightBSpecialGuideWidght;

	public GameObject NoticeRecruitParent;

	public GameObject SkinTimeLineStoreBGGameObject;

	public UISprite SkinTimeLineStoreBG;

	public GameObject GachaBG;

	public GameObject SkinTimeLineGachaBGGameObejct;

	public UISprite SkinTimeLineGachaBG;

	public GameObject SkinTimeLineEventsBGGameObject;

	public UISprite SkinTimeLineEventsBG;

	public UILabel StoreLabel;

	public UISprite StoreIcon;

	public UILabel GachaLabel;

	public UISprite GachaIcon;

	public GameObject LabSpecialBg;

	public UISprite LabSpecialBgSprite;

	public Transform RelayMart;

	public Transform LobbyRightRelayMart;

	public VFXCreateHelper CSPeakNoticeRecruit;

	public GameObject DrawShop;

	public UILabel DrawShopLabel;

	public UIButton DrawShopBtn;

	public Transform DrawShopTips;

	public GameObject DrawShopBG;

	public GameObject SkinTimeLineDrawShopBGGameObejct;

	public UISprite SkinTimeLineDrawShopBG;

	public UIWidget DrawShopGuideWidget;

	public UISprite DrawShopIcon;

	public Transform LobbyRightDrawShop;

	public Transform LobbyDrawShop;

	public UITable LeftBottomBtnGroup;

	public Transform GameAssistantLobbyBubbleContainer;

	public Transform RankingTipsBubbleContainer;

	public GameObject NoticeChangeTeam;

	public UIButton NoticeChangeTeamBtn;

	public Transform Age18Pos;

	public GameObject NewbieRecruitRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
