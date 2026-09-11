using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNameView : UIBaseView
{
	public GameObject Container;

	public UIWidget ContainerWidget;

	public UILabel Name;

	public GameObject GoName;

	public GameObject Effect_Glow;

	public GameObject ArrowUp;

	public UISprite ArrowUpSprite;

	public GameObject ArrowUpLight;

	public GameObject ArrowLeft;

	public UISprite ArrowLeftSprite;

	public GameObject ArrowLeftLight;

	public GameObject ArrowRight;

	public UISprite ArrowRightSprite;

	public GameObject ArrowRightLight;

	public GameObject ArrowDown;

	public UISprite ArrowDownSprite;

	public GameObject ArrowDownLight;

	public GameObject AdditiveInfo;

	public UISprite AdditiveIcon;

	public UILabel AdditiveLabel;

	public UILabel TeammateDistance;

	public UISprite DistanceBG;

	public Transform EventTriggerMarkPos;

	public UIWidget WidgetEventTriggerMark;

	public GameObject PlayerIndex;

	public UIWidget PlayerIndexWidgt;

	public UISprite PlayerIndexIcon;

	public UILabel PlayerIndexLabel;

	public UIGrid leftArrowGrid;

	public UIWidget leftArrowWidget;

	public GameObject HealGunIcon;

	public UIWidget Pivot;

	public GameObject identityContainer;

	public UILabel NameLbl;

	public GameObject ReplayName;

	public UILabel TeamId;

	public UISprite Hpbarfg;

	public UISprite Hpbarbg;

	public GameObject NormalName;

	public GameObject SelfSprite;

	public UITable PlayerIndexTable;

	public Transform WeaponPowerIconPos;

	public UILabel BG;

	public UIWidget EventTriggerMarkPosForHideName;

	public UITexture SymbolTexture;

	public VFXCreateHelper MVPContainer;

	public GameObject HealRobotMarkInside;

	public GameObject HealRobotMark;

	public GameObject PrivilegeContainer;

	public GameObject PrivilegeIcon;

	public UISprite TeamRallyIcon;

	public Animation TeamRallyAnim;

	public GameObject PlayerIndexSubContainer;

	public UISprite RallyIconBG;

	public Transform ChatBoxFollowNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
