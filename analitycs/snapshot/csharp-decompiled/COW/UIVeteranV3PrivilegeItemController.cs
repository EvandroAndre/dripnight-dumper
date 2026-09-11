using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIVeteranV3PrivilegeItemController : UIBaseController
{
	private UIVeteranV3PrivilegeItemView m_View;

	private VeteranRightsDesc m_RightsData;

	private UIVeteranV3PrivilegeController.PrivilegeType m_Type;

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

	public void SetViewData(UIVeteranV3PrivilegeController.PrivilegeType type, VeteranRightsDesc rightsData)
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void OnGameBuffBtnClick()
	{
	}

	private void CheckAndDoLoc(List<string> arrayList, UILabel label, string key)
	{
	}

	public void PlayCloseAnim()
	{
	}

	private void PlayInAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
