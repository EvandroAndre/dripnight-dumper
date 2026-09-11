using GCommon;
using UnityEngine;

namespace COW;

public class UIPrivilegePreviewView : UIBaseView
{
	public UIEventListener EventTrigger;

	public UIWidget PreviewBorder;

	public GameObject WidgetPreview;

	public Transform WeaponModelDownloader;

	public Transform ObjAnnouncementArea;

	public Transform killNotifyContainer;

	public Transform FinalShotUIContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
