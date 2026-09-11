public class ItemEditAttributeUIDataSubAndPlus : ItemEditAttributeUIData
{
	protected float m_MinValue;

	protected float m_MaxValue;

	protected float m_StepValue;

	protected float m_CurUIValue;

	protected float m_ExtraData;

	public string m_ExtraDataKey;

	public float MinValue => 0f;

	public float MaxValue => 0f;

	public float StepValue => 0f;

	public float CurUIValue
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public float ExtraData => 0f;

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public override void UIChangeCallBack(object param, int valueOrder = 1)
	{
	}

	public override ItemEditAttributeCacheValueBase GetItemEditAttributeCacheValue()
	{
		return null;
	}

	public void ScriptObjectDataToUIData(string attributeTitleNameKey, float minValue, float maxValue, float defaultValue, float stepValue, float extraData = -1f, string extraDataKey = "")
	{
	}
}
