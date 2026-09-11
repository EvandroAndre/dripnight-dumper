using GCommon;
using UnityEngine.Playables;

namespace COW;

public class UIMechadrakeB_FirstInAnimController : UIBaseController
{
	private UIMechadrakeB_FirstInAnimView m_View;

	private PlayableDirector m_Director;

	private double m_Duration;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnDirectorStoped(PlayableDirector playableDirector)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
