using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchRewardBoxView : UIBaseView
{
	public UIButton RewardBtn;

	public UISprite RewardIcon;

	public GameObject VFX_Box04;

	public GameObject VFX_Box03;

	public GameObject VFX_Box02;

	public GameObject VFX_Box01;

	public GameObject VFX_Up;

	public UILabel RewardName;

	public GameObject Claimed;

	public GameObject Result;

	public Transform Result1;

	public Transform Result2;

	public Transform Result3;

	public CupMatchRewardBoxResultItem ResultTemplate;

	public GameObject RedPoint;

	public Transform ResultTopPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
