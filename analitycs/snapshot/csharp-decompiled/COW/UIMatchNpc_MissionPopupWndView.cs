using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_MissionPopupWndView : UIBaseView
{
	public UILabel LabelTitle;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UIScrollView MissionScrollView;

	public UIEasyList MissionList;

	public UINetworkTexture TextureBg;

	public UILabel LabelRefreshTime;

	public UINetworkTexture TextureBtnClose;

	public GameObject UIMatchNpc_MissionPopupWnd;

	public UIButton AllClaimedBtn;

	public UINetworkTexture AllClaimedBtnCDN;

	public UINetworkTexture WndArrow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
