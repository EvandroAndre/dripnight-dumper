using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

internal class UIWeaponExpContentController : UIBaseController
{
	private UIWeaponExpContentView m_View;

	private List<UIWeaponExpItemController> m_Items;

	private List<WeaponExpUpdateInfo> m_WeaponExpUpdateInfoList;

	private const int DefaultShowNum = 4;

	private const float OnlyProficiencyPos = 64f;

	private UIModelUser m_ModelUser;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetData()
	{
	}

	public void PlayVFX()
	{
	}

	public void DisableVFX()
	{
	}

	public int GetItemCount()
	{
		return 0;
	}

	public int GetItemWidth()
	{
		return 0;
	}

	public void SetOnlyProficiency()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
