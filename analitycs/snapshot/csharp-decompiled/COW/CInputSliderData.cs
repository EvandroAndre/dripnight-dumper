using LitJson;

namespace COW;

public class CInputSliderData : IModeEditComponentData
{
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public ModeVariableBinding floatPrecision;

	public ModeVariableBinding maxValue;

	public ModeVariableBinding minValue;

	public ModeVariableBinding step;

	public ModeVariableBinding value;

	public string unitKey;

	public bool IsFloat;

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
