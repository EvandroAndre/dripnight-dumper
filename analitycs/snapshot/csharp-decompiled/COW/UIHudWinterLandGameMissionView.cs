using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWinterLandGameMissionView : UIBaseView
{
	public UIProgressBar ProgressBar;

	public UIWidget BoundsWidget;

	public UILabel StartPointLabel;

	public GameObject MidPointSprite;

	public UILabel MidPointLabel;

	public GameObject EndPointSprite;

	public UILabel EndPointLabel;

	public GameObject MovePointLabelBG;

	public UILabel StayingCoundDown;

	public UILabel MoveingKey;

	public UILabel IslandTypeTips;

	public GameObject BigTipsPhase;

	public GameObject CountDownPhase;

	public UITable Table;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
