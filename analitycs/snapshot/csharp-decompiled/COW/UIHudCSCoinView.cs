using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSCoinView : UIBaseView
{
	public UILabel coin;

	public GameObject Root;

	public GameObject VFX;

	public GameObject OffsetNode;

	public GameObject ReinforceTokenNode;

	public Animation ReinforceTokenAnim;

	public UILabel ReinforceTokenLabel;

	public GameObject GetReinforceTokenVFX;

	public UIButton ReinforceTokenBtn;

	public GameObject ReinforceTokenTipNode;

	public GameObject LeftNode;

	public GameObject RightNode;

	public UILabel ReinforceTokenLabel_Old;

	public UILabel number;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
