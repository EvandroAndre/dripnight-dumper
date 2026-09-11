using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class SceneEditObjectCustomPointV2 : SceneEditObjectBase
{
	private sealed class APGPICBEOBG
	{
		public Action<SceneEditObjectBase> DBJBCFOHNLG;

		public SceneEditObjectBase HACIJIFIDKM;

		internal void CJMIPONEJLD()
		{
		}
	}

	public SceneEditObjectCustomPointV2 PrevPoint;

	public SceneEditObjectCustomPointV2 NextPoint;

	public int HeadObjIndex;

	private int DJLGLMNDENP;

	private ResourceID KADOOIALJEP;

	private ResourceID JCMLGEPPMBG;

	private GameObject PECPLENBNJM;

	private GameObject IPOEBAILPNH;

	private TextMesh JFEEBFFDCBN;

	public int NIFIMAOGFHJ
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override AGKINNABLGO LBCDJMAPELL(out string PFDHJBOJJGH)
	{
		PFDHJBOJJGH = null;
		return AGKINNABLGO.Success;
	}

	public override void OnRemove(List<CNGBCLDDJEF> BMDHOAHLPCJ, bool DJPJBGKKEPC)
	{
	}

	public override void Cleanup()
	{
	}

	protected override void DAMABAPIMMF()
	{
	}

	public void OnAddNext(SceneEditObjectCustomPointV2 LOPJCNOKJDO, bool MCLGJPECBMK = false)
	{
	}

	public override void RemoveIfAllowed(Action<SceneEditObjectBase> DBJBCFOHNLG, SceneEditObjectBase HACIJIFIDKM)
	{
	}

	public void UpdateNumberIndex(int NIBBKONKPHP, bool OLFBLNMGMJH)
	{
	}

	public bool IsHeadOrTail()
	{
		return false;
	}

	public override void OnUndoRemove()
	{
	}

	public override void OnMove()
	{
	}

	public override void OnRotate()
	{
	}

	public override void OnScale()
	{
	}

	public AGKINNABLGO _003C_003EiFixBaseProxy_LBCDJMAPELL(out string P0)
	{
		P0 = null;
		return AGKINNABLGO.Success;
	}

	public void _003C_003EiFixBaseProxy_OnRemove(List<CNGBCLDDJEF> P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_Cleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_DAMABAPIMMF()
	{
	}

	public void _003C_003EiFixBaseProxy_RemoveIfAllowed(Action<SceneEditObjectBase> P0, SceneEditObjectBase P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUndoRemove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnMove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRotate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnScale()
	{
	}
}
