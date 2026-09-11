using UnityEngine;

namespace COW;

public class UIHudCSSOTeamInfoView : MonoBehaviour
{
	public UISprite[] m_Sprites;

	public UISprite[] m_Hps;

	public Animation[] m_HpAnims;

	public TweenFill[] m_HpTween;

	public void SetColor(Color c)
	{
	}

	public void SetHp(byte hp)
	{
	}

	public void ShowHpAnim(byte lastRoundHp, byte currHp)
	{
	}
}
