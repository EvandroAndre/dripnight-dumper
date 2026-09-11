using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetLevelUpPreviewItemSingleCellView : UIBaseView
{
	public UILabel RewardNum;

	public UILabel ExpireTime;

	public Transform DetailAwardPopPos;

	public UISprite Icon;

	public UIButton DetailButton;

	public GameObject Claimed;

	public UIButton ClickButton;

	public GameObject UIFX_UISparkPet_Cell;

	public GameObject AwardCell;

	public GameObject FeatureCell;

	public UIButton FeatureBtn;

	public GameObject Locked;

	public GameObject Unlocked;

	public UILabel NumLabel;

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
