using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetVaultGroupItemController : UIBaseController, UITable2.IUITable2Item
{
	private UISparkPetVaultGroupItemView m_View;

	private UIStandardItemMidController m_StandardItemCtrl;

	private SparkDressUp m_CosmeticInfo;

	private UIModelSparkPet m_ModelSparkPet;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	private void OnItemClicked()
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
