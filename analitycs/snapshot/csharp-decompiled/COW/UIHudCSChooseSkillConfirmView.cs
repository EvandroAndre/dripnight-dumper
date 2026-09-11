using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSChooseSkillConfirmView : UIBaseView
{
	public GameObject ConfirmedSprite;

	public UISprite MemberIcon;

	public UILabel ConfirmedNum;

	public UILabel TotalNum;

	public UILabel ReadyLabel;

	public UISprite ReadyIcon;

	public GameObject Solo;

	public GameObject Dual;

	public Transform TeammatePos;

	public Transform EnemyPos;

	public Transform Teammate1Pos;

	public Transform Teammate2Pos;

	public Transform Enemy1Pos;

	public Transform Enemy2Pos;

	public GameObject ShowChooseSkill;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
