using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudWeaponPropertyItemView : MonoBehaviour
{
	public UILabel PropertyName;

	public UIProgressBar PropertyBar;

	public UILabel PropertyValue;

	public GameObject NormalWeaponReinforcedIcon;

	public GameObject IsReinforcedWeaponReinforcedIcon;

	public void SetData(EDDCGAGJBLO weaponParams, uint itemId, EWeaponScoreID scoreId, string propertyName)
	{
	}

	public void SetWeaponReinforcedIcon(bool show, bool isReinforced)
	{
	}
}
