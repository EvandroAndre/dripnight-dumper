using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2ShoppingMallContainerView : UIBaseView
{
	public GameObject TopShowContainer;

	public GameObject NormaShowContainer;

	public UINetworkTexture CDNBG;

	public GameObject Loading;

	public UIScrollView TopShowScrollView;

	public UIScrollView NormalShowScrollView;

	public GameObject CDNTitleGameObject;

	public UINetworkTexture CDNTitle;

	public GameObject GoposButtonGroup;

	public UIButton GoPosButton;

	public UISprite Icon;

	public UIButton TopShowBtn;

	public UITable2 TopShowTable;

	public UITable2 NormalShowTable;

	public GameObject VFXContainer;

	public GameObject HighLight;

	public GameObject CountDownNode;

	public UILabel CountDownLabel;

	public Transform LaunchTagRoot;

	public UIColor ColorBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
