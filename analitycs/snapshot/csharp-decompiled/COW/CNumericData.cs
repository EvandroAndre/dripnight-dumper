using LitJson;

namespace COW;

public class CNumericData : IModeEditComponentData
{
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public ModeVariableBinding maxValue;

	public ModeVariableBinding minValue;

	public ModeVariableBinding step;

	public ModeVariableBinding value;

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
