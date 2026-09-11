using GCommon;
using UnityEngine;

namespace COW;

public class UIHGSnowTalentItemView : UIBaseView
{
	public Transform Node1;

	public Transform Node2;

	public Transform Node3;

	public UIHGSnowTalentItemLineAnimView BranchToMainStraightLine;

	public UIHGSnowTalentItemLineAnimView MainToBranchStraightLine;

	public UIHGSnowTalentItemLineAnimView BranchToMainCurve;

	public UIHGSnowTalentItemLineAnimView MainToBranchCurve;

	public UIHGSnowTalentItemLineAnimView MainToMainStraightLine;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
