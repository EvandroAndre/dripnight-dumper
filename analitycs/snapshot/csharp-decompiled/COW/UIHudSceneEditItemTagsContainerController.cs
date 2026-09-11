using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditItemTagsContainerController : UIBaseController, IUIHudSceneEditInspectorItemAttribute
{
	protected UIHudSceneEditItemTagsContainerView m_View;

	private SceneEditObjectBase m_ModifyObject;

	private Action m_OnRefreshListRequested;

	private List<string> m_TagsData;

	private List<UIHudSceneEditTagItemDisplayController> m_TagsControllers;

	public event Action OnRefreshListRequested
	{
		add
		{
		}
		remove
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

	public void SetViewData(string entityType, SceneEditObjectBase objectBase)
	{
	}

	private void OnClickEditTagsButton()
	{
	}

	private void OnUpdateTags(List<string> tags)
	{
	}

	private void RefreshTagsView(List<string> tagsData = null)
	{
	}

	public void RefreshTagsSelected()
	{
	}

	private void SetTagsToDataStore(List<string> tags)
	{
	}

	private bool IsSameTags(List<string> oldTags, List<string> newTags)
	{
		return false;
	}

	public void TriggerRefresh()
	{
	}

	private void _003COnUIInit_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
