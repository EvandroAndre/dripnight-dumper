using GCommon;

namespace COW;

public class UIRecSelectTagItemController : UIEasyListItemController
{
	private UIRecSelectTagItemView m_View;

	private uint _003Cm_TagID_003Ek__BackingField;

	private bool m_IsSelected;

	public uint m_TagID
	{
		get
		{
			return _003Cm_TagID_003Ek__BackingField;
		}
		private set
		{
			_003Cm_TagID_003Ek__BackingField = value;
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

	protected override void OnUIDestory()
	{
	}

	public void OnTagClick()
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	public void SetDisabled()
	{
	}

	public void SetEnabled()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
