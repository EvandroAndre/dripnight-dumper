using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHUDUGC_ObjectEntityAttributeEditController : UIPopupWindowController, IEasyList
{
	private enum Tab
	{
		Attribute,
		Info,
		Count
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIHUDUGC_ObjectEntityAttributeEditController _003C_003E4__this;

		public int i;
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public string name;

		public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals1;

		internal bool _003CCheckVaild_003Eb__0(IBILCDHHNHM data)
		{
			return false;
		}
	}

	private string m_Id;

	private UIHUDUGC_ObjectEntityAttributeEditView m_View;

	private AOKBGKNKKLJ m_Data;

	private Tab m_CurrentTab;

	private GameObject[] m_TabGameObjects;

	private SceneEditPrefabConfigData m_ConfigData;

	private bool m_Redefined;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void DeleteAttribute(object[] param)
	{
	}

	private void OnClickAttributeTab()
	{
	}

	private void OnClickInfoTab()
	{
	}

	private void SwitchTab(Tab tab)
	{
	}

	private void OnClickConfirm()
	{
	}

	private bool CheckVaild(out string reason)
	{
		reason = null;
		return false;
	}

	private void OnClickAddBtn()
	{
	}

	private void RefreshItems()
	{
	}

	private void AddAttributeView()
	{
	}

	public void SetViewData(SceneEditPrefabConfigData prefabConfig, string type)
	{
	}

	private void RefreshInfoView()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnRedefineItem(int index)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
