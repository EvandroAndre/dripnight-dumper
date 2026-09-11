using COW.Gameplay.UGC.BlockEdit;
using UnityEngine;

namespace COW.GamePlay;

public class BE_DragDropItemBase : UIDragDropItem
{
	public BE_Base DataController;

	protected BE_DragDropManager EKDOMLLCLCA;

	protected BE_ProgrammingEnv JFPIAPJMFAA;

	protected float IHIKEAMPDDM;

	protected bool FAAFKHCCPHB;

	protected FJGKLPLIFBM OPHNFDMOOEJ;

	protected NIHICNLMENM GNLLGIMHOEN;

	protected CNHJKIADCEO MBHGMJHMBCJ;

	protected HOEKGGPFBIA FBFAGBNIHFA;

	protected IBlockDataContainer MMDAMDGMNGE;

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	protected override void OnPress(bool CGOOONHIHHB)
	{
	}

	protected virtual void OnClick()
	{
	}

	protected override void OnDragStart()
	{
	}

	public override bool StartDragging()
	{
		return false;
	}

	protected override void OnDrag(Vector2 JHLNMNMLGPB)
	{
	}

	protected override void OnDragEnd()
	{
	}

	public virtual void RemoveBlock()
	{
	}

	public virtual void RealRemoveBlock(BlockData JCONDDPFBKK)
	{
	}

	public virtual bool EnableCreateBlock(BlockData MEDJFOFAHPG)
	{
		return false;
	}

	public virtual void SetBlockPos()
	{
	}

	public virtual BE_Base CreateBlockObj(BlockData MEDJFOFAHPG)
	{
		return null;
	}

	public virtual void ShiftBlock()
	{
	}

	public virtual void SplitBlock()
	{
	}

	protected virtual void BLAMGJFABJB()
	{
	}

	public virtual void SetColliderEnable(bool HCLGHJNEFIC)
	{
	}

	public virtual void ForcePutInProgrammingSurface()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPress(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragStart()
	{
	}

	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDrag(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragEnd()
	{
	}
}
