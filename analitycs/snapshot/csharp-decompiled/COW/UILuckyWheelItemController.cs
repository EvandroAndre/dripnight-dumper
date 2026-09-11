using GCommon;
using proto;

namespace COW;

public class UILuckyWheelItemController : UIBaseController
{
	public enum ViewStage
	{
		NORMAL,
		SELECTED,
		GET_REWARD,
		FINISHED
	}

	private UILuckyWheelItemView m_View;

	private CSLuckyWheelDiscountDesc m_Desc;

	public int Index;

	private UIStandardItemMiniController m_UIStandardItemMiniController;

	private UIModelLuckyWheel m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitView()
	{
	}

	public uint GetUniqueID()
	{
		return 0u;
	}

	public void SetViewData(CSLuckyWheelDiscountDesc desc, int index)
	{
	}

	public void ShowView(ViewStage stage)
	{
	}

	private void SetNormalStyle()
	{
	}

	private void SetGrayStyle()
	{
	}

	public bool IsUsed()
	{
		return false;
	}

	public void SetResetState()
	{
	}

	private void OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
