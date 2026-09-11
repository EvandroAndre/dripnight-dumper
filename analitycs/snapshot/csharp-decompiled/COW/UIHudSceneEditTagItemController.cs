using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditTagItemController : UIBaseController
{
	private UIHudSceneEditTagItemView m_View;

	public SceneEditTagData data;

	public bool isFromLibrary;

	public OnAddTagDelegate OnAddTag;

	public OnRemoveTagDelegate OnRemoveTag;

	private float lastPressTime;

	private bool isPressed;

	private bool isSelected;

	private UIDetailTipsInGameController detailTips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemData(SceneEditTagData tagData, bool isLibrary, bool isCurSelected)
	{
	}

	public void OnItemPress(GameObject obj, bool press)
	{
	}

	public void Update()
	{
	}

	public void OnLongPressItem()
	{
	}

	public void OnClickItem()
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
