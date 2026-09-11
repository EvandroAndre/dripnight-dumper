using GCommon;
using UnityEngine;

namespace COW;

public class UITailorItemView : UIBaseView
{
	public UISprite TokenIcon;

	public UILabel TokenCnt;

	public GameObject ConditionUnLockEffect;

	public GameObject Condition;

	public UIGrid Grid;

	public TailorItemCondition ConditionTemplete;

	public Transform UITailorItem;

	public GameObject Equip;

	public GameObject Tips;

	public GameObject GuideEffect;

	public GameObject UnLockEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
