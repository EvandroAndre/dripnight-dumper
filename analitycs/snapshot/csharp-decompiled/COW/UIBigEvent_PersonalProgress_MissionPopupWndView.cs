using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgress_MissionPopupWndView : UIBaseView
{
	public UILabel LabelTitle;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UIScrollView MissionScrollView;

	public UIEasyList MissionList;

	public UINetworkTexture TextureBg;

	public UILabel LabelRefreshTime;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
