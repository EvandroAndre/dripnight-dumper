using GCommon;

namespace COW;

public class UICommonSettingDragableItemBaseController : UIBaseController, ICommonSettingDragItem
{
	private CommonSettingDragableItemBaseData m_Data;

	protected UICommonSettingDragableItemBaseView m_BaseView;

	private ICommonSettingDragParent m_Parent;

	protected uint m_ItemId;

	protected uint m_ItemType;

	protected float DarkAlpha;

	private bool m_NeedAdjust;

	public virtual void SetBaseView(ICommonSettingDragParent settingParent)
	{
	}

	protected virtual void SetViewData(CommonSettingDragableItemBaseData data, ICommonSettingDragParent settingParent)
	{
	}

	public virtual void RefreshContent()
	{
	}

	private void OnTipBtnClick()
	{
	}

	public virtual void SetItemNoninteractable()
	{
	}

	public virtual void SetDraggingUI()
	{
	}

	public virtual void SetDraggedUI(bool showDragged)
	{
	}

	public virtual void UpdateHighLightState(uint itemId, bool up = false)
	{
	}

	public virtual void ResetHighLightState()
	{
	}

	public virtual int GetWidgetWidth()
	{
		return 0;
	}

	public virtual uint GetItemId()
	{
		return 0u;
	}

	public virtual uint GetItemType()
	{
		return 0u;
	}
}
