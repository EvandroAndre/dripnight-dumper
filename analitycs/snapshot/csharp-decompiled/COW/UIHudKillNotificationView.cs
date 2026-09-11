using GCommon;
using UnityEngine;

namespace COW;

public class UIHudKillNotificationView : UIBaseView
{
	public UIHudKillNotificationItem Item1;

	public UIHudKillNotificationMiniItem MiniItem1;

	public UIWidget UIHudKillNotification;

	public UIHudWeaponKillNotificationItem WeaponItem;

	public UIGrid NormalItemGrid;

	public UIGrid MiniItemGrid;

	public UISprite WeaponItemKillIcon;

	public UISprite NormalItemGridKillIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
