using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchCoursePageView : UIBaseView
{
	public GameObject UICupMatchCoursePage;

	public UILabel CourseTitle;

	public UILabel Course;

	public UIButton TeamTier;

	public UILabel TierLevel;

	public UIButton ShowCourseBtn;

	public UIButton Share;

	public Transform CourseRewardContainer;

	public Transform CourseresultInfo;

	public Transform CourseInfo;

	public Transform ChallengeInfo;

	public UIButton GotoChallenge;

	public GameObject GotoChallengeTips;

	public GameObject ChallengeTips;

	public UIButton ShowAllReward;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
