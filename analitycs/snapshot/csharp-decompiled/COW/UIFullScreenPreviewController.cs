using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIFullScreenPreviewController : UIPreviewPopUpWindowController
{
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public int type;

		internal bool _003CGetAdvertDescByType_003Eb__0(AdvertDesc ad)
		{
			return false;
		}
	}

	private UIFullScreenPreviewView m_View;

	private uint m_ItemID;

	private BaseItemInfo m_ItemInfo;

	private UIModelCDNAd m_ModelCDNAd;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private List<AdvertDesc> adList;

	private const int DEFAULT = 1;

	private const int PET = 2;

	private const int WEAPON = 3;

	private GameObject m_BGEffectForEvoGunVer1;

	private GameObject m_BGEffectForEvoGunVer2;

	private GameObject m_BGEffectForItemConfig;

	private UIPopupWindowTopBtnController m_PopClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RefreshBgDuringWeaponAnim(bool show)
	{
	}

	private void RefreshBG()
	{
	}

	private void DestroyBgEffect()
	{
	}

	public virtual void SetPreviewInfo(uint itemID, BaseItemInfo itemInfo, bool needAddLobbyCloth = false)
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void TryPreDownloadNB2Bg()
	{
	}

	public void SetPreviewVideoInfo(uint itemID)
	{
	}

	public void SetNewBieStoreGotoBtnState(bool isActive)
	{
	}

	public void SetBundleSelect(int index)
	{
	}

	protected override void OnUIClose()
	{
	}

	private string GetCDNBgURLByType(uint itemID, out uint endTime)
	{
		endTime = default(uint);
		return null;
	}

	private AdvertDesc GetAdvertDescByType(int type)
	{
		return null;
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnPopupWindowListChanged(bool isShow)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChanged(bool P0)
	{
	}
}
