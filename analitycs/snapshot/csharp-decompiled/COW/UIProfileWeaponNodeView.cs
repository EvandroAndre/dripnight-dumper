using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileWeaponNodeView : UIBaseView
{
	public GameObject Content;

	public GameObject WeaponContainer;

	public GameObject FilterContainer;

	public UIEasyList Grid;

	public UIListAnimQueueHelper ItemAnim;

	public Transform SeasonFilter;

	public Transform WeaponTypeFilter;

	public UIToggleButtonGroup Toggle;

	public UIToggleButton CsRankToggleBtn;

	public UIToggleButton BrRankToggleBtn;

	public GameObject Loading;

	public GameObject GoRank;

	public GameObject CSRank;

	public GameObject BRRank;

	public UIButton ButtonCSRank;

	public UIButton ButtonBRRank;

	public GameObject NoData;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
