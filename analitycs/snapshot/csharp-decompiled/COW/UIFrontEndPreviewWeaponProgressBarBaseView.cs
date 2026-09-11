using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponProgressBarBaseView : UIFrontEndPreviewUIComponentBaseView
{
	public UIButton TipsBtn;

	public UIWidget TipsBtnWidget;

	public UIButton GotoBtn;

	public GameObject Progress;

	public UIProgressBar BeforBar;

	public UIProgressBar AfterBar;

	public UILabel PercentLbl;

	public Transform TipsPos;

	public Transform TipsPosFullScreen;

	public UIColor ProgressBarBg;

	public UISprite BG;
}
