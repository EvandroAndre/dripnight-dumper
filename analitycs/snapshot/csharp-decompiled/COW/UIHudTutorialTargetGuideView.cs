using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTutorialTargetGuideView : UIBaseView
{
	public UISprite TargetBG;

	public UILabel TargetLabel;

	public UILabel DistanceLabel;

	public GameObject GoMark;

	public GameObject GoArrow;

	public GameObject GoMarkPos;

	public GameObject Target;

	public UILabel EnemyLabel;

	public UISprite EnemyBG;

	public GameObject Distance;

	public GameObject Enemy;

	public GameObject Teammate;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
