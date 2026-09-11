using GCommon;

namespace COW;

public class UIHudSFRoleplaySelectItemController : UIBaseController
{
	private enum EActionState
	{
		Normal,
		Selected,
		Full
	}

	private UIHudSFRoleplaySelectItemView m_View;

	private EActionState m_EActionState;

	private uint m_RoleID;

	private const uint m_SelectBtnLabelColorNormal = 85469695u;

	private const uint m_SelectBtnLabelColorSelected = 2565733887u;

	private const uint m_SelectBtnLabelColorFull = 85469695u;

	private const uint m_NumIconColorFull = 4080560895u;

	private const uint m_NumIconColorSelected = 16753407u;

	private const uint m_NumIconColorNormal = uint.MaxValue;

	private const uint m_NumLabelColorFull = 4080560895u;

	private const uint m_NumLabelColorSelected = 16753407u;

	private const uint m_NumLabelColorNormal = uint.MaxValue;

	public uint RoleID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public void SetViewData(uint id)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
