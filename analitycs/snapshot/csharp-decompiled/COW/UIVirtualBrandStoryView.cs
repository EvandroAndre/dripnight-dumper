using GCommon;
using UnityEngine;

namespace COW;

public class UIVirtualBrandStoryView : UIBaseView
{
	public UIButton BtnKnowMore;

	public UILabel LabelIntroduction;

	public UILabel LabelSlogan;

	public UIEasyList BrandList;

	public Transform Draft;

	public UIButton BtnNextDraft;

	public UIButton BtnPreDraft;

	public Transform BrandBg;

	public UIScrollView ScrollView;

	public UIButton BtnLike;

	public GameObject LikeDefaultIcon;

	public GameObject LikedIcon;

	public UILabel LabelComing;

	public UIPanel GuideMaskPanel;

	public UIButton GuideMaskBtn;

	public GameObject LikeBubbleTips;

	public GameObject KnowMore;

	public GameObject LikeBG;

	public UIButton BtnDraftTips;

	public GameObject FutureSetDraft;

	public UIScrollView IntroScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
