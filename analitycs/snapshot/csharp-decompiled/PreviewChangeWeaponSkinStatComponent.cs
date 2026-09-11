using UnityEngine;

public class PreviewChangeWeaponSkinStatComponent : MonoBehaviour
{
	public GameObject WeaponA;

	public GameObject WeaponB;

	public GameObject WeaponC;

	private GameObject m_GameObject;

	private uint m_SkinA;

	private uint m_SkinB;

	private uint m_SkinC;

	private int m_CurIndex;

	private const float SWITCH_INTERVAL = 4f;

	private uint m_loopTimes;

	private bool m_TickStart;

	private bool m_TickInit;

	private float m_TickTime;

	private bool m_PlayAnim;

	private double m_AnimTime;

	private double m_AnimInternal;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChildModelCreated(object[] data)
	{
	}

	public void StartToLoopPerview(GameObject goA, GameObject goB, GameObject goC, uint skinA, uint skinB, uint skinC)
	{
	}

	public void StartToLoopPreviewOnce(GameObject goA, GameObject goB, bool skipAnim = false)
	{
	}

	public void StartToLoopPreviewOnceInMulti(GameObject goA, GameObject goB, GameObject goC, bool skipAnim = false)
	{
	}

	public uint GetCurrentShowingWeaponSkinId()
	{
		return 0u;
	}

	private void Update()
	{
	}

	private void SetWeaponCVisible(bool isVisible)
	{
	}

	private void SetWeaponBVisible(bool isVisible)
	{
	}

	private void SetWeaponAVisible(bool isVisible)
	{
	}

	public void CheckAnim(bool needSkipAnim = false, bool isFindInChildren = true)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
