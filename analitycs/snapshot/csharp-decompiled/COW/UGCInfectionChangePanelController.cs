using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UGCInfectionChangePanelController : UIBaseController
{
	private UGCInfectionChangePanelView m_View;

	private int m_CountdownNumber;

	private float m_Countdown;

	private uint m_SelectedID;

	private List<UGCInfectionChangeItemController> m_ItemControllers;

	private const string ChooseRole = "T_35_PD_Infection_ZOMBIESELECT";

	private const string ChooseWeapon = "T_35_PD_Infection_HUMANSELECT";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	public void SetViewData(HCDCFJIJFEM info)
	{
	}

	private void OnSelectedUpdate(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
