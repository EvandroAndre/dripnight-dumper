using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class CommonRewardWndStyleLevelUpController : CommonRewardWindowStyleBaseController
{
	private sealed class _003CRewardContainerTween_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CommonRewardWndStyleLevelUpController _003C_003E4__this;

		private UICommonRewardWndController _003Cparent_003E5__2;

		private double _003CanimLength_003E5__3;

		private float _003CbreakTimer_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRewardContainerTween_003Ed__11(int _003C_003E1__state)
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

	private new CommonRewardWnd_BGStyle_LevelUpView m_View;

	private uint m_NewLevel;

	private List<UISprite> m_UnlockSys;

	private CommonRewardItemInfo m_ItemInfo;

	private int m_GuestLevelLimit;

	private int m_NormalLevelLimit;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationBack()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void OriginUICloseDo()
	{
	}

	private void TryRefreshNewbieRecommendWeapon()
	{
	}

	public override void GetRewardGridPosAndPivot(out Vector3 pos, out UIWidget.Pivot? pivot)
	{
		pos = default(Vector3);
		pivot = null;
	}

	public override void SetUserData(object userData)
	{
	}

	private IEnumerator RewardContainerTween()
	{
		return null;
	}

	private void ShowLevelView()
	{
	}

	private void ShowLabelView()
	{
	}

	private void TryUpdateWeaponData()
	{
	}

	private void TryShowNextPopup()
	{
	}

	private bool IsAvatarGachaFeatureShow()
	{
		return false;
	}

	private void AvatarGachaFeatureDo()
	{
	}

	private bool IsNextLevelAnnounceShow()
	{
		return false;
	}

	private void NextLevelAnnounceDo()
	{
	}

	private bool IsGrowthFundAnnounceShow()
	{
		return false;
	}

	private void GrowthFundAnnounceDo()
	{
	}

	private bool IsBindAccountShow()
	{
		return false;
	}

	private void BindAccountDo()
	{
	}

	private bool IsGuest()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_GetRewardGridPosAndPivot(out Vector3 P0, out UIWidget.Pivot? P1)
	{
		P0 = default(Vector3);
		P1 = null;
	}

	public void _003C_003EiFixBaseProxy_SetUserData(object P0)
	{
	}
}
