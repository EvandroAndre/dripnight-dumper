using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonReplaySocialSocialTagView : UIBaseView
{
	public UIButton NormalLikeBtn;

	public UILabel FriendName;

	public UITable Relations;

	public GameObject Friend;

	public GameObject Myself;

	public UILabel MyName;

	public UINetworkTexture EmptyCDN;

	public GameObject EmptyContainer;

	public GameObject NormalLikeUnSelect;

	public GameObject NormalLikeSelect;

	public Animation NormalLikeSelectAnim;

	public GameObject FriendLeftBg;

	public GameObject FriendRightBg;

	public GameObject MySelfLeftBg;

	public GameObject MySelftRightBg;

	public GameObject PopDown;

	public GameObject BottomAnchor;

	public Transform LeftDownloadContainer;

	public Transform RightDownloadConainter;

	public UITable PopDownTable;

	public UITable PopUpTable;

	public UIScrollView PopDownScrollView;

	public UIScrollView PopUpScrollView;

	public GameObject PopUp;

	public UISprite LeftBGBG;

	public UISprite RightBGBG;

	public GameObject NormalLikeVFX;

	public GameObject SpecialLikeNotice;

	public GameObject NormalLike;

	public GameObject LeftEditorSaveContainer;

	public GameObject RightEditorSaveContainer;

	public UIButton LeftEditorSaveButton;

	public UIButton RightEditorSaveButton;

	public GameObject LeftEditorIcon;

	public GameObject LeftSaveIcon;

	public GameObject RightEditorIcon;

	public GameObject RightSaveIcon;

	public GameObject RightLine;

	public GameObject LeftLine;

	public UIButton Mask;

	public GameObject MaskPanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
