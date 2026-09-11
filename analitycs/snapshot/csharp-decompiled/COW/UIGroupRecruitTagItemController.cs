using GCommon;

namespace COW;

public class UIGroupRecruitTagItemController : UIBaseController
{
	private UIGroupRecruitTagItemView m_View;

	private string m_TagIconName;

	private string m_TagName;

	private bool m_CanClick;

	private bool m_IsSelected;

	private bool m_IsFullSelected;

	private bool m_IsOccupationLimit;

	private uint m_TagId;

	private RecruitTagStyle m_TagStyle;

	private UIModelRecruit m_ModelRecruit;

	public uint TagId
	{
		get
		{
			return 0u;
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

	public void SetTagView(uint tagId, RecruitTagStyle tagStyle)
	{
	}

	public void SetBtnClickState(bool canClick)
	{
	}

	public void SetFullSelectState(bool fullSelected)
	{
	}

	public void SetOccupationState(bool occupationSelected)
	{
	}

	public void SetSelectState(bool isSelect)
	{
	}

	public void OnTagBtnClick()
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
