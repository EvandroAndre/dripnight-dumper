using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIWeaponKillNotificationItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIWeaponKillNotificationItemController _003C_003E4__this;

		public ResourceID resId;

		internal void _003CShowSkinEffectGo_003Eb__0(uint ticket, bool success, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003CAllignCenterOrLeft_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeaponKillNotificationItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAllignCenterOrLeft_003Ed__21(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string BP_ICON_SPRITE = "Minimap_BooyahPass_Kill";

	private UIWeaponKillNotificationItemView m_View;

	private bool m_Pending;

	private uint m_DelayCallID;

	private Timer m_ShowupTimer;

	private Dictionary<ResourceID, GameObject> m_GoEffects;

	private HashSet<uint> m_EffectTickets;

	private string m_KillVerbColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetBPIconAndVfx()
	{
	}

	private void SetFFWSIcon(PendingNotification notification)
	{
	}

	private void SetBadgeIconAndVfx(PendingNotification notification)
	{
	}

	public bool IsActive(float gameTime)
	{
		return false;
	}

	public void SetKillInfo(float gameTime, PendingNotification notification)
	{
	}

	private void RefreshLayoutForAligned()
	{
	}

	private IEnumerator AllignCenterOrLeft()
	{
		return null;
	}

	public void ShowPreviewNotification(uint itemId, bool ignorePending = false)
	{
	}

	public void ResetNotification()
	{
	}

	private void SetQualityBGBySkinId(uint weaponSkinID)
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

	private void _003CShowPreviewNotification_003Eb__22_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
