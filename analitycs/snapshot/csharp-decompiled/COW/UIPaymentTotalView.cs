using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentTotalView : UIBaseView
{
	public UIButton GotoButton;

	public UILabel TopUpInTotalLabel;

	public UILabel TopUpInTotalLabel_1;

	public UILabel TopUpInTotalLabel_2;

	public GameObject ProgressBarContainer;

	public UILabel ProgressDetailLabel_1;

	public UISprite ProgressDetailSprite_1;

	public UILabel ProgressDetailLabel_2;

	public UISprite ProgressDetailSprite_2;

	public UILabel ProgressDetailLabel_3;

	public UISprite ProgressDetailSprite_3;

	public UIWidget ProgressBarLeft;

	public UIWidget ProgressBarRight;

	public UITexture ProgressCursor;

	public UISprite ProgressBarSprite;

	public UIGrid ItemsGrid;

	public UINetworkTextureExt CDNTexture;

	public GameObject CDNFX;

	public UIButton Hint;

	public Animation Anim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
