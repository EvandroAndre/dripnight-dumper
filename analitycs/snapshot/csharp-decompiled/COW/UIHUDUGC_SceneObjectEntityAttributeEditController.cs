using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHUDUGC_SceneObjectEntityAttributeEditController : UIPopupWindowController, IEasyList
{
	private UIHUDUGC_SceneObjectEntityAttributeEditView m_View;

	private List<IPIFNFDIIKK> m_EntityAttributeData;

	private string m_Type;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickConfirm()
	{
	}

	private void RefreshListView()
	{
	}

	private string GetCoordinateString(GameObject obj)
	{
		return null;
	}

	public void SetData(string entityId, string type)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
