using GCommon;

namespace COW;

internal class UICommonSettingItemBaseController : UIBaseController
{
	private int m_Type;

	public virtual void SetViewData(CommonSettingItemDataBase data, int type)
	{
	}

	public virtual void RefreshContent()
	{
	}

	public virtual void RefreshTips()
	{
	}

	public new int GetType()
	{
		return 0;
	}
}
