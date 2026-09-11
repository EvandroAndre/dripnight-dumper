using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_CSRoundResultView : UIBaseView
{
	public Animator Animator;

	public UILabel myScoreCurrent;

	public UILabel myScorePrevious;

	public TweenAlpha myTweenAlpha;

	public TweenPosition myTweenPos;

	public UILabel oppoScoreCurrent;

	public UILabel oppoScorePrevious;

	public TweenAlpha oppoTweenAlpha;

	public TweenPosition oppoTweenPos;

	public UISprite RightBG;

	public UISprite LeftBG;

	public GameObject LeftVFX;

	public GameObject RightVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
