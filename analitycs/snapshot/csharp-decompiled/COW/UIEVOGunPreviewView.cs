using GCommon;
using UnityEngine;

namespace COW;

public class UIEVOGunPreviewView : UIBaseView
{
	public UIEventListener EventTrigger;

	public UIWidget PreviewBorder;

	public GameObject WidgetPreview;

	public Transform WeaponModelDownloader;

	public Transform ObjAnnouncementArea;

	public UIButton BtnPlayEmote;

	public GameObject SoundCon;

	public UILabel SoundLabel;

	public Transform KillUIFXArea;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
