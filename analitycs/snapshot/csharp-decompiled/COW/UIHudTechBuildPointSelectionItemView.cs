using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTechBuildPointSelectionItemView : UIBaseView
{
	public UISprite ConstructionIcon;

	public UILabel ConstructionTitle;

	public UILabel ConstructionDesc;

	public UICenterTargetHelper SufficientFundsGroupCenterTargetHelper;

	public GameObject SufficientFundsGroup;

	public UILabel SufficientFundsValue;

	public GameObject GrayMask;

	public GameObject AboveMaskGroup;

	public UIButton SelectionBtn;

	public GameObject InsufficientFundsGroup;

	public UICenterTargetHelper InsufficientFundsGroupCenterTargetHelper;

	public UILabel InsufficientFundsValue;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
