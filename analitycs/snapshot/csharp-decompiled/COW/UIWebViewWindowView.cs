using GCommon;
using UnityEngine;

namespace COW;

public class UIWebViewWindowView : UIBaseView
{
	public UISprite WebViewArea;

	public UILabel ProgressLabel;

	public GameObject LoadingGIF;

	public UIProgressBar WebViewProgressBar;

	public UIWidget WebViewProgressBarThumb;

	public UIButton CloseButton;

	public UIButton ExternalButton;

	public UIButton ReloadButton;

	public GameObject ReloadTips;

	public UILabel ReloadLabel;

	public UIButton ReturnButton;

	public UISprite ReturnButtonIcon;

	public GameObject LoadingFall;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
