using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class SceneEditObjectAttrBase : MonoBehaviour
{
	private SceneEditObjectBase ONNNEBBNDAD;

	private uint m_resetEveryRound;

	protected SceneEditObjectBase PNKLKCBDGAP => null;

	public uint AAJDPGCOGLA
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public virtual void OnAddCrosshair()
	{
	}

	public virtual void OnSelected(bool PFCBBDKABBN)
	{
	}

	public virtual void OnPutDown()
	{
	}

	public virtual void SetColor(Color OJNBAOAIPLE)
	{
	}

	public virtual void ApplyDataStoreToSceneEditObj(long DLMGDEAFLHD, UGCSimpleValue GPFPIAMCEMI, bool ODIKHPAIHNM = true)
	{
	}

	public virtual void ApplyStoreDataToEditorEntityData()
	{
	}

	private void CJNOCKBOPOM(INAMDLOFOHF JCONDDPFBKK, UGCEntityRepData LIFJDDCGEFF)
	{
	}

	private void GMOEJJLEOGH(INAMDLOFOHF JCONDDPFBKK, UGCEntityRepData LIFJDDCGEFF, string DKKPGNPPJII)
	{
	}

	private void FCOHBAIBHKF(INAMDLOFOHF JCONDDPFBKK, UGCEntityRepData LIFJDDCGEFF, long FAICJLONPIK, string EGFCILMHGCD, bool HDGJNMODJON)
	{
	}

	private bool OCFBIMFLMNN(long FAICJLONPIK)
	{
		return false;
	}

	public virtual void OnSetVariables()
	{
	}

	public virtual void OnRemove()
	{
	}
}
