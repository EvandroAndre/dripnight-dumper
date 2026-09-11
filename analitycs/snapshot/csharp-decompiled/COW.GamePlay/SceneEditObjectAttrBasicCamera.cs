using System;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;

namespace COW.GamePlay;

public class SceneEditObjectAttrBasicCamera : SceneEditObjectAttrBase
{
	private UGCBasicCameraObject LALOOFDBFNG;

	public Action<float> OnFovChangeEvent;

	public Action<float> OnOrthogonalSizeChangeEvent;

	public Action<NHMBEJGPEMP> OnCameraProjectionModeChangeEvent;

	private float _003CHIKLLPHOOGH_003Ek__BackingField;

	private float _003CAOINFDECJIB_003Ek__BackingField;

	private NHMBEJGPEMP _003CGJBFCONOJPG_003Ek__BackingField;

	private UGCBasicCameraObject FEENALJNCCC => null;

	public float HHCIJJGJGME
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DAAGCJKNGGG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public NHMBEJGPEMP CGHJDFFOMDK
	{
		get
		{
			return NHMBEJGPEMP.Perspective;
		}
		set
		{
		}
	}

	public override void ApplyDataStoreToSceneEditObj(long DLMGDEAFLHD, UGCSimpleValue GPFPIAMCEMI, bool ODIKHPAIHNM = true)
	{
	}

	public override void OnRemove()
	{
	}

	public override void OnSelected(bool PFCBBDKABBN)
	{
	}

	public void _003C_003EiFixBaseProxy_ApplyDataStoreToSceneEditObj(long P0, UGCSimpleValue P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnRemove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelected(bool P0)
	{
	}
}
