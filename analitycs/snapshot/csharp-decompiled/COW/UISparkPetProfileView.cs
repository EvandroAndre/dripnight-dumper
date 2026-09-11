using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetProfileView : UIBaseView
{
	public UIToggleButton ShowBuddySparkPetToggle;

	public UIToggleButton ShowInLobbyToggle;

	public UILabel Desc;

	public UIButton DetailButton;

	public UISprite CurrExpBar;

	public UILabel ExpLabel;

	public UILabel Level;

	public UILabel Title;

	public GameObject ActiveStateCard;

	public GameObject DormantStateCard;

	public GameObject DeadStateCard;

	public UILabel ActiveConsecutiveDayNum;

	public UISprite TemperSprite;

	public UIButton TemperButton;

	public UIButton BuddyLinkButton;

	public UIButton CosmeticVaultButton;

	public UITable Table;

	public UIProgressBar ProgressBars;

	public UIButton Mask;

	public GameObject LevelUpVFX;

	public GameObject PBLevelUpVFX;

	public GameObject ShowInLobbyToggleEnabled;

	public GameObject ShowInLobbyToggleDisabled;

	public GameObject ShowBuddySparkPetToggleEnabled;

	public GameObject ShowBuddySparkPetToggleDisabled;

	public GameObject BgActive;

	public GameObject BgDormant;

	public GameObject BgDead;

	public UILabel DormantConsecutiveDayNum;

	public UILabel DeadConsecutiveDayNum;

	public TweenAlpha BuddyLinkMainIn;

	public TweenAlpha CosmeticVaultMainIn;

	public GameObject EnabledVaultButton;

	public GameObject DisabledVaultButton;

	public GameObject EnabledBuddyLinkButton;

	public GameObject DisabledBuddyLinkButton;

	public UIButton ShareButton;

	public UIButton ChangeAppearanceButton2;

	public Transform Container;

	public UILabel DeadDetailDesc;

	public UILabel DormantDetailDesc;

	public GameObject PBRecoverUIFX;

	public Animation ProfileAnimation;

	public UIButton LuckyDrawButton;

	public TweenAlpha LuckyDrawMainIn;

	public GameObject EnabledLuckyDrawButton;

	public GameObject DisabledLuckyDrawButton;

	public GameObject CenterHelper;

	public GameObject LuckyDrawRetDotRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
