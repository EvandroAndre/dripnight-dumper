using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCMyWorksV2View : UIBaseView
{
	public UIEasyList MapSlotEasyList;

	public UIButton BtnDraft;

	public UIButton BtnPublished;

	public UIButton BtnCreateMap;

	public GameObject BtnNewDownloadContainer;

	public UIButton BtnEdit;

	public UIButton BtnPublish;

	public UIButton BtnMore;

	public UITexture GameMapBg;

	public UITexture GameBitMap;

	public UITexture GameBitOutlineMap;

	public UIButton BtnUpdateLog;

	public UIButton BtnGoToCreatorCenter;

	public UILabel BtnPublishedLabel;

	public UISprite BtnPublishedIcon;

	public UILabel BtnDraftLabel;

	public UISprite BtnDraftIcon;

	public UISprite BtnDraftBg;

	public UISprite BtnPublishedBg;

	public UILabel MapName;

	public UILabel MapGameMode;

	public UILabel EditDate;

	public UIButton BtnOnlineData;

	public UIButton BtnLocalEdit;

	public GameObject LocalEditRoot;

	public GameObject OnlineDataRoot;

	public GameObject RankRoot;

	public UIButton BtnRankTip;

	public GameObject MapTipRoot;

	public UILabel MapTipLabel;

	public GameObject MapTipWarningIcon;

	public GameObject MapTipErrorIcon;

	public GameObject MapTipClockIcon;

	public UIButton BtnPlay;

	public UIButton BtnShare;

	public UIButton BtnBanDetail;

	public UILabel LikeCountLabel;

	public UILabel SubscriptionCountLabel;

	public UIButton BtnStatisticalDetails;

	public UIButton BtnVisitDatabase;

	public UISprite BtnOnlineDataBg;

	public UILabel BtnOnlineDataLabel;

	public UISprite BtnLocalEditBg;

	public UILabel BtnLocalEditLabel;

	public GameObject InspectorToggleRoot;

	public GameObject RankNull;

	public GameObject RankB;

	public GameObject RankA;

	public GameObject RankS;

	public GameObject BtnMorePopup;

	public UITable BtnMorePopupTable;

	public UIButton BtnSaveAs;

	public UIButton BtnUnpublish;

	public UIButton BtnDelete;

	public UISprite BtnMorePopupBg;

	public GameObject BtnDraftRedPoint;

	public GameObject BtnPublishedRedPoint;

	public UILabel BtnPublishLabel;

	public GameObject EmptyRoot;

	public GameObject RightRoot;

	public Animation InspectorAnimation;

	public GameObject LeftRoot;

	public GameObject MoveUp;

	public GameObject InspectorRoot;

	public UINetworkTexture GameMapCdnIcon;

	public GameObject LeftEmptyHide;

	public GameObject RightEmptyHide;

	public GameObject NoPublishedEmptyRoot;

	public GameObject TopMapTip;

	public UILabel TopMapTipLabel;

	public UILabel SlotIdLabel;

	public UILabel BtnSaveAsLabel;

	public UILabel BtnUnpublishLabel;

	public UILabel BtnDeleteLabel;

	public UIButton BtnReset;

	public GameObject UILoadingContainer;

	public UILabel BtnResetLabel;

	public UIButton TopMapTipButton;

	public BoxCollider TopMapTipCollider;

	public UISprite TopMapTipSprite;

	public UIWidget CreateTutorial;

	public UIPanel SlotScrollView;

	public UILabel PlayerCountLabel;

	public UIButton BtnNotCrossRegion;

	public UIButton BtnCreatorLvTip;

	public Transform BtnEditDownloadContainer;

	public GameObject ExpiringCountdownIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
