using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC.BlockEdit;
using ECAPackage;
using UnityEngine;

public class BE_BlockButton : MonoBehaviour, I_BE_BlockButton
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ValueData> _003C_003E9__21_0;

		internal bool _003CUpdateBlockItemVal_003Eb__21_0(ValueData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string typeInfoString;

		internal bool _003CUpdateBlockItemVal_003Eb__1(ECAVarTypeDefine e)
		{
			return false;
		}
	}

	private sealed class _003CWaitForSetDataBlockToSlot_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BE_BlockButton _003C_003E4__this;

		public BE_BlockSectionHeader_Slot slot;

		public BE_Base blockBase;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForSetDataBlockToSlot_003Ed__24(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIWidget m_Widget;

	private UIButton m_Btn;

	private BoxCollider m_Collider;

	private Transform m_Transform;

	private BlockData m_BlockData;

	private BlockData m_ClonedBlockData;

	private BE_DragDropManager m_DragDropMgr;

	public UIWidget Widget => null;

	public UIButton Btn => null;

	public BoxCollider Collider => null;

	public Transform Transform => null;

	private void Awake()
	{
	}

	public void Init(BlockData data)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void UpdateDepth(int startDepth = 1)
	{
	}

	private void SetDataBlockToSlot(BE_BlockSectionHeader_Slot slot, BE_Base blockBase)
	{
	}

	private void UpdateBlockItemVal(BE_BlockSectionHeader_Slot slot, ValueData vData, bool updateReturnType = true)
	{
	}

	private BE_Base CreateBlock()
	{
		return null;
	}

	private void OnBtnClick()
	{
	}

	private IEnumerator WaitForSetDataBlockToSlot(BE_BlockSectionHeader_Slot slot, BE_Base blockBase)
	{
		return null;
	}

	private bool EnableCreateBlock(BlockData newData)
	{
		return false;
	}
}
