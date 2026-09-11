using GCommon;
using UnityEngine;

namespace COW;

public class UIPopupMessageBoxView : UIBaseView
{
	public UIPanel MainWidget;

	public TweenAlpha BgTweenAlpha;

	public UISprite BGSprite;

	public TweenScale WindowTweenScale;

	public TweenAlpha WindowTweenAlpha;

	public GameObject BtnCloseGO;

	public UIButton BtnClose;

	public UILabel Title;

	public UITable TableBtns;

	public GameObject BtnCancelGO;

	public UIButton BtnCancel;

	public UISprite BtnCancelSprite;

	public UILabel BtnCancelLabel;

	public GameObject BtnOKGO;

	public UIButton BtnOK;

	public UISprite BtnOKSprite;

	public UILabel BtnOKLabel;

	public UISprite TextArea;

	public UITextList Info;

	public UILabel Note;

	public GameObject OfflineTips;

	public UIButton BtnRetry;

	public UILabel BtnRetryLabel;

	public GameObject TipContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
