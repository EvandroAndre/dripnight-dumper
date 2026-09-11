using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopTabItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIDrawShopTabItemController _003C_003E4__this;

		public string cdnUrl;

		internal void _003CInitSelectedTex_003Eb__0()
		{
		}
	}

	private UIDrawShopTabItemView m_View;

	private UIModelDrawShop m_ModelDrawShop;

	private UIModelDrawShop.DrawShopContentDataBase m_ContentData;

	private int m_TabIndex;

	private bool m_IsSelected;

	private bool m_HasSelectedCDN;

	private string m_SelectedCDNUrl;

	private GameObject m_HighlightVFX;

	private GameObject m_SpecialVFX;

	public ulong startTime;

	public int pageDetentionTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(int tabIndex, UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	public void SetSelectedState(bool isSelected, bool forceRefresh = false)
	{
	}

	public void RefreshUI()
	{
	}

	public void OnDrawShopShow()
	{
	}

	public void OnDrawShopHide()
	{
	}

	public void EnableHighlightVFX()
	{
	}

	public uint GetChestId()
	{
		return 0u;
	}

	public int GetTabIndex()
	{
		return 0;
	}

	private void InitCDNTex()
	{
	}

	private void InitSelectedTex()
	{
	}

	private void RefreshPrimeState()
	{
	}

	private void UpdateSelectedVisuals()
	{
	}

	private void UpdateSelectedTexVisuals()
	{
	}

	private void PlaySelectionAnimation(bool isSelected)
	{
	}

	private void RefreshNewIndicator()
	{
	}

	private void RefreshDiscountTag()
	{
	}

	private void OnTabButtonClick()
	{
	}

	private void DestroyVFX()
	{
	}

	private void _003CInitCDNTex_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
