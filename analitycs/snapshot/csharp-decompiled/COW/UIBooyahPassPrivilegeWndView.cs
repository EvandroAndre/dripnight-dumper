using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassPrivilegeWndView : UIBaseView
{
	public GameObject First;

	public GameObject Second;

	public UILabel GradeLabel;

	public UILabel DiscountLabel;

	public UIButton SkipMaskBtn;

	public UILabel IntroduceLabel;

	public UIGrid RewardGrid;

	public UIButton OkayBtn;

	public GameObject ActivatePrivilegeNode;

	public GameObject GainBpNode;

	public UILabel HighestGradeLabel;

	public UINetworkTextureExt CDN;

	public Transform Bg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
