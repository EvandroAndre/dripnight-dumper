using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentView : UIBaseView
{
	public UIScrollView ScrollView;

	public UIWidget LeftContainer;

	public UITable LeftGrid;

	public UIWidget RightContainer;

	public UILabel PrimePointsLabel;

	public GameObject PrimeContainer;

	public GameObject LeftTab;

	public UIButton PrimeBtn;

	public UISprite TabBg;

	public UILabel PrimeTitleLabel;

	public Transform PrimeBadge;

	public GameObject PrimeLevelUpVFX;

	public GameObject PrimePointsVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
