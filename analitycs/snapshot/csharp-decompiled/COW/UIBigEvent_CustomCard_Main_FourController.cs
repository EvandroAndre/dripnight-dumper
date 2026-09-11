using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_Main_FourController : UICustomCardMainBaseController
{
	private UIBigEvent_CustomCard_Main_FourView m_View;

	private Transform[] cardParents;

	protected override string BoxAppearAnim => null;

	protected override string CardCombineAnim => null;

	protected override string BoxShakeAnim => null;

	protected override string CardMainStandAnim => null;

	protected override string CardMainInAnim => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void CreateCard()
	{
	}

	public string _003C_003EiFixBaseProxy_get_BoxAppearAnim()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_get_CardCombineAnim()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_get_BoxShakeAnim()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_get_CardMainStandAnim()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_get_CardMainInAnim()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
