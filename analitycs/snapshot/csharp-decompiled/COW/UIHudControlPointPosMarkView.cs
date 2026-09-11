using GCommon;
using UnityEngine;

namespace COW;

public class UIHudControlPointPosMarkView : UIBaseView
{
	public UISprite NormalState;

	public GameObject TimerEffectRoot;

	public GameObject TimeUpEffect;

	public UISprite GeneratorHP;

	public UISprite GeneratorHPBg;

	public GameObject Warehousewaring;

	public GameObject WarehouseRoot;

	public UISprite WarehouseHPMask;

	public UISprite ScrambleState;

	public UILabel ControlPointName;

	public UILabel PointStatusLabel;

	public UILabel Timer;

	public GameObject ArrowLeft;

	public GameObject ArrowUp;

	public GameObject ArrowDown;

	public GameObject ArrowRight;

	public UILabel DistanceLabel;

	public UIWidget Container;

	public UIWidget MiniContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
