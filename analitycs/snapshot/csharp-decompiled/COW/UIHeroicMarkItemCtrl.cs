using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHeroicMarkItemCtrl : MonoBehaviour
{
	public UILabel IconLabel;

	public UISprite IconBg;

	public UISprite SIcon;

	public UILabel Desc;

	public GameObject DefaultLabel;

	public GameObject VfxContainer;

	private GameObject m_CacheEffGo;

	public GameObject HeroicMarkIconContainer;

	public GameObject PeakTournamentContainer;

	public UICSPeakTournamentRankIconController CSPeakTournamentRankIconCtrl;

	public void SetData(uint season, ResourceID iconBgRes, ResourceID vfxRes, ResourceID sIconRes, bool isDefault, EHeroicMarkRankType rankType, HeroicMarkData conf, bool isBR = true)
	{
	}

	public void ClearEffect()
	{
	}

	public void SetCSPeakTournamentData(PlayerCSPeakStatsHistory historyInfo, bool isDefault)
	{
	}
}
