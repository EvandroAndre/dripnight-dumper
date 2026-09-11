using GCommon;
using UnityEngine;

namespace COW;

public class UIHudShareView : UIBaseView
{
	public UIGrid GridInterAppInvite;

	public UIButton BtnCopyLink;

	public UIButton BtnLineInvite;

	public UIButton BtnBindInvite;

	public UISprite BindInviteSprite;

	public UIButton BtnOtherInvite;

	public UIButton BtnWhatsAppInvite;

	public UIButton BtnInstagramInvite;

	public UIButton HUDCodeCopyIcon;

	public UIScrollView ScrollView;

	public UIEasyList List;

	public UIInput SearchInput;

	public TweenAlpha SearchTweenLabel;

	public UIButton SearchBtn;

	public UISprite SearchBtnSprite;

	public GameObject SearchClearSprite;

	public UIButton SaveMapQRCode;

	public UILabel FriendsTip;

	public UIWidget LeftTop;

	public UIPanel HUDContainer;

	public UILabel NameTxt;

	public UISprite HUDBg;

	public UINetworkTexture NetworkTexture;

	public UIWidget QRCodeCtrl;

	public UIWidget RightTop;

	public Transform UIQRCode;

	public UIWidget HudPreview;

	public GameObject LOGO;

	public Transform InfoContainer;

	public GameObject AvatarContainer;

	public UITexture AvatarTexture;

	public UIPanel AvatarPanel;

	public GameObject Callsign;

	public Transform PrivilegeIcon;

	public UINetworkTexture HeadIcon;

	public UISprite HeadLocalIcon;

	public Transform AvatarPosFrame;

	public UILabel Name;

	public UILabel ID;

	public UIEffectSprite bg;

	public GameObject fakeBg;

	public GameObject BRRankIconContainer;

	public Transform CSRankIconContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
