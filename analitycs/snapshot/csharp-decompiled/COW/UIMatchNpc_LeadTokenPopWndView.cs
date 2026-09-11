using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_LeadTokenPopWndView : UIBaseView
{
	public UIEasyList TokenItemContainer;

	public UILabel Desc;

	public UISprite CloseBtnSpriteIcon;

	public UIButton CloseBtn;

	public UILabel TitleLabel;

	public UINetworkTexture BgTexture;

	public UINetworkTexture CloseBtnTextureIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
