using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

public class UIMysteryMallThemeView : MonoBehaviour
{
	public EThemeType ThemeType;

	public UIProgressBar BarCostProgress;

	public Transform BarPoint;

	public MeshRenderer BarUV1;

	public MeshRenderer BarUV2;

	public Transform Bar;

	public UILabel LabelLuckNum;

	public UILabel LabelSuperRewardDiscount;

	public UILabel LabelSuperRewardItemName;

	public MeshRenderer VFXLuckNum;

	public GameObject ContainerEffect;

	public GameObject TabSelectEffect;

	public UISprite SpriteShare;

	public UISprite SpriteSwitch;

	public UISprite SpritePurchase;

	public GameObject MainObject;

	public List<uint> ShopIdList;

	public void SetThemeActive(bool isCurrentTheme)
	{
	}

	public void SetViewData(ClientMysteryShopSwitchDesc curPoolDesc)
	{
	}

	public static void SetSuperDiscountPriceTheme(UILabel label)
	{
	}

	public void RefreshBar()
	{
	}

	public void SetTabSelectEffect(UIStandardTopTabItemController itemCtrl)
	{
	}

	public static void SetItemSuperContainerTransform(Transform transform)
	{
	}

	private void RefreshBarUVMaterial(MeshRenderer barUV01, MeshRenderer barUV02)
	{
	}

	private void RefreshBarLength(Transform bar, float barValue, float maxPosX, float maxScaleX)
	{
	}

	public static void SetCostNumTheme(UILabel LabelCostNum)
	{
	}

	public static void SetPriceTipTheme(UILabel label)
	{
	}

	public static void SetCountDownTheme(UICountDownController ctrl)
	{
	}
}
