using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCreatorLevelIconController : UIBaseController
{
	private UIUGCCreatorLevelIconView m_View;

	private uint m_CurrentLevel;

	private GameObject m_LoopAniObj;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetCreatorLevel(uint level, bool isSmallStyle = false, bool isLoopAnim = false, bool isShowRationAnim = false)
	{
	}

	public void PlayLoopAnim(bool isShowRationAnim = false)
	{
	}

	protected ResourceID GetArchitectIconResourceID(uint level)
	{
		return default(ResourceID);
	}

	public void SetSelectedEffect(bool value)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CPlayLoopAnim_003Eb__7_0(uint ticket, bool isSuccess, Object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
