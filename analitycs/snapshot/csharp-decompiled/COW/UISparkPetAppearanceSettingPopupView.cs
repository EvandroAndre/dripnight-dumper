using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetAppearanceSettingPopupView : UIBaseView
{
	public UIButton BackButton;

	public UIButton Temper2Btn;

	public UIButton Temper1Btn;

	public UIButton Temper3Btn;

	public UILabel TemperLabel1;

	public GameObject TemperSelect1;

	public UILabel TemperLabel2;

	public GameObject TemperSelect2;

	public UILabel TemperLabel3;

	public GameObject TemperSelect3;

	public UISprite Stage1Sprite;

	public UIButton Stage1Button;

	public UISprite Stage2Sprite;

	public UIButton Stage2Button;

	public UISprite Stage3Sprite;

	public UIButton Stage3Button;

	public GameObject StageSelect1;

	public GameObject StageSelect2;

	public GameObject StageSelect3;

	public GameObject Stage2Locked;

	public GameObject Stage3Locked;

	public Transform SparkPetAvatarAnchor;

	public UILabel StageLabel;

	public UILabel Stage3Lvlabel;

	public UILabel Stage2Lvlabel;

	public UIButton TemperInfoBtn;

	public UIToggleButtonGroup ToggleGroup;

	public UIToggleButton StageToggle;

	public UIToggleButton DyeToggle;

	public GameObject StageRoot;

	public GameObject DyeRoot;

	public GameObject ColorBtns;

	public UISprite DyeIcon;

	public UILabel DyeDescLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
