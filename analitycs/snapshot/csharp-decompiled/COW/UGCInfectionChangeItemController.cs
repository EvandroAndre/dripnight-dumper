using GCommon;
using message;

namespace COW;

internal class UGCInfectionChangeItemController : UIBaseController
{
	public class UGCInfectionChangeItemData
	{
		public uint ItemID;

		public MHHJIENEIPJ Type;
	}

	private UGCInfectionChangeItemView m_View;

	private UGCInfectionChangeItemData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(UGCInfectionChangeItemData data)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public uint GetItemID()
	{
		return 0u;
	}

	public void OnButtonClicked()
	{
	}

	private bool _003CSetData_003Eb__5_0(CSVBaseData x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
