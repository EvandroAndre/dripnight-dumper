using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIBaseChooseLoadoutV2Controller : UIBaseController, IEasyList
{
	protected UIButton m_BrBtn;

	protected UIButton m_CsBtn;

	protected UIEasyList m_V2LoadoutItems;

	protected UIEasyList m_LoadoutLevels;

	protected UILabel m_LoadoutName;

	protected UILabel m_LoadoutDesc;

	protected GameObject m_CsSelect;

	protected GameObject m_CsUnselect;

	protected GameObject m_BrSelect;

	protected GameObject m_BrUnselect;

	protected UILabel m_LockTips;

	protected UIModelLoadout m_Model;

	private uint m_CurSelectedMode;

	public uint CurSelectedLoadoutId;

	private bool m_LoadoutLock;

	private List<uint> m_LoadoutLevelList;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected abstract void InitView();

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public int GetCurLoadoutLevelCount()
	{
		return 0;
	}

	protected virtual void RefreshSelectedMode()
	{
	}

	protected virtual void RefreshLoadoutLevelList()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public uint GetLevelAbilityByIndex(int index)
	{
		return 0u;
	}

	private void OnLoadoutV2Change(uint loadoutV2)
	{
	}

	protected virtual void OnBrBtnClick()
	{
	}

	protected virtual void OnCsBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
