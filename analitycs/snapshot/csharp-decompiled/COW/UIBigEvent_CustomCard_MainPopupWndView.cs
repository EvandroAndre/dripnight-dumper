using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_MainPopupWndView : UIBaseView
{
	public UINetworkTexture TextureBg;

	public UINetworkTexture TextureTitle;

	public UILabel LabelTitle;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UINetworkTexture TextureBtnClose;

	public Transform Center;

	public UIGrid TabGrid;

	public UIToggleButtonGroup TabGroup;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
