using LitJson;

namespace COW;

public class CAttributeData : IModeEditComponentData
{
	public CRangeData RangeData;

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
