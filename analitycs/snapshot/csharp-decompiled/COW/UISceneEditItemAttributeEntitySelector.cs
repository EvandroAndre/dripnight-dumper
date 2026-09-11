using COW.GamePlay;
using GCommon;

namespace COW;

public class UISceneEditItemAttributeEntitySelector : UISceneEditItemAttributeControllerBase
{
	private UISceneEditItemAttributeEntitySelectorView m_View;

	private string TypeNameFilter;

	private string m_CurValue;

	private string m_entityID;

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

	private void OnSelectedEntity(SceneEditObjectBase editObj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
