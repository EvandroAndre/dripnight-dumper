using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UILockAirDropIconController : MonoBehaviour
{
	public UISprite StateBg;

	public UISprite Progress;

	public GameObject StateIcon;

	public GameObject StateIcon02;

	public GameObject StateIcon03;

	public GameObject TimeIcon;

	public GameObject ProgressPanel;

	public GameObject FightGB;

	public Vector2 WorldPos;

	private LockAirDropIcon m_Icon;

	private uint m_InteractTime;

	private DFMAGBNLCHD m_Type;

	private string m_iconSpriteName;

	private uint m_ObjectID;

	private VisualInstanceHolder m_LotusLampOpenVfx;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(DFMAGBNLCHD type, uint interact, Vector3 worldPos, uint levelObjectID, uint specialAirDropID = 0u)
	{
	}

	private bool CheckIconCreate()
	{
		return false;
	}

	public void Recyle()
	{
	}

	public void SetState(InteractiveState state)
	{
	}

	public void SetStep(int step)
	{
	}

	public void SetTime(int time)
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public uint GetObjectID()
	{
		return 0u;
	}

	private void InTriggerAllIsEnemyChanged(uint objectId, uint boolValue)
	{
	}

	public void ShowDiwaliLotusLampOpenEffect(bool b)
	{
	}

	public DFMAGBNLCHD GetAirDropType()
	{
		return DFMAGBNLCHD.AirDropInteractLock;
	}
}
