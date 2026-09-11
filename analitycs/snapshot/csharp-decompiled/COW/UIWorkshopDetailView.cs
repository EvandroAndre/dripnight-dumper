using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopDetailView : UIBaseView
{
	public Transform MapContainer;

	public UIPanel MapExtarInfo;

	public UIButton BtnPreview;

	public UIButton BtnFullScreen;

	public UILabel LabelSubscribeCount;

	public UISprite SpriteMap;

	public UIGrid TagContainer;

	public UILabel LabelWorkshopName;

	public UILabel LabelAuthorName;

	public UIButton BtnAuthor;

	public UIButton BtnCopyWorkshopCode;

	public UILabel LabelRound;

	public UILabel LabelBattleStyle;

	public UIScrollView DescScrollView;

	public UILabel LabelDesc;

	public UIButton BtnSubscribe;

	public UISprite SpriteSubscribeIdle;

	public UISprite SpriteSubscribeSucc;

	public UIButton BtnShare;

	public UISprite WidgetShare;

	public UIButton BtnReport;

	public UIButton BtnCreateRoom;

	public GameObject FreeCreateRoom;

	public UIGrid CommentContainer;

	public UIButton BtnAddComment;

	public UIWidget TutorialWidget;

	public UILabel LabelTag;

	public UITable BtnRightTable;

	public UIButton BtnSave;

	public UIButton BtnClose;

	public GameObject DotTrans;

	public UIButton Mask;

	public UIButton BtnQuickJoin;

	public UISprite QuickJoinIcon;

	public UIButton MaskBtn;

	public UIGrid IconGrid;

	public GameObject HotContainer;

	public UITable HotTable;

	public UIButton CrownBtn;

	public UIAnchor DownloadContainer;

	public GameObject DownloadBg;

	public GameObject Survey;

	public UIButton SurveyBtn;

	public UITable MapDetailTable;

	public Transform LikeRate;

	public GameObject WorkshopCode;

	public GameObject ShareRedPoint;

	public UINetworkTextureExt KolMapIcon;

	public UIButton KolMapIconTips;

	public UINetworkTextureExt KolAuthorIcon;

	public UIButton KolAuthorIconButton;

	public UIButton UGCVipMapBtn;

	public GameObject BtnQuickJoinMask;

	public GameObject BtnCreateRoomMask;

	public UIButton BtnTranslate;

	public TweenRotation BtnTranslateTween;

	public UISprite BtnTranslateSprite1;

	public UISprite BtnTranslateSprite2;

	public UIButton BtnSoloplay;

	public GameObject BtnSoloplayMask;

	public UITable BtnLeftTable;

	public GameObject BtnSelectMapMask;

	public UIButton BtnSelectMap;

	public GameObject BtnSelectMapNormal;

	public GameObject BtnSoloplayNormal;

	public GameObject BtnQuickJoinNormal;

	public GameObject BtnCreateRoomNormal;

	public UIButton BtnLeaderboard;

	public UISprite AuthorLine;

	public UILabel labelDisablePlay;

	public UILabel LabelOfflineDesc;

	public GameObject CreatorLevelIconRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
