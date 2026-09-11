using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWeaponKillNotificationItem : UIHudKillNotificationItem
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public UIHudWeaponKillNotificationItem _003C_003E4__this;

		public ResourceID resId;

		internal void _003CShowSkinEffectGo_003Eb__0(uint ticket, bool success, Object obj)
		{
		}
	}

	private Dictionary<ResourceID, GameObject> m_GoEffects;

	private HashSet<uint> m_EffectTickets;

	public override void SetKillInfo(float gameTime, PendingNotification notification)
	{
	}

	private void OnDestroy()
	{
	}

	private void ShowSkinEffect(uint itemId, BHGGAEEHJCO killerId, bool ignoreKillId = false)
	{
	}

	private void ShowSkinEffectGo(ResourceID resId)
	{
	}

	private void CancelAsyncLoadSkinEffectGo()
	{
	}

	public bool ShowHandWeaponAnnounceEffect(BHGGAEEHJCO killerId)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetKillInfo(float P0, PendingNotification P1)
	{
	}
}
