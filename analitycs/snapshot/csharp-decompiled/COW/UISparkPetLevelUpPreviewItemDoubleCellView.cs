using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetLevelUpPreviewItemDoubleCellView : UIBaseView
{
	public GameObject Unlocked;

	public GameObject Locked;

	public UISprite RewardIcon;

	public UILabel NumLabel;

	public UIButton FeatureBtn;

	public UILabel RewardNum;

	public UILabel ExpireTime;

	public UIButton RewardButton;

	public Transform DetailAwardPopPos;

	public UINetworkTexture FeatureIconCDN;

	public GameObject Claimed;

	public UIButton RewardCell;

	public GameObject UIFX_UISparkPet_Cell;

	public UILabel FeatureName;

	public UISprite FeatureIcon;

	public UILabel UnlockedFeatureName;

	public UISprite UnlockedFeatureIcon;

	public UINetworkTexture AwardIconTexture;

	public GameObject ObtainedButNotUsed;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
