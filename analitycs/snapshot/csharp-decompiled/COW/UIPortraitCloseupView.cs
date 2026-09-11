using GCommon;
using UnityEngine;

namespace COW;

public class UIPortraitCloseupView : UIBaseView
{
	public GameObject NormalUIRoot;

	public UIButton ExitBtn;

	public Transform EmotePanelRoot;

	public UIButton GroupExitBtn;

	public Transform NamePos4;

	public Transform NamePos3;

	public Transform NamePos2;

	public Transform NamePos1;

	public UIEasyList FriendEasyList;

	public UILabel SelectNumLabel;

	public GameObject FriendsContainer;

	public Transform TemplateContainer;

	public UIButton ExpandBtn;

	public UISprite UnExpandIcon;

	public UISprite IsExpandIcon;

	public Animation FriendContainerAnim;

	public Transform OperateBtnContainer;

	public UIPanel RootPanel;

	public GameObject Right;

	public UIAnchor RightAnc;

	public GameObject TopLeft;

	public UIAnchor TopLeftAnc;

	public GameObject Top;

	public UIAnchor TopAnc;

	public UILabel IntimacyLabel;

	public GameObject Line;

	public UIButton CloseFriendListBtn;

	public Camera Vertical3DCamera;

	public PostEffectManager Vertical3DCameraPost;

	public UIButton GroupPhotoBtn;

	public UIButton VerticalBtn;

	public UIButton SettingBtn;

	public GameObject IsOpen;

	public UIGrid UIGrid;

	public Transform PetEmotePanel;

	public GameObject ItemRotateTouchArea;

	public GameObject FilterContainer;

	public UIButton FilterBtn;

	public UIWidget FilterBtnWidget;

	public GameObject FilterIsOpen;

	public UIButton FilterBtnGroup;

	public UIWidget FilterBtnGroupWidget;

	public Transform FilterContainerGroup;

	public GameObject FilterIsOpenGroup;

	public Transform NamePos5;

	public GameObject SettingPanelContainer;

	public UICamera FeatureBtnCamera;

	public Camera FeatureBtnCam;

	public UIAnchor BottomLeftAnc;

	public UILabel FilterBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
