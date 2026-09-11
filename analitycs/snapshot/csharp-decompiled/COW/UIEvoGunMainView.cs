using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunMainView : UIBaseView
{
	public UIWidget PreviewBorder;

	public Transform Components;

	public GameObject Main;

	public Transform WeaponName;

	public UILabel LabelWeaponNameVer2;

	public UIWidget Rename;

	public UIButton BtnRename;

	public Transform KillCountCard;

	public GameObject ShowOwnPickList;

	public UIToggle ToggleShowOwnPickList;

	public UIEasyList GunGrid;

	public GameObject PickList;

	public UITable PropertyTable;

	public GameObject GoUIMask;

	public UIButton SwitchBtn;

	public UIButton ZoomBtn;

	public UIButton BtnSeeAnim;

	public GameObject SwitchToGunSpr;

	public GameObject SwitchToPersonSpr;

	public UIPanel PickScrollViewPanel;

	public UIScrollView PickScrollView;

	public UIAnchor AnchorWithPickList;

	public UILabel LabelWeaponNameVer1;

	public GameObject ContentVer2;

	public GameObject ContentVer1;

	public GameObject NaviTabBrd;

	public GameObject DetailTabBrd;

	public UILabel LabelWeaponNameShadowVer2;

	public UILabel LabelWeaponNameShadowVer1;

	public Transform PickScrollViewMoveNode;

	public Transform WeaponModelDownloader;

	public Transform LastKillDownloader;

	public UIPanel IncidentalDynamicPanel;

	public GameObject Shared;

	public UILabel SharedNameLabel;

	public UILabel SharedDescLabel;

	public UISprite NameSprite;

	public GameObject SharedWeaponKillCountContainer;

	public GameObject Self;

	public GameObject ZoomSwitchCon;

	public GameObject SpecialGift;

	public UIButton ButtonSpecialGift;

	public GameObject ItemBG;

	public GameObject EvogunVipTip;

	public Transform CollectionTrialBtnContainer;

	public GameObject MorePrivilegeContainer;

	public UILabel MorePrivilegeLabel;

	public GameObject WishListBtnPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
