using LitJson;

namespace COW;

public class CUninonData : IModeEditComponentData
{
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public ModeVariableBinding TipEnabled;

	public string LabelTipKey;

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
