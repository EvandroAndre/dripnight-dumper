using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_Template_TokenItemBaseController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIBigEvent_Template_TokenItemBaseController _003C_003E4__this;

		public Transform tipPos;

		internal void _003CInitTokenBtn_003Eb__0()
		{
		}
	}

	protected UISprite TokenIcon;

	protected Transform TokenTipsTrans;

	protected UILabel TokenCount;

	protected UIButton TokenBtn;

	protected UIModelBigEventTemplate m_ModelBigEventTemplate;

	private uint m_TokenId;

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

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual void SetViewData(uint tokenId)
	{
	}

	private void InitTokenBtn(UISprite tokenSprite, UIButton btnToken, UILabel tokenCount, Transform tipPos)
	{
	}

	private void OnTokenTipClick(uint tokenId, Transform trans)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
