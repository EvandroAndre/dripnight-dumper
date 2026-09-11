using System;
using GCommon;

namespace COW;

public class UIHudMatchResultInstantSurveyScoreItemController : UIBaseController
{
	private UIHudMatchResultInstantSurveySocreItemView m_View;

	private int m_Score;

	private Action<int> m_OnClickCallback;

	public int Score => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(int score, Action<int> onClickCallback)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void PlaySelectVFX()
	{
	}

	public void StopSelectVFX()
	{
	}

	private void OnClickScore()
	{
	}

	private static void PlayVFX(VFXCreateHelper helper)
	{
	}

	private static void StopVFX(VFXCreateHelper helper)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
