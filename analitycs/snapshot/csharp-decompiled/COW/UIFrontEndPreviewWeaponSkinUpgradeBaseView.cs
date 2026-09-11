using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponSkinUpgradeBaseView : UIFrontEndPreviewUIComponentBaseView
{
	public bool NeedGoToVaultBtn;

	public UIToggleButton BtnWeaponSkinUpgradeLv1;

	public UIToggleButton BtnWeaponSkinUpgradeLvMax;

	public UIButton LevelUpBtn;

	public UILabel LabelWeaponSkinUpgradeLvMaxChosen;

	public UILabel LabelWeaponSkinUpgradeLvMaxUnChosen;

	public GameObject TipsContainer;

	public UILabel TipsLabel;
}
