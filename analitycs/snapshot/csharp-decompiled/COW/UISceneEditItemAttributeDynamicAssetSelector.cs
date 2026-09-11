using GCommon;

namespace COW;

public class UISceneEditItemAttributeDynamicAssetSelector : UISceneEditItemAttributeControllerBase
{
	private UISceneEditItemAttributeDynamicAssetSelectorView m_View;

	protected string m_TipKey;

	private string m_CurValue;

	private string m_UGCType;

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

	private void OnFinalSelected(string resourceName, int itemID)
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
