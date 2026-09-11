using GCommon;

namespace COW;

public class UIClanMainTagItemController : UIBaseController
{
	private UIClanMainTagItemView m_View;

	private ClanTagData m_TagData;

	private EClanItemType m_ItemType;

	private bool m_IsSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(ClanTagData data)
	{
	}

	public void SetButtonState(EClanItemType type)
	{
	}

	private void InitView()
	{
	}

	private void InitEvent()
	{
	}

	private void RefreshView()
	{
	}

	private void OnTagButtonClicked()
	{
	}

	public void SetTagButtonState(bool isSelect)
	{
	}

	public void SetTagSelectState(bool isSelect)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
