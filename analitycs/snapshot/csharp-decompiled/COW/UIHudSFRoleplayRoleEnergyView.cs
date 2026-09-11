using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSFRoleplayRoleEnergyView : UIBaseView
{
	public UISprite RoleIcon;

	public UISprite EnergyCD;

	public GameObject EnergyContainer;

	public UIButton EnergyBtn;

	public GameObject DetailContainer;

	public UITable DetailTable;

	public UILabel RoleName;

	public UILabel RoleDesc;

	public UISprite DetailBg;

	public GameObject TipsContainer;

	public UILabel TipsLabel;

	public Transform RoleIconUIFXTrans;

	public UILabel EnergyNumber;

	public Transform EnergyUIFXTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
