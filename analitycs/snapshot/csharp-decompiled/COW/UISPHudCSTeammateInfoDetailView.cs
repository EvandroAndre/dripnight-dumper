using UnityEngine;

namespace COW;

public class UISPHudCSTeammateInfoDetailView : MonoBehaviour
{
	public GameObject HP;

	public UISprite Hpbarfg;

	public UILabel NameTxt;

	public TweenPosition TWNamePosition;

	public TweenAlpha TWNameAlpha;

	public UISprite HelmetBG;

	public UISprite FilledHelmet;

	public UISprite FilledHelmetEnhanced;

	public UISprite HelmetLevel;

	public UISprite ArmorBG;

	public UISprite FilledArmor;

	public UISprite FilledArmorEnhanced;

	public UISprite ArmorLevel;

	public TweenAlpha TWMoneyAlpha;

	public UISprite WeaponIconMain1;

	public TweenAlpha WeaponTween1;

	public GameObject FireEffectGo1;

	public UISprite WeaponIconMain2;

	public TweenAlpha WeaponTween2;

	public GameObject FireEffectGo2;

	public GameObject SelectBG;

	public GameObject BombIcon;

	public GameObject PliersIcon;

	private int curHelmetLevel;

	private int curArmorLevel;

	private string FilledArmorIcon;

	private string FilledArmorIconBG;

	private string FilledArmorIconExplode;

	private string FilledArmorIconExplodeBG;

	private string FilledHeadIcon;

	private string FilledHeadIconBG;

	private string FilledHeadIconProtect;

	private string FilledHeadIconProtectBG;
}
