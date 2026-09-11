using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditItemAttributeVector3Controller : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	private UISceneEditItemAttributeVector3View m_View;

	protected Vector3 m_CurValue;

	protected Vector3 m_MinValue;

	protected Vector3 m_MaxValue;

	protected string m_UGCType;

	protected string m_TipKey;

	protected PJKGGCKLOFF m_Condition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	protected void UpdateLabelText()
	{
	}

	protected void OnConditionHandler(bool value)
	{
	}

	private void OnInputLabelChanged()
	{
	}

	protected void SetValue(Vector3 value)
	{
	}

	private bool CheckValueValid(Vector3 scale)
	{
		return false;
	}

	protected void OnClickHintButton()
	{
	}

	public void RefreshView(ItemEditAttributeUIData_V2 data)
	{
	}

	public void SetEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
