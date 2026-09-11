using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimePrivilegeView : UIBaseView
{
	public UIWidget PreviewWidget;

	public UIButton CheckBtn;

	public UICheckboxButton DoNotUseBtn;

	public GameObject CommonPreview;

	public GameObject CDNPreview;

	public UINetworkTexture CDNTexture;

	public GameObject GifPreview;

	public GameObject UIPreview;

	public UIScrollView ExpandScrollView;

	public GameObject MaxLevelPrivilege;

	public UITable ExpandTable;

	public UIScrollView ShrinkScrollView;

	public UITable ShrinkTable;

	public UIButton SwitchBtn;

	public UILabel CheckBtnLabel;

	public GameObject ChargeContainer;

	public UILabel TopUpDescLabel;

	public UIButton GoToTopUpBtn;

	public UINetworkTexture GIFTexture;

	public GameObject CenterTitle;

	public UILabel PrivilegeNameLabel;

	public UILabel ShareNum;

	public GameObject TopRightNotice;

	public UISprite SwitchArrowDown;

	public UISprite SwitchArrowUp;

	public UITable TopRightGrid;

	public GameObject CheckBtnContainer;

	public UIButton DisplayBtn;

	public GameObject EquipPrime;

	public GameObject NoEquipPrime;

	public GameObject SelectWndOpen;

	public Transform AvatarSelectWndPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
