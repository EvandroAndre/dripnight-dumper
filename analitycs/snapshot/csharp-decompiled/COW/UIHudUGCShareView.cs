using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCShareView : UIBaseView
{
	public UIGrid GridInterAppInvite;

	public UIButton BtnCopyLink;

	public UIButton BtnLineInvite;

	public UIButton BtnBindInvite;

	public UISprite BindInviteSprite;

	public UIButton BtnOtherInvite;

	public UIButton BtnWhatsAppInvite;

	public UIButton BtnInstagramInvite;

	public UIButton MapCodeCopyIcon;

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

	public Transform MapContainer;

	public UILabel NameTxt;

	public UILabel LabelTag;

	public UISprite MapBg;

	public UINetworkTexture NetworkTexture;

	public UILabel AuthorTag;

	public UILabel DetailsTag;

	public UIGrid TagContainer;

	public UINetworkTextureExt KolAuthorIcon;

	public UIWidget QRCodeCtrl;

	public UILabel LikeLabel;

	public UIWidget RightTop;

	public Transform UIQRCode;

	public GameObject HotContainer;

	public GameObject LikeRate;

	public GameObject OfflineTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
