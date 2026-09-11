using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityWebviewView : UIBaseView
{
	public UIButton ReturnButton;

	public UIButton ReloadButton;

	public UIButton ExternalButton;

	public UISprite icon;

	public UIPanel Mask;

	public UIDragScrollView DragArea;

	public UIWidget DragWidget;

	public UIWidget WebViewArea;

	public UIScrollView ScrollView;

	public UILabel ProgressLabel;

	public GameObject LoadingGIF;

	public UIProgressBar WebViewProgressBar;

	public UIWidget WebViewProgressBarThumb;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
