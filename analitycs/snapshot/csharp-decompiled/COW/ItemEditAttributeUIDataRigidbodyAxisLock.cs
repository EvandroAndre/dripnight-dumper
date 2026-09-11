namespace COW;

public class ItemEditAttributeUIDataRigidbodyAxisLock : ItemEditAttributeUIData_V2
{
	public enum ELockAxis
	{
		NONE = 0,
		LOCK_POS_X = 2,
		LOCK_POS_Y = 4,
		LOCK_POS_Z = 8,
		LOCK_ROT_X = 0x10,
		LOCK_ROT_Y = 0x20,
		LOCK_ROT_Z = 0x40
	}

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public SceneEditItemAttributeUIType _003C_003EiFixBaseProxy_GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}
}
