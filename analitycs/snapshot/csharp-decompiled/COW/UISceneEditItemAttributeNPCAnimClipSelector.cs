using COW.GamePlay;
using GCommon;

namespace COW;

public class UISceneEditItemAttributeNPCAnimClipSelector : UISceneEditItemAttributeControllerBase
{
	private UISceneEditItemAttributeNPCAnimClipSelectorView m_View;

	private UIModelUGCResourceSelect m_ModelResSelect;

	private string m_EntityID;

	protected string m_TipKey;

	private string m_CurValue;

	private string CurValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	public void OnSelectorBtnClick()
	{
	}

	private void OnFinalSelected(UIUGCNPCAnimStateClipSelectorController.CIIEIJOHNAG result)
	{
	}

	protected void OnClickHintButton()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
