using GCommon;
using UnityEngine;

namespace COW;

public class UIHudStackedKillNotificationView : UIBaseView
{
	public Animation StackKillAnimator;

	public GameObject StackKill;

	public UISprite ChangableBG;

	public GameObject FirstBlood;

	public GameObject DoubleKill;

	public GameObject TripleKill;

	public GameObject QuadraKill;

	public UILabel KillCountLabel_1;

	public UILabel KillCountLabel_2;

	public UISprite KillHead;

	public UILabel content;

	public UISprite KillerNameBG;

	public UISprite KillTypeIcon;

	public UISprite KillerNameBGWithIcon;

	public GameObject styleBlue;

	public UISprite StyleBlueBg;

	public GameObject styleRed;

	public UISprite StyleRedBg;

	public GameObject AceEffect;

	public Transform TrStyleMulKill;

	public GameObject ScannerMarkKillInfo;

	public UILabel Label;

	public UITable Table;

	public TweenAlpha AnimatorNode;

	public GameObject King;

	public UIPanel KillNotifyPanel;

	public Transform SpecialVFX;

	public GameObject NormalStyleRoot;

	public UISprite PriviliegeKillTypeIcon;

	public UILabel PriviliegeKillCountLabel_1;

	public UILabel PriviliegeKillCountLabel_2;

	public GameObject WeaponSkinPriviliegeStyleRoot;

	public Animation PrivilegeSkinAnimationComp;

	public GameObject VFX_StreakKill;

	public UISprite Kingicon;

	public GameObject LoadoutReinforceTokenContainer;

	public UILabel ReinforceTokenLabel;

	public GameObject OriginLabelStyle;

	public Transform ConfigLabelStyleRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
