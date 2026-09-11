using System.Collections.Generic;
using LitJson;

namespace COW;

public class CPopMenuData : IModeEditComponentData
{
	public enum SubTypeEnum
	{
		InfectionMode = 1
	}

	public class PopMenuItem
	{
		public string labelKey;

		public ModeVariableBinding value;

		public int index;
	}

	public class IntItems
	{
		public ModeVariableBinding start;

		public ModeVariableBinding end;
	}

	private GeneralComponentData _003CGeneralData_003Ek__BackingField;

	public IntItems IntItemsDesc;

	public List<PopMenuItem> items;

	public ModeVariableBinding value;

	public ModeVariableBinding width;

	public ModeVariableBinding dirUp;

	public ModeVariableBinding addDepth;

	public ModeVariableBinding selectable;

	public ModeVariableBinding HasPicker;

	public ModeVariableBinding SubType;

	public bool internalSelectable;

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

	public void ResetIntItemsAction()
	{
	}

	public bool ResetIntItems()
	{
		return false;
	}
}
