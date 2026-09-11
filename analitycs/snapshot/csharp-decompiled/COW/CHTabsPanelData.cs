using System.Collections.Generic;
using LitJson;

namespace COW;

public class CHTabsPanelData : IModeEditComponentData
{
	public enum SubTypeEnum
	{
		TabsContent = 1
	}

	public class TabItem
	{
		public string labelKey;

		public string subLabelKey;

		public IModeEditComponentData contentComponent;

		public bool IsHidden;
	}

	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public ModeVariableBinding unselectable;

	public ModeVariableBinding itemIndex;

	public ModeVariableBinding subType;

	public List<TabItem> items;

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
