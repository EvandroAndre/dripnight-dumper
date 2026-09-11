using UnityEngine;

public class DisplayName : PropertyAttribute
{
	private string _003CdisplayName_003Ek__BackingField;

	public string displayName
	{
		get
		{
			return _003CdisplayName_003Ek__BackingField;
		}
		protected set
		{
			_003CdisplayName_003Ek__BackingField = value;
		}
	}

	public DisplayName(string InDisplayName)
	{
	}
}
