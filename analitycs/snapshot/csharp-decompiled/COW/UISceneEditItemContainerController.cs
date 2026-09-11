using System;
using GCommon;

namespace COW;

public class UISceneEditItemContainerController : UIEasyListItemController
{
	public class ViewData
	{
		public uint PrefabID;

		public ResourceID ResID;

		public ResourceID IconID;

		public string ItemsDesc;

		public string IconUrl;

		public static ViewData Create(WorkShopCollaborationResources res)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public ViewData viewData;

		public UISceneEditItemContainerController _003C_003E4__this;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UISceneEditItemContainerView m_View;

	private Action m_ClickItemAction;

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

	private void OnClickItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
