using GCommon;

namespace COW;

public class UIIPCollabPosterBgChangeItemController : UIBaseController
{
	private UIIPCollabPosterBgChangeItemView m_View;

	private int m_Index;

	private bool m_IsSelected;

	public int Index => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(int index, bool isSelected)
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	public void SetTipsVisible(bool visible)
	{
	}

	private void OnBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
