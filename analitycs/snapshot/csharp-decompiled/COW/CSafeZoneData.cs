using LitJson;

namespace COW;

public class CSafeZoneData : IModeEditComponentData
{
	public CInputSliderData RangeData;

	public ModeVariableBinding maxCircleSize;

	public ModeVariableBinding minCircleSize;

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
