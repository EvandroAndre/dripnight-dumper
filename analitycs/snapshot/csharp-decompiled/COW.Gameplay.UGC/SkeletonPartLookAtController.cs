using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class SkeletonPartLookAtController : UGCSkeletonPartController
{
	private UGCSkeletonBone m_controlBone;

	public Transform LookatTransform;

	public bool AlignOwner;

	private EntityIndex m_controlBoneIndex;

	private EntityIndex m_lookatTargetIndex;

	private string m_lookatTargetEntityID;

	private UGCEntityRepDataItem m_targetPosItem;

	public override int SortValue => 0;

	public UGCSkeletonBone ControlBone
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void DestroyController()
	{
	}

	public override void LateUpdateController()
	{
	}

	public new SkeletonPartLookAtController AttachUGCRuntime(UGCSkeletonPartControllerModule skeletonModule, EntityIndex entityIndex)
	{
		return null;
	}

	public void Destroy()
	{
	}

	private void _OnUGCPropertyChanged(long propID, UGCSimpleValue itemValue)
	{
	}

	public int _003C_003EiFixBaseProxy_get_SortValue()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DestroyController()
	{
	}

	public void _003C_003EiFixBaseProxy_LateUpdateController()
	{
	}
}
