using LitJson;

namespace COW;

public interface IModeEditComponentData
{
	GeneralComponentData GeneralData { get; set; }

	bool FromJsonData(UIModeEditData.EditDataContext context, JsonData jsonData);
}
