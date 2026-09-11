using LitJson;

namespace COW;

public class GeneralComponentData
{
	public ModeVariables ContextVariables;

	public string type;

	public string labelKey;

	public string tipKey;

	public bool showInSettingPanel;

	public string bindLogName;

	public int uionIndex;

	public ModeVariableBinding enabled;

	public ModeVariableBinding ignoreBounds;

	public bool FromJsonData(IModeEditComponentData parentData, UIModeEditData.EditDataContext context, JsonData jsonData)
	{
		return false;
	}
}
