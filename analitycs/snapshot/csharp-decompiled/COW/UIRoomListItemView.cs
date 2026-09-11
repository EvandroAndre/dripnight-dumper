using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomListItemView : UIBaseView
{
	public UIButton UIButtonUIRoomListItem;

	public UIWidget UIWidgetUIRoomListItem;

	public TweenPosition TweenPositionUIRoomListItem;

	public TweenAlpha TweenAlphaUIRoomListItem;

	public UISprite WeatherSprite;

	public UILabel MapName;

	public UISprite Icon;

	public UISprite Map;

	public UINetworkTexture CDNMap;

	public UITable Flags;

	public UILabel ID;

	public GameObject Lock;

	public GameObject Emulator;

	public UILabel Status;

	public UILabel Name;

	public UILabel Players;

	public UILabel ModeName;

	public UISprite LanguageSprite;

	public UILabel DropList;

	public Animation InAnim;

	public UILabel LevelLabel;

	public GameObject LevelLabelGameObject;

	public UIButton JoinGame;

	public UIButton JoinOB;

	public UILabel GroupModelLabel;

	public GameObject JoinOrOB;

	public GameObject AFKOpen;

	public GameObject GameJionable;

	public GameObject GameUnjoinable;

	public GameObject OBJionable;

	public GameObject OBUnjoinable;

	public GameObject OBMAXLabel;

	public GameObject VipNameGroup;

	public UILabel VipName;

	public GameObject PrivilegeIcon;

	public GameObject BG;

	public GameObject AdvRoomBG;

	public GameObject AdvRoomCard;

	public UILabel LabelMaxMask;

	public UIButton SettingPreviewBtn;

	public GameObject Line;

	public UILabel LevelLabelMid;

	public GameObject LevelLabelMidGameObject;

	public GameObject GameJionableMid;

	public GameObject GameUnjoinableMid;

	public UILabel ModeNameMid;

	public Transform PreviewTransform;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
