using GCommon;

namespace COW;

public class UIRecLoadoutPlanListItemController : UIEasyListItemController
{
	private UIRecLoadoutPlanListItemView m_View;

	private PlayerEditRecPlanItem m_PlanData;

	private int _003CPlanIndex_003Ek__BackingField;

	public int PlanIndex
	{
		get
		{
			return _003CPlanIndex_003Ek__BackingField;
		}
		private set
		{
			_003CPlanIndex_003Ek__BackingField = value;
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

	private void UpdateLikeDisplay()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void SetLike(bool isLiked)
	{
	}

	private void UpdateSelectionDisplay()
	{
	}

	private void OnItemClicked()
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
