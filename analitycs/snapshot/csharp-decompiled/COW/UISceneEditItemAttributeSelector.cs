using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UISceneEditItemAttributeSelector : UISceneEditItemAttributeControllerBase
{
	private UISceneEditItemAttributeSelectorView m_View;

	private UIModelUGCResourceSelect m_ModelResSelect;

	protected string m_TipKey;

	private string m_CurValue;

	private string m_UGCType;

	private UIModelUGCResourceSelect.ETableType m_TableType;

	private List<FCAJEKECGME> m_Data;

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

	private bool _003CInitShowData_003Eb__12_0(FCAJEKECGME x)
	{
		return false;
	}

	private bool _003COnFinalSelected_003Eb__14_0(FCAJEKECGME x)
	{
		return false;
	}

	private void _003COnFinalSelected_003Eb__14_1(bool succ, UGCTexture resObj)
	{
	}

	private void _003COnFinalSelected_003Eb__14_2(UIAtlas atlas, string spriteName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
