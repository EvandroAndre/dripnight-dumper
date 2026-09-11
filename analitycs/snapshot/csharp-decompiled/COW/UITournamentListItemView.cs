using GCommon;
using UnityEngine;

namespace COW;

public class UITournamentListItemView : UIBaseView
{
	public UIButton UIButtonUITournamentListItem;

	public UIWidget UIWidgetUITournamentListItem;

	public TweenPosition TweenPositionUITournamentListItem;

	public TweenAlpha TweenAlphaUITournamentListItem;

	public UISprite WeatherSprite;

	public UILabel MapName;

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

	public UIButton JoinOB;

	public UILabel GroupModelLabel;

	public GameObject JoinOrOB;

	public GameObject AFKOpen;

	public GameObject OBJionable;

	public GameObject OBUnjoinable;

	public GameObject OBMAXLabel;

	public GameObject VipNameGroup;

	public UILabel VipName;

	public GameObject PrivilegeIcon;

	public GameObject BG;

	public UILabel LabelMaxMask;

	public UIButton SettingPreviewBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
