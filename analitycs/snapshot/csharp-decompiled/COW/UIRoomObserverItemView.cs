using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomObserverItemView : UIBaseView
{
	public UIButton ObserverItem;

	public UIWidget UIRoomObserverItem;

	public UILabel Id;

	public GameObject Tag;

	public GameObject ReadyMark;

	public GameObject SelfBg;

	public UIWidget NameWidget;

	public UILabel Name;

	public UISprite MapResState;

	public GameObject DownloadingEffect;

	public UIGrid InfoGrid;

	public UIButton VoiceInfo;

	public GameObject Voice;

	public GameObject VoiceNone;

	public UILabel NameWithIcon;

	public Transform PrivilegeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
