using System;
using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

public abstract class UINinthSYSProgressRewardBoxGo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, BaseItemInfo> _003C_003E9__20_0;

		public static Converter<OptionalBundleShowData, BaseItemInfo> _003C_003E9__20_1;

		public static Converter<TreasureBoxShowData, BaseItemInfo> _003C_003E9__20_2;

		internal BaseItemInfo _003CGetItemBoxShowData_003Eb__20_0(BundleShowData temp)
		{
			return null;
		}

		internal BaseItemInfo _003CGetItemBoxShowData_003Eb__20_1(OptionalBundleShowData temp)
		{
			return null;
		}

		internal BaseItemInfo _003CGetItemBoxShowData_003Eb__20_2(TreasureBoxShowData temp)
		{
			return null;
		}
	}

	protected GameObject gameObject;

	protected UIModelNinthSYS.Status m_Status;

	protected UILabel m_ProgressLabel;

	protected UIButton m_BoxBtn;

	protected GameObject m_NormalBoxGo;

	protected GameObject m_OpenBoxGo;

	protected GameObject m_ClaimableGo;

	protected GameObject m_NormalBoxAnimationGo;

	protected Action<int, Vector3> m_OnClickCallback;

	protected int m_Index;

	protected uint m_Progress;

	public UINinthSYSProgressRewardBoxGo(UIBigEventPorgressRewardBoxView view, int index)
	{
	}

	public UINinthSYSProgressRewardBoxGo AddCallback(Action<int, Vector3> onClickCallback)
	{
		return null;
	}

	public void Destroy()
	{
	}

	public void Init(UIModelNinthSYS.Status status, uint progress)
	{
	}

	public abstract void Refersh();

	protected virtual void RefershView()
	{
	}

	protected virtual void OnClickBoxBtn()
	{
	}

	public abstract bool Refersh(uint val);

	public void OnProgressRewardBoxClick(int index, Vector3 position)
	{
	}

	public bool GetItemBoxShowData(uint originalItemId, out List<BaseItemInfo> itemList, out string desc)
	{
		itemList = null;
		desc = null;
		return false;
	}
}
