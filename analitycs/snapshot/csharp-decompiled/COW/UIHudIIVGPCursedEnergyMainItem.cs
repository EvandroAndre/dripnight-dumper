using UnityEngine;

namespace COW;

public class UIHudIIVGPCursedEnergyMainItem : MonoBehaviour
{
	public UISprite Icon;

	public UILabel Name;

	public UIButton BtnDetail;

	public UIButton BtnLevelUp;

	public UILabel LevelUpCost;

	public UIButton BtnUnlock;

	public UILabel UnlockCost;

	public GameObject Selected;

	public UIButton BtnSelect;

	public GameObject[] LevelIcon;

	public GameObject LockMask;

	public UISprite UnlockBg;

	public UISprite LevelUpBg;

	public UISprite LevelUpIcon;

	public UISprite UnlockIcon;

	public Transform ActiveEffect;
}
