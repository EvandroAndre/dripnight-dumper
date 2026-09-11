using System.Collections.Generic;
using LitJson;

namespace COW;

public class UIModeEditData
{
	public class EntranceInfoData
	{
		public string iconUrl;

		public ModeVariableBinding offsetX;

		public ModeVariableBinding offsetY;

		public ModeVariableBinding width;

		public ModeVariableBinding height;
	}

	public class EditDataContext
	{
		public List<IModeEditComponentData> SettingPanelComponentData;

		public ModeVariables Variables;

		public bool NeedUIMappingForLevelObject;

		public Dictionary<string, IModeEditComponentData> BindVariablesUIMapping;
	}

	public IModeEditComponentData ComponentData;

	public bool IsReady;

	public EntranceInfoData EntranceInfo;

	public EditDataContext Context;

	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return false;
	}
}
