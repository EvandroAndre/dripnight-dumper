using GCommon;
using UnityEngine;

namespace COW;

public class UIClanTrendPageView : UIBaseView
{
	public GameObject HaveMember;

	public UIScrollView HLScrollView;

	public UIWrapContent ScrollWrap;

	public UICenterOnChild ScollCentre;

	public UIGrid GridDots;

	public GameObject NoMember;

	public UILabel ClanNoticeRefreshTime;

	public UILabel ClanNoticeContent;

	public GameObject CanEdit;

	public GameObject NotEdit;

	public Transform EmoteContainer;

	public UIInput NoticeInputField;

	public UILabel NoticeInPutLabel;

	public GameObject EditBtn;

	public UIButton MaskBtn;

	public TweenPosition TrendPageTweenPos;

	public TweenAlpha TrendPageTweenAlp;

	public GameObject LuckyBagMessage;

	public UILabel LuckyBagLabel;

	public UIButton GoToLuckyBagBtn;

	public GameObject ContentNode;

	public UIScrollView MessageList;

	public GameObject EmptyNode;

	public GameObject NoMessageHint;

	public Transform BottomLeft;

	public UITable2 MessageListTable2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
