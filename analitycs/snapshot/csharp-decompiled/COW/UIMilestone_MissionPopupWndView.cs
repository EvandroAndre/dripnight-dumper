using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_MissionPopupWndView : UIBaseView
{
	public UILabel LabelTitle;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UINetworkTexture TextureBg;

	public UILabel LabelRefreshTime;

	public UINetworkTexture TextureBtnClose;

	public UIButton AllClaimedBtn;

	public UINetworkTexture AllClaimedBtnCDN;

	public UITable MissionList;

	public UIButton BtnMaskClose;

	public GameObject DialogTips;

	public UITable Obtain;

	public UILabel ObtainBRText;

	public UILabel ObtainCSText;

	public UILabel ObtainLWText;

	public UINetworkTexture DialogTextureRole;

	public UINetworkTexture DialogTextureBg;

	public UINetworkTexture ObtainTextureTokenIcon;

	public UILabel TokenLimitText;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
