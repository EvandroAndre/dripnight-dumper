using COW.GamePlay;
using GCommon;
using UnityEngine;

internal class PVEDamageAnimLabel : MonoBehaviour
{
	public UILabel m_Label;

	public UISprite DamageTypeIcon;

	public float[] HeadPos;

	public bool FollowTarget;

	public float DistanceHead;

	public float RedColorScale;

	public bool DistanceReduce;

	private bool m_IsStart;

	private AttackableEntity m_Owner;

	private Vector3 m_MovePos;

	private float m_RandX;

	private float m_RandY;

	private TweenScale m_Scale;

	private TweenPosition m_LabelPos;

	private Transform m_CachedTransform;

	private bool m_IsUsing;

	private UITweener[] m_Tweeners;

	private Vector3[] m_CacheScaleValue;

	private bool m_StillFollow;

	private Vector3 m_BaseScale;

	private uint m_UnFreezeID;

	private float m_StartTime;

	private ResourceID m_LastShowDamageIcon;

	public AttackableEntity Owner
	{
		set
		{
		}
	}

	public bool IsUsing => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void MoveObjecTo()
	{
	}

	public float ReduceValue()
	{
		return 0f;
	}

	public void SetLabelString(string score, Color color, int weaponDataID, bool followTarget = true, int shieldDamage = 0, Color shieldOutlineColor = default(Color), string damageIconName = null, Color damageIconColor = default(Color))
	{
	}

	private void FreezeTweeners()
	{
	}

	private void UnfreezeTweeners()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}

	public void OnFinished()
	{
	}
}
