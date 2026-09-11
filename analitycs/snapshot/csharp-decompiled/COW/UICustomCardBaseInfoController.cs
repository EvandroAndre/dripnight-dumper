using GCommon;
using UnityEngine;

namespace COW;

public class UICustomCardBaseInfoController : UIEasyListItemController, IBigEventTemplateIdentifier
{
	protected CustomCard_CardData m_Data;

	protected UINetworkTexture networkTexture;

	protected Animation m_Anim;

	protected string m_strCdnUrl;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual string GetCdnUrl()
	{
		return null;
	}

	public float PlayAnim(string strAnim)
	{
		return 0f;
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
