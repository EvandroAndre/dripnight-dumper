using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditItemAttributeQuaternionController : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	private UISceneEditItemAttributeQuaternionView m_View;

	protected Vector3 m_CurValue;

	protected string m_UGCType;

	protected string m_TipKey;

	protected PJKGGCKLOFF m_Condition;

	protected virtual Vector3 CurValue
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

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
