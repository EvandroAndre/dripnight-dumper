using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCraftlandView : UIBaseView
{
	public UILabel ArchitectTitle;

	public UILabel ExpValue;

	public UILabel FollowerValue;

	public UILabel LikesValue;

	public GameObject SrotNode;

	public UIWidget ContentContainer;

	public UIWidget CenterScrollable;

	public UIScrollView CenterSV;

	public UITable Table;

	public UIGrid Grid;

	public GameObject Empty;

	public UILabel EmptyLable;

	public UIButton EmptyButton;

	public GameObject Bottom;

	public UINetworkTextureExt KolAuthorIcon;

	public UIButton KolAuthorIconButton;

	public UICheckboxButton AllowDisclosureBtn;

	public UIButton AllowDisclosureHelpBtn;

	public GameObject AllowDisclosureConfig;

	public UILabel LikesAdd;

	public UILabel FollowerAdd;

	public UILabel NumAdd;

	public UIInput InputField;

	public BoxCollider InputCollider;

	public UILabel ArchitectLv;

	public UILabel MapNum;

	public UIButton BtnSetting;

	public GameObject NormalMode;

	public GameObject PinMode;

	public UIButton BtnSave;

	public UIButton BtnExit;

	public UILabel PinModeTxt;

	public UISprite PrivilegeIcon;

	public UIButton PrivilegeBtn;

	public UIButton FollowBtn;

	public UIButton UnFollowBtn;

	public GameObject Show;

	public Animation Animation;

	public GameObject Hide;

	public UISprite LikesAddBG;

	public UISprite FollowerAddBG;

	public UISprite NumAddBG;

	public GameObject SocialMedia;

	public UIButton ArchitectTips;

	public Transform ArchitectIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
