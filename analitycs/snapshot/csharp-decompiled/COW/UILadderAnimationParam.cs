using GCommon;
using UnityEngine;

namespace COW;

public class UILadderAnimationParam : MonoBehaviour
{
	private UISprite m_BRRankIconBefore;

	private UISprite m_BRRankIconAfter;

	private UISprite m_CSRankIconBefore;

	private UISprite m_CSRankIconAfter;

	private UILabel m_RankLabelBefore;

	private UILabel m_RankLabelAfter;

	private void Awake()
	{
	}

	public void SetLabelAndIcon(string beforeRankName, string afterRankName, ResourceID beforeRankIcon, ResourceID afterRankIcon, bool isBR = true)
	{
	}

	private void SetVisiableState(bool isBR)
	{
	}
}
