using System;

namespace COW;

public class DrawShopBuyButtonComponent
{
	private UIDrawShopContentBaseController m_Owner;

	private Action m_OnSingleBuyCallback;

	private Action m_OnMultiBuyCallback;

	public void Init(UIDrawShopContentBaseController owner, Action onSingleBuy, Action onMultiBuy)
	{
	}

	public void RefreshState(uint id)
	{
	}

	public void OnSingleBuyClick()
	{
	}

	public void OnMultiBuyClick()
	{
	}

	public void Dispose()
	{
	}
}
