using GCommon;
using UnityEngine;

namespace COW;

public abstract class UISceneEditItemAttributeControllerBase : UIBaseController
{
	protected string m_LogicEntityID;

	protected long m_PropID;

	protected ItemEditAttributeUIData_V2 m_ModelData;

	public virtual void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	protected void InitDataStoreInfo(ItemEditAttributeUIData_V2 data)
	{
	}

	protected void TriggerDataCallback(int value)
	{
	}

	protected void TriggerDataCallback(float value)
	{
	}

	protected void TriggerDataCallback(bool value)
	{
	}

	protected void TriggerDataCallback(string value)
	{
	}

	protected void TriggerDataCallback(Vector3 value)
	{
	}

	protected void TriggerDataCallback(Quaternion value)
	{
	}

	protected void TriggerDataCallback(MutableValue value)
	{
	}
}
