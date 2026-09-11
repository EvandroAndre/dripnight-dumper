using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReplayAchievementCtrlView : UIBaseView
{
	public GameObject Container;

	public Animation AchievementAnim;

	public UISprite Icon;

	public UILabel Name;

	public GameObject MultiKillEffect;

	public GameObject OneKill;

	public GameObject TwoKill;

	public GameObject ThreeKill;

	public UILabel OneKillLabel;

	public UILabel TwoKillLabel;

	public UILabel ThreeKillLabel;

	public GameObject AceEffect;

	public UILabel FinalKill_Number;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
