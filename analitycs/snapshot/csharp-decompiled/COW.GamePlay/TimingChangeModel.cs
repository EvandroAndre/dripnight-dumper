using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class TimingChangeModel : MonoBehaviour, IUIModelDataChangeObserver
{
	public int m_ChangeModelTime;

	public string m_ModleID;

	public string m_ChangeEffectID;

	public string m_ChangeSoundID;

	public GameObject m_Modle;

	private UIModelMatch MFHEDBIDEFC;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnDataChanged(UIBaseModel NAGHAPBBLKF, uint FAICJLONPIK, object[] DJAPBCKDFKA)
	{
	}

	public uint GetInterestedPropID(UIBaseModel NAGHAPBBLKF)
	{
		return 0u;
	}
}
