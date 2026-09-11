using UnityEngine;

namespace GCommon;

public abstract class UIEasyListItemController : UIBaseController
{
	public delegate void ItemClickCallBack(int data_index);

	protected int m_Index;

	private bool m_IsSelected;

	public ItemClickCallBack m_SelectCallBack;

	public ItemClickCallBack m_ClickCallBack;

	public int Index => 0;

	public abstract void SetViewData(object data, int data_index);

	public static GameObject CreateFakeItem(Transform parent, int width, int height)
	{
		return null;
	}

	public void SetItemSelectCallBack(ItemClickCallBack item_SelectCallBack)
	{
	}

	public void SetItemClickCallBack(ItemClickCallBack item_ClickCallBack)
	{
	}

	public void EasyListSelectItem()
	{
	}

	public void EasyListClickItem()
	{
	}

	public bool GetSelectState()
	{
		return false;
	}

	public virtual void OnItemBtnClick()
	{
	}

	public virtual void OnItemBtnClick2()
	{
	}

	public virtual void OnItemBtnSelect()
	{
	}

	public virtual void OnItemBtnUnSelect()
	{
	}

	public virtual void OnItemBtnCancelSelect()
	{
	}

	protected virtual void AfterSelectItem()
	{
	}

	public virtual void SetEasyListData(int wrapIndex, int realIndex)
	{
	}
}
