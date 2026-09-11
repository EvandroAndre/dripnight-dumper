using LitJson;

namespace COW;

public class CShopData : IModeEditComponentData
{
	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

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
