using System.Collections.Generic;
using GCommon;

namespace COW;

public class ItemMarkDataManager : SingletonModule<ItemMarkDataManager>
{
	public enum EBtnType
	{
		MarkPinBtn = 1,
		MarkBigMap,
		QuickMessageBtn,
		AutoEnemyMarkByResponseChatBtn,
		RoutePlanningMark,
		MarkQuickChat,
		ObserverQuickMessageBtn,
		Upper
	}

	private Dictionary<uint, InGameAccumulationCD> m_GradientCdDic;

	private Dictionary<string, InGameItemMarkData> m_ItemMarkDataDic;

	private CSVAsyncDataMap<uint, ItemMarkPointUIStyleData> m_ItemMarkPointUIStyleDataMap;

	public float[] BtnClickEndCheckMoment;

	public float[] BtnClickLastClickTimes;

	public float[] BtnClickNowCd;

	public List<float>[] m_BtnTypeClickTimesLists;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public ItemMarkPointUIStyleData GetItemMarkPointUIStyleData(uint id)
	{
		return null;
	}

	public InGameAccumulationCD FindGradientCdDataByBtnType(uint btnType)
	{
		return null;
	}

	public InGameItemMarkData FindItemMarkDataByType(string type)
	{
		return null;
	}

	public void ResetBtnClickTime()
	{
	}

	public float GetBtnLastClickTime(EBtnType btnType)
	{
		return 0f;
	}

	public float GetBtnLastClickCDEndTime(EBtnType btnType)
	{
		return 0f;
	}

	public bool BtnNotInCD(EBtnType type)
	{
		return false;
	}

	public bool BtnNotInCD(EBtnType type, out float time)
	{
		time = default(float);
		return false;
	}

	public float BtnClickToResetCD(EBtnType type)
	{
		return 0f;
	}
}
