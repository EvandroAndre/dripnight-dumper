using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedTokenWheelAwardItemViewSetting : MonoBehaviour
{
	public UIButton AwardBtn;

	public BaseItemView2 BaseInfoView;

	public UISprite QualityBG;

	public UISprite ItemIcon;

	public GameObject ClaimedState;

	public GameObject OwnedState;

	public GameObject NormalState;

	public UISprite TokenIcon;

	public UILabel TokenNumberLabel;

	public Transform CanExchangeVFXContainer;

	public UINetworkTexture RewardItemCDN;

	public GameObject NoDiamondExchangeState;

	public GameObject DiamondExchangeState;

	public UISprite TokenIconWithDiamond;

	public UILabel TokenNumberLabelWithDiamond;

	public UISprite DiamondIcon;

	public UILabel DiamondNumberLabel;
}
