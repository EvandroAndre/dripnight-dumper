using UnityEngine;

namespace COW;

public class LadderMatchStar
{
	public const string ANIMATION_GAINSTAR = "UILadderCSMatchStarUp";

	public const string ANIMATION_LOSESTAR = "UILadderCSMatchStarLose";

	public GameObject Star;

	private Animation StarAnimation;

	private Transform OnState;

	private Transform OffState;

	public void InitStar(GameObject star, Transform parent)
	{
	}

	public void SetStarOn()
	{
	}

	public void SetStarOff()
	{
	}

	public Animation GetStarAnimation()
	{
		return null;
	}

	public bool ResetAnimOnEnable(bool b)
	{
		return false;
	}

	public void SetStarUpSprite()
	{
	}

	public void SetStarDownSprite()
	{
	}
}
