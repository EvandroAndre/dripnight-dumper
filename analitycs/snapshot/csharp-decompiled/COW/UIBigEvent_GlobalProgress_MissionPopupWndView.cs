using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_GlobalProgress_MissionPopupWndView : UIBaseView
{
	public UILabel LabelTitle;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UIScrollView MissionScrollView;

	public UITable MissionList;

	public UINetworkTexture TextureBg;

	public UILabel LabelRefreshTime;

	public UINetworkTexture BtnCloseCDN;

	public UINetworkTexture TextureTitleBg;

	public UINetworkTexture RefreshTimeIcon;

	public UIButton BtnClameAll;

	public UINetworkTexture AllClaimedBtnCDN;

	public UILabel AllClaimedBtnLabel;

	public UINetworkTexture ClickMaskBg;

	public UIButton ClickMaskBtn;

	public Animation Animation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
