using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetLuckyDrawWndView : UIBaseView
{
	public UIEasyList EasyList;

	public UILabel CurrActiveDaysLabel;

	public UILabel RequiredActiveDaysLabel;

	public UIButton DrawBtn;

	public UIButton CloseBtn;

	public GameObject RightArrow;

	public UIScrollView PrizeScrollView;

	public UINetworkTexture Bg;

	public UILabel LoginDescLabel;

	public UILabel DrawNumebrsLabel;

	public UIButton DrawBtnDisabble;

	public GameObject WinningUIFX;

	public UILabel DrawNumebrsLabel2;

	public GameObject ButtonUIFX;

	public GameObject DrawableUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
