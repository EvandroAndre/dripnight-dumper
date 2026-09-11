using GCommon;

namespace COW;

public class UIClothesSetChangeItemController : UIBaseController
{
	private UIClothesSetChangeItemView m_View;

	private uint m_SetID;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint setID, int index, bool isSelected = false)
	{
	}

	private void OnBtnClothesChangeClick()
	{
	}

	private void OnClothesSetChange(uint setID)
	{
	}

	private void RefreshView()
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
