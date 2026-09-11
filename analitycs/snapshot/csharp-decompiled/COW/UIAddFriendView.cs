using GCommon;
using UnityEngine;

namespace COW;

public class UIAddFriendView : UIBaseView
{
	public Transform ModePrefer;

	public Transform Gender;

	public UIScrollView FriendListScrollView;

	public UIEasyList FriendList;

	public UILabel FriendListEmptyHint;

	public UISprite EmptyBG;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UIButton RefreshSelectBtn;

	public UIButton ClearButton;

	public UIButton RefreshBtn;

	public GameObject RefreshGreyObj;

	public UICountDownLabel RefreshCDLabel;

	public UIButton Language;

	public UISprite LanguageSprite;

	public UILabel LanguageLabel;

	public Transform TimeActive;

	public UILabel InterestLabel;

	public UISprite ExpandSprite;

	public UIButton ExtendButton;

	public GameObject ExpandContainer;

	public UIGrid SearchLeftGrid;

	public GameObject QRCodeBtnGameObject;

	public UIButton QRCodeBtn;

	public GameObject QRSCanBtnGameObject;

	public UIButton QRSCanBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
