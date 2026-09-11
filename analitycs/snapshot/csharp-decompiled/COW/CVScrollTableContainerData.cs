using System.Collections.Generic;
using LitJson;

namespace COW;

public class CVScrollTableContainerData : IModeEditComponentData
{
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public ModeVariableBinding height;

	public ModeVariableBinding visibleHeight;

	public ModeVariableBinding enableDragging;

	public List<IModeEditComponentData> items;

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
