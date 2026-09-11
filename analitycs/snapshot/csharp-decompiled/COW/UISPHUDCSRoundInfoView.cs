using UnityEngine;

namespace COW;

public class UISPHUDCSRoundInfoView : MonoBehaviour
{
	public UISprite LeftTechGetItem;

	public UISprite RightTechGetItem;

	public GameObject LeftWinItem;

	public UILabel LeftWinNumItem;

	public GameObject RightWinItem;

	public UILabel RightWinNumItem;

	public GameObject TechEmptyItem;

	public GameObject CurRoundItem;

	public GameObject AfterRoundItem;

	public UILabel AfterRoundNum;

	private int m_curRoundNum;

	public void SetRoundNum(int roundNum)
	{
	}

	public void RefreshCurRound(int curRound)
	{
	}

	public void onTeamWin(bool winOnLeft)
	{
	}

	public void InitTechItem(bool show_tech)
	{
	}

	public void RefreshTechItem(bool winOnLeft)
	{
	}
}
