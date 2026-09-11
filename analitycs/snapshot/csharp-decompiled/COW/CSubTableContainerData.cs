using LitJson;

namespace COW;

public class CSubTableContainerData : IModeEditComponentData
{
	public CTableContainerData TableContainerData;

	public GeneralComponentData GeneralData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool FromJsonData(UIModeEditData.EditDataContext context, JsonData jsonData)
	{
		return false;
	}
}
