using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFriendaddView : UIBaseView
{
	public Transform ProfileContainer;

	public UIButton AddFriendBtn;

	public GameObject AddIcon;

	public GameObject SendedIcon;

	public GameObject FriendIcon;

	public UILabel InviteCadetLabel;

	public UIButton InviteCadetBtn;

	public GameObject AllContainer;

	public UITable AllContainerTable;

	public UIButton ReportBG;

	public UIButton MuteAllBtn;

	public GameObject ReportClose;

	public GameObject ReportToggle;

	public GameObject NotMuteAllSprite;

	public GameObject MutedAllSprite;

	public UIButton WishBtn;

	public UIButton StickerBtn;

	public Transform WishTransform;

	public Transform StickerTransform;

	public GameObject WishCancelIcon;

	public GameObject WishIcon;

	public GameObject StickerIcon;

	public GameObject StickerCancelIcon;

	public GameObject ProfileInfoLow;

	public UILabel Nickname;

	public UILabel Clanname;

	public UIWidget ValidRect;

	public UIButton LikeBtn;

	public GameObject LikeIcon;

	public GameObject LikedContainer;

	public UILabel TitleLabel;

	public GameObject TitleContainer;

	public UISprite TitleBG;

	public GameObject Timer;

	public UISprite TimeCircle;

	public UILabel TimeLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
