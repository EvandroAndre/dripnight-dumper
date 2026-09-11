using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEnergyStoneMarkView : UIBaseView
{
	public UISprite ArrowUp;

	public UISprite arrowRight;

	public UISprite arrowDown;

	public UISprite arrowLeft;

	public GameObject MyTeam;

	public GameObject OppoTeam;

	public UILabel Distance;

	public EnergyStoneMarkScore ScoreTemplete;

	public Transform ScorePosition;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
