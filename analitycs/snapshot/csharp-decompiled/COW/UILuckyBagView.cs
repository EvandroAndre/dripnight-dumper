using GCommon;
using UnityEngine;

namespace COW;

public class UILuckyBagView : UIBaseView
{
	public UIScrollView ScrollView;

	public UIEasyList Grid;

	public GameObject NoLuckyBagTips;

	public UIButton ClaimAllBtn;

	public Transform DefaultBagPos;

	public UIGrid GoldGrid;

	public UIGrid PurpleGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
