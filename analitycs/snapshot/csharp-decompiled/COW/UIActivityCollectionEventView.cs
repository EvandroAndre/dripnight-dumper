using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityCollectionEventView : UIBaseView
{
	public UINetworkTexture NetworkTexture;

	public GameObject IntroBG;

	public UISprite IntroBGSprite;

	public UITable IntroRoot;

	public UILabel Introduction;

	public UILabel Time;

	public GameObject Progress;

	public UILabel ProgressNum;

	public UIProgressBar ProgressBar;

	public GameObject Content;

	public UIScrollView SigninScrollView;

	public UIGrid SigninGrid;

	public MultiShadowText MultiShadow;

	public UICountDownLabel CountDownLabel;

	public GameObject CountDown;

	public UIButton CountDownBtn;

	public UILabel InfoLabel0;

	public UIButton TokenBtn0;

	public UISprite TokenSprite0;

	public UILabel InfoLabel1;

	public UIButton TokenBtn1;

	public UISprite TokenSprite1;

	public UILabel InfoLabel2;

	public UIButton StoreBtn;

	public UIScrollView CollectionScrollView;

	public UITable CollectionTable;

	public UINetworkTexture ExchangeBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
