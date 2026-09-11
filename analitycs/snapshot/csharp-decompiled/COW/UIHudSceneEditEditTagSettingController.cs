using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudSceneEditEditTagSettingController : UIPopupWindowController
{
	private UIHudSceneEditTagSettingView m_View;

	private Dictionary<string, UIHudSceneEditTagItemController> m_LibraryDic;

	private Dictionary<string, UIHudSceneEditTagItemController> m_SelectedTagDic;

	private List<string> oldSelectedTags;

	public OnUpdateTagsDelegate OnUpdateTags;

	public const int MAX_SELECTED_TAGS_COUNT = 8;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetCurrentSelectedTags(List<string> selectedTags)
	{
	}

	public void OnAddTag(SceneEditTagData tag)
	{
	}

	public void OnRemoveTag(SceneEditTagData tag)
	{
	}

	private void RefreshEmptyUI()
	{
	}

	private void OnConfirmClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
