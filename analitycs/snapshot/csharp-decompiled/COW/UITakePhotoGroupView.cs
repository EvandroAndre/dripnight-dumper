using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupView : UIBaseView
{
	public UIEasyList EasyList;

	public Transform CamerContainer;

	public Transform AvatarContainer;

	public Transform NamePos1;

	public Transform NamePos2;

	public Transform NamePos3;

	public Transform NamePos4;

	public Transform TemplateContainer;

	public GameObject ListContainer;

	public UILabel SelectNumLabel;

	public Transform PhotoBtnContainer;

	public UIWidget ListContainerWidget;

	public UIButton ExpandBtn;

	public UISprite IsExpandIcon;

	public UISprite UnExpandIcon;

	public UIButton CloseBtn;

	public Animation RightAnim;

	public UIWidget DragWidget;

	public UIPanel ScrollView;

	public UIColor Color;

	public UIWidget BG_Container;

	public UILabel IntimacyLabel;

	public GameObject Line;

	public UIButton CloseFriendListBtn;

	public Transform EmojiItemContainer;

	public UIButton UnSelectEditBackgroundBtn;

	public UIWidget PreviewContainer;

	public UINetworkTexture TemplateBigPreview;

	public UIButton FilterBtn;

	public UIWidget FilterBtnWidget;

	public GameObject FilterIsOpen;

	public Transform FilterContainer;

	public Transform NamePos5;

	public UICamera GhostCamera;

	public Camera GhostCam;

	public UILabel FilterBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
