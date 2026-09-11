using System;
using COW.Gameplay.UGC.BlockEdit;
using ECAPackage;
using UnityEngine;

namespace COW.GamePlay;

public class BE_SlotDragDropItem : BE_DragDropItemBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ValueData> _003C_003E9__12_0;

		internal bool BCIMAFAJGDF(ValueData DNNNJDJIBMP)
		{
			return false;
		}
	}

	private sealed class JEFGANNMNKL
	{
		public string ADJGBDIIBMD;

		internal bool DPPCPCAGKBL(ECAVarTypeDefine DNNNJDJIBMP)
		{
			return false;
		}
	}

	private BE_SlotSpot IFBIMJFDFHO;

	protected override void Awake()
	{
	}

	public void OnSlotDragDropStart()
	{
	}

	protected override void OnDragDropMove(Vector2 JHLNMNMLGPB)
	{
	}

	public override void RemoveBlock()
	{
	}

	protected override void OnDragDropRelease(GameObject GPFDAEDHEII)
	{
	}

	public override BE_Base CreateBlockObj(BlockData MEDJFOFAHPG)
	{
		return null;
	}

	public override void ShiftBlock()
	{
	}

	public override void SplitBlock()
	{
	}

	private void AKLNFLIJLJL()
	{
	}

	public void SetDataBlockToSlot(BE_SlotSpot CDLHGELKADB)
	{
	}

	public bool HandleDataBlockSetToSlot(ValueData LABNPBJKCDN, BE_SlotSpot CDLHGELKADB)
	{
		return false;
	}

	public void UpdateBlockItemVal(BE_BlockSectionHeader_Slot DBPNIDJEAAE, ValueData ONCOAODOILG, bool ECKDGMPFKMO = true)
	{
	}

	public void SetTouch(UICamera.MouseOrTouch DCCIKONPGCC)
	{
	}

	public new void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RemoveBlock()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	public BE_Base _003C_003EiFixBaseProxy_CreateBlockObj(BlockData P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ShiftBlock()
	{
	}

	public void _003C_003EiFixBaseProxy_SplitBlock()
	{
	}
}
