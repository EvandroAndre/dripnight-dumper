using GCommon;
using UnityEngine;

namespace COW;

public class UIClanLogoShowView : UIBaseView
{
	public GameObject UIClanLogoShow;

	public GameObject ClanLogoContainer;

	public UIScrollView ClanLogoSelectList;

	public UIGrid ClanLogoSelectGrid;

	public UISprite ClanLogoSprite;

	public UILabel ClanLogoName;

	public UILabel ClanLogoDesc;

	public GameObject ShowClanLogo;

	public UINetworkTexture ClanLogoCDN;

	public UIButton UpdateClanBadgeBtn;

	public UILabel BadgeStateLabel;

	public UIButton UnlockBtn;

	public UILabel ChangeBadgeName;

	public UISprite ChangeBadgeBG;

	public GameObject LockBtn;

	public UISprite ClanLogoFrame;

	public GameObject Center;

	public UISprite Gift;

	public UILabel ItemCountLabel;

	public UILabel ItemCountLabel1;

	public UISprite ClanLogoFrame_R;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
