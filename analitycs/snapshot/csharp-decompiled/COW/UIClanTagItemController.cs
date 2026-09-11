using GCommon;

namespace COW;

public class UIClanTagItemController : UIBaseController
{
	private UIClanTagItemView m_View;

	private ClanTagData m_TagData;

	private EClanItemType m_ItemType;

	private bool m_IsSelected;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(ClanTagData data, bool isBriefBox = false)
	{
	}

	public void SetDepth(int depth)
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
}
