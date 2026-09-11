using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

public class VendingMachineEditAttributeConfig : ItemEditAttributeBaseConfig
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public string curBindShopID;

		public VendingMachineEditAttributeConfig _003C_003E4__this;

		internal bool _003CGetUIData_003Eb__0(string e)
		{
			return false;
		}

		internal void _003CGetUIData_003Eb__1(int index)
		{
		}
	}

	public string ShopKey;

	public string TriggerRadiusKey;

	public float TriggerRadiusMaxValue;

	public float TriggerRadiusMinValue;

	public float TriggerRadiusDefaultValue;

	public float TriggerRadiusStep;

	public string ModelShowKey;

	public List<int> ModelShowList;

	public List<string> ModelShowKeyList;

	private LHFNKEDKCBK m_ShopEditor;

	private List<int> m_ShopIndexList;

	private List<string> m_ShopIDList;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectVendingMachine sceneEditObject)
	{
		return null;
	}

	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	private void SetAttributeData(SceneEditObjectVendingMachine vendingMachine, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	public List<ItemEditAttributeUIData> _003C_003EiFixBaseProxy_GetDefaultUIData()
	{
		return null;
	}

	public List<ItemEditAttributeUIData> _003C_003EiFixBaseProxy_GetSceneEditObjectUIData(SceneEditObjectBase P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase P0, List<ItemEditAttributeCacheValueBase> P1)
	{
	}
}
