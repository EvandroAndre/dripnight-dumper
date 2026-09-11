using System.Collections.Generic;
using LitJson;

namespace COW;

public class CToggleGroupData : IModeEditComponentData
{
	public class ToggleItem
	{
		public string labelKey;

		public ModeVariableBinding value;

		public int index;
	}

	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public ModeVariableBinding value;

	public List<ToggleItem> items;

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
