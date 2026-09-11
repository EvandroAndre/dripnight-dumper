using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomView : UIBaseView
{
	public Transform LeftGridRoot;

	public Transform RightGridRoot;

	public Transform LeftCollectionRoot;

	public ProfileCustomDragTemplate DragTemplate;

	public Transform PersonalBoardRoot;

	public GameObject Desc;

	public UILabel DescLabel;

	public UILabel DescTitle;

	public UISprite DescBG;

	public UIButton RevokeBtn;

	public UIButton ResetBtn;

	public UIButton QuitBtn;

	public UIButton SaveBtn;

	public GameObject DescOneLine;

	public GameObject DescBGOneLine;

	public UILabel DescTitleOneLine;

	public UIButton AutoBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
