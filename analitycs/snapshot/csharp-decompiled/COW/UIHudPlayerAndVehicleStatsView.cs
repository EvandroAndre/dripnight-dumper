using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerAndVehicleStatsView : UIBaseView
{
	public Transform ArmorStats;

	public UISprite Mark;

	public UIGrid Skills;

	public UISprite SkillTemplate;

	public UISprite HPBar;

	public UILabel LabelHP;

	public UISprite VehicleHPBarThumb;

	public UISprite VehicleHPBar;

	public UILabel LabelVehicleHP;

	public UIGrid BuffNode;

	public UIGrid UseSkillNode;

	public Transform LevelStats;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
