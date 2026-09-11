using System;
using GCommon;

namespace COW;

public class UIHUDUGC_ChooseCardItemController : UIBaseController
{
	public class ItemData
	{
		public string BGSprite;

		public int BGColor;

		public string IconSprite;

		public string Name;

		public string Desc;
	}

	public Action<UIHUDUGC_ChooseCardItemController> onClickItemHandler;

	private UIHUDUGC_ChooseCardItemView m_View;

	private ItemData m_Data;

	private int m_Index;

	public int Index => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ItemData data, int index)
	{
	}

	private void OnClickItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
