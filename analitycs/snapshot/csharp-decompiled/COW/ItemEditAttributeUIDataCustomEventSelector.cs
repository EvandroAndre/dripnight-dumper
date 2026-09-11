using COW.Gameplay.UGC;

namespace COW;

public class ItemEditAttributeUIDataCustomEventSelector : ItemEditAttributeUIData_V2
{
	private UGCTimelineEditCustomEventKeyFrame _003CKeyFrame_003Ek__BackingField;

	public UGCTimelineEditCustomEventKeyFrame KeyFrame
	{
		get
		{
			return _003CKeyFrame_003Ek__BackingField;
		}
		private set
		{
			_003CKeyFrame_003Ek__BackingField = value;
		}
	}

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public void SetCurValueWithoutOnChange(UGCTimelineEditCustomEventKeyFrame value)
	{
	}

	public SceneEditItemAttributeUIType _003C_003EiFixBaseProxy_GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}
}
