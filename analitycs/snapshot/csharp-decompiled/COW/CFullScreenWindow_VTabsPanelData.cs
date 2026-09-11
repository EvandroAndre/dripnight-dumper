using System.Collections.Generic;
using LitJson;

namespace COW;

public class CFullScreenWindow_VTabsPanelData : IModeEditComponentData
{
	public class TabItem
	{
		public string labelKey;

		public IModeEditComponentData contentComponent;

		public ModeVariableBinding enabled;
	}

	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public ModeVariableBinding itemIndex;

	public List<TabItem> items;

	public GeneralComponentData GeneralData
	{
		get
		{
			return _003CGeneralData_003Ek__BackingField;
		}
		set
		{
			_003CGeneralData_003Ek__BackingField = value;
		}
	}

	public bool FromJsonData(UIModeEditData.EditDataContext context, JsonData jsonData)
	{
		return false;
	}
}
