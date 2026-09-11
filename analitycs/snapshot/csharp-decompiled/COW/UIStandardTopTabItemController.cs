using GCommon;

namespace COW;

public class UIStandardTopTabItemController : UIEasyListItemController
{
	protected UIStandardTopTabItemView m_View;

	private StandardTopTabItemViewData m_Data;

	private const int LABEL_WIDTH = 154;

	private bool IsCurSelectSuccess
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetRedPointState(bool value)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public UIWidget GetWidget()
	{
		return null;
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void _003CSetViewData_003Eb__8_0()
	{
	}

	private void _003CSetViewData_003Eb__8_1()
	{
	}

	private void _003CSetViewData_003Eb__8_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
