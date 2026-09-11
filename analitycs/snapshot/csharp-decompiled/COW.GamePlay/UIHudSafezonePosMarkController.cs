using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class UIHudSafezonePosMarkController : UIHudNameBaseController
{
	private UIHudTutorialTargetGuideView CGIEAOLABHM;

	private const float HJEIBMMLHMM = 1f;

	private Vector3 FMHPGHFEDEH;

	private SafeZone JJKGANMEKCJ;

	private readonly Color AIFDOEEEPON;

	private List<Transform> KJBELJDHPMB;

	private Vector3[] EFPPHFIDFNL;

	private Quaternion[] GKAPNIOMMDN;

	private GMPGMPFNMFP CIGEOCNIMJN;

	private float FANLGCEOGMN;

	private const float IBAKFJGGNHI = 0.1f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	public void BindPlayerAndWorldPosition(Vector3 CAABJKABACP)
	{
	}

	protected override void UpdateNamePosition()
	{
	}

	protected override void LateUpdate()
	{
	}

	private void GDDCOANFCKA(Vector3 NMHDNGNEAGP, Vector3 EMPDGGKCEJA)
	{
	}

	private Vector3 EOKECMMBPAM(Vector3 NODKAKMLNCB, Vector3 LJADOJKNALD, out Vector3 LJMCGDJDJGL)
	{
		LJMCGDJDJGL = default(Vector3);
		return default(Vector3);
	}

	private void PJABECCFKGG()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}

	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}
}
