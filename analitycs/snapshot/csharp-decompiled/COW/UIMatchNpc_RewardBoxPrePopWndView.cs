using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_RewardBoxPrePopWndView : UIBaseView
{
	public UILabel RewardGetRequestLabel;

	public UIGrid RewardGridContainer;

	public UINetworkTexture CdnBg;

	public UIButton CloseBtn;

	public UISprite CloseBtnSpriteIcon;

	public UILabel TitleLabel;

	public UINetworkTexture CloseBtnTextureIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
