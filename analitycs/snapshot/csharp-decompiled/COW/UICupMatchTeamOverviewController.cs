using GCommon;
using proto;

namespace COW;

public class UICupMatchTeamOverviewController : UIBaseController, IUIModelDataChangeObserver
{
	private UICupMatchTeamOverviewView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private bool m_CanEdit;

	private int m_CupMatchKey;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(CupTeamInfo teamInfo, int key, bool showEditButton = false)
	{
	}

	public void SetNationFlag(UISprite flagSprite, CupTeamInfo teamInfo)
	{
	}

	private void EditInfo()
	{
	}

	private void OnTipsBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
