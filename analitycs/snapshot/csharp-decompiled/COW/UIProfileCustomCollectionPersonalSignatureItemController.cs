using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionPersonalSignatureItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private UIProfileCustomCollectionPersonalSignatureItemView m_View;

	private UIModelProfile m_ModelProfile;

	private UIModelUser m_ModelUser;

	private string m_PersonalSignature;

	private UIInput m_InputField;

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

	public override void SetViewData(ProfileCustomModuleData data)
	{
	}

	protected override void CaclulateItemOffset()
	{
	}

	private void OnInputFieldGetFocus()
	{
	}

	private void OnInputFieldLostFocus()
	{
	}

	protected override ProfileCustomDragDropItem GetDragDropItem()
	{
		return null;
	}

	public override GameObject GetIcon()
	{
		return null;
	}

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void ShowBgByBriefBox()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_CaclulateItemOffset()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowBgByBriefBox()
	{
	}
}
