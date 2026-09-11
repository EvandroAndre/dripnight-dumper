using GCommon;

namespace COW;

internal class UISceneEditSecondLevelAttributeToggleButton : UISceneEditItemAttributeControllerBase, IUISceneEditSecondLevelAttributeItem
{
	private UIRuleToggleSettingV2View m_View;

	private bool m_CurValue;

	private string m_TipKey;

	private bool CurValue
	{
		get
		{
			return false;
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

	public void InitShowData(ItemEditAttributeUIDataToggleButton data, float width)
	{
	}

	private void OnItemSelectCallback(UIToggleButton btn)
	{
	}

	private void OnClickHintButton()
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
