using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class LadderMatchStarGroup
{
	public const string ANIMATION_LABEL_CHANGE = "UILadderCSMatchLabelStarChange";

	private List<LadderMatchStar> starsList;

	private uint currentOnCnt;

	private uint starCnt;

	private Transform m_starRoot;

	private GameObject m_starRes;

	private UILabel m_starLabel;

	private UILabel m_starLabelAfter;

	private Animation m_labelAnim;

	public Transform LabelStarPos;

	private bool isStarRank;

	public LadderMatchStarGroup(Transform startRoot, GameObject starRes, UILabel rankLabel, UILabel rankLabel_after, Animation labelAnimation, Transform labelStarPos)
	{
	}

	public void InitMatchStarGroup(uint starCont)
	{
	}

	public void InitMatchRankLabel()
	{
	}

	private void CreateStar(uint starCount)
	{
	}

	public void InitStarsState(uint starOnCnt)
	{
	}

	public void ChangeStars(bool isUp)
	{
	}

	public void ChangeLabelStars(bool isUp)
	{
	}

	public void ShowFinalLabelStar()
	{
	}

	public LadderMatchStar GetNeedGainStar()
	{
		return null;
	}

	public LadderMatchStar GetNeedLoseStar()
	{
		return null;
	}

	public Animation GetLabelAnimation()
	{
		return null;
	}
}
