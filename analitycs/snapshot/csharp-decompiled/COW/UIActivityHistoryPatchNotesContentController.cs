using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityHistoryPatchNotesContentController : UIActivityContentController, IEasyList
{
	private UIActivityHistoryPatchNotesContentView m_View;

	private List<UIActivityHistoryPatchNoteItemController> m_ItemControllers;

	private List<ClientActivityDesc> m_ActivityList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(object data)
	{
	}

	private int PatchNotesSort(ClientActivityDesc x, ClientActivityDesc y)
	{
		return 0;
	}

	public override void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}

	public override void Reload()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
