using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UISplashBannerItemPreviewBaseController : UIPreviewPopUpWindowController
{
	private sealed class _003CStartCheckCdnTextureLoad_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISplashBannerItemPreviewBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartCheckCdnTextureLoad_003Ed__16(int _003C_003E1__state)
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

	protected GameObject EventTrigger;

	protected UISplashBannerItemCDNHelperUtil CDNHelperUtil;

	protected UIButton NetworkTextureContentButton;

	protected UIButton CDNSpecialButton;

	protected UINetworkTexture NetworkTextureContent;

	protected bool m_IsTodayNotShowBtnSelected;

	protected bool m_IsSuccess;

	protected SplashBannerInfo m_SplashBannerInfo;

	protected bool m_LoadCdnTextureSuccess;

	private string m_NeedLoadUrlStr;

	private const float m_RotateRate = 0.5f;

	private UIWishListBtnController m_WishListBtnCtrl;

	private UIModelWishList ModelWishList;

	protected Transform WishBtnContainer;

	protected override void OnUIInit()
	{
	}

	protected virtual SplashType GetSplashType()
	{
		return SplashType.CDN;
	}

	private IEnumerator StartCheckCdnTextureLoad()
	{
		return null;
	}

	public virtual void SetSplashData(SplashBannerInfo info)
	{
	}

	private void SetWishListNodeActive(bool v)
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	protected void InitCDNImageShow()
	{
	}

	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	public override void OnNavigationBack()
	{
	}

	protected virtual void SuccessCallBack()
	{
	}

	protected void OnRefreshEventTrigger(object[] data)
	{
	}

	public virtual string DontShowSplashBannnerCDNKey()
	{
		return null;
	}

	protected virtual UILabel GetDontShowLabel()
	{
		return null;
	}

	protected override void OnUIClose()
	{
	}

	public void CreateWeaponInfoBySplashBannerInfo(bool refresh = false)
	{
	}

	private void ModifyWeaponModel()
	{
	}

	protected bool IsShowDynamicImage()
	{
		return false;
	}

	protected virtual void OnGotoNavigation()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	private string GetModifyUrl(string url, bool useOrigin = false)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
