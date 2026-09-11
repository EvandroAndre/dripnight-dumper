using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_RewardBoxItemView : UIBaseView
{
	public GameObject RewardBoxSpecialEffect;

	public UINetworkTexture RewardLabelBg;

	public UILabel RewarRequestNum;

	public UINetworkTexture RewardBoxIconTexture;

	public GameObject RewardBoxNormalEffect;

	public UIButton RewardBoxBtn;

	public UINetworkTexture SpriteRedDot;

	public UINetworkTexture TextureRedDot;

	public GameObject RewardBoxShowNormalEffect;

	public GameObject RewardBoxShowGrandEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
