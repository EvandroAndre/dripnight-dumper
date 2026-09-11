using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class QuickChatView : MonoBehaviour
{
	public UILabel m_IndexInTeam;

	public UILabel m_Message;

	public UISprite m_IndexBG;

	public UISprite OKImg;

	public UISprite OKImg1;

	public UISprite OKImg2;

	public UISprite HandImg;

	public UISprite HandImg1;

	public UISprite HandImg2;

	private Animation m_OKAnimation;

	private Animation m_OK1Animation;

	private Animation m_OK2Animation;

	private AnimatedAlpha m_OKAniAlpha;

	private AnimatedAlpha m_OK1AniAlpha;

	private AnimatedAlpha m_OK2AniAlpha;

	private HashSet<int> m_okedPlayer;

	private Vector3 m_TargetMarkPos;

	public int m_LastDistance;

	public bool m_IsPOI;

	public string m_POIName;

	public void SetDistanceInfo(Vector3 targetMarkPos)
	{
	}

	public bool UpdateMarkPos()
	{
		return false;
	}

	public void SetUIData(int index, string message, byte teamId, uint resItemId, string responseIcon = "")
	{
	}

	public void ShowOKImg(int teamIndex, byte teamId)
	{
	}

	public void Reset()
	{
	}

	private Color GetColorByIndex(int teamIndex, byte teamId)
	{
		return default(Color);
	}
}
