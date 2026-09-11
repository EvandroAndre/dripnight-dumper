using UnityEngine;

namespace COW.GamePlay;

public class LevelChair : BaseLevelObject
{
	public enum NDMPJJPPDDB
	{
		Chair,
		Horse
	}

	public enum NINCHPEEHBL
	{
		CREATE,
		GET_ON,
		GET_OFF
	}

	public Transform OnSeatPosition;

	public Transform JumpOffPosition;

	public AnimRef SittingAnimation;

	public AnimRef SittingAnimationFemale;

	public uint ChairModelID;

	public NDMPJJPPDDB LevelChairType;

	protected BHGGAEEHJCO OMICNIKKFLH;

	protected BHGGAEEHJCO BKBBDEEJOCJ;

	private const float DNEEGLJHJAA = 0.8f;

	private const float KJILLEDDGDL = 1.8f;

	private static readonly Collider[] AFHPDFLCDDJ;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	public bool HasPlayerOnSeat()
	{
		return false;
	}

	public bool CanGetOn()
	{
		return false;
	}

	public Vector3 GetOnSeatPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetOnSeatForward()
	{
		return default(Vector3);
	}

	public Vector3 GetOffPosition()
	{
		return default(Vector3);
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private bool HFPBJGEFEAJ(Player PGEGMKJKOKI)
	{
		return false;
	}

	private bool FEJCDDFBBCO()
	{
		return false;
	}

	internal void CAAEJMICHCN(Player PGEGMKJKOKI)
	{
	}

	private void BEDKFJCHPMD(Player PGEGMKJKOKI, bool PEGJMGOLNBP)
	{
	}

	internal void JGOOEJFEEAP(Player PGEGMKJKOKI, bool PDEMMOBBACC)
	{
	}

	private void HAKKLODFGON(Player PGEGMKJKOKI, bool PEGJMGOLNBP)
	{
	}

	public override bool CreateDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}
}
