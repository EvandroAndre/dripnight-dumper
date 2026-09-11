using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelHyperBook : UIBaseModel
{
	public enum HyperBookState
	{
		Unknown,
		NotFound,
		BeforePre,
		Pre,
		Open,
		Closed,
		Hide
	}

	public enum HyperBookPageState
	{
		Unknown,
		OutOfDate,
		BookNotOwned,
		AwardClaimed,
		FirstLockedAvailable,
		FirstLockedNotAvailable,
		WaitForPrevious,
		DrawAvailable,
		DrawNotAvailable
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<HyperBookPage, bool> _003C_003E9__84_0;

		public static Action<HttpErrorCode, object> _003C_003E9__99_0;

		internal bool _003CGetHyperBookUnlockCount_003Eb__84_0(HyperBookPage page)
		{
			return false;
		}

		internal void _003CRequestUnlockHyperBookHavingAllItems_003Eb__99_0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public UIModelHyperBook _003C_003E4__this;

		public uint bookID;

		internal void _003CRequestAutoUnlockOwnedPages_003Eb__0(HttpErrorCode errorCode, object result)
		{
		}
	}

	private const byte STEP1_READY = 1;

	private const byte STEP2_READY = 2;

	private const byte ALL_STEP_READY = 3;

	private byte m_ReadyFlag;

	public const uint PropID_HyperBookReady = 1u;

	public const uint PropID_HyperBookSpinNumChanged = 2u;

	public const uint PropID_HyperBookPageUnlocked = 4u;

	public const uint PropID_SpinHiddenPageFinished = 16u;

	public const uint PropID_HyperBookInfoRefresh = 32u;

	public const uint PropID_ExchangeBookToken = 64u;

	public const string PlayerPresKey_HyperBook_UnlockAvailable_TipsShow = "HyperBook_UnlockAvailable_TipsShow_{0}_{1}_{2}";

	public const string PlayerPresKey_HyperBook_UnlockAvailable_Click = "HyperBook_UnlockAvailable_Click_{0}_{1}_{2}";

	public const string PlayerPresKey_HyperBook_DrawAvailable_TipsShow = "HyperBook_DrawAvailable_TipsShow_{0}_{1}";

	public const string PlayerPresKey_HyperBook_DrawAvailable_LastDrawNum = "HyperBook_DrawAvailable_LastDrawNum_{0}_{1}";

	public const string BookID_PageID_Format = "{0}_{1}";

	public const string PLAYERPREF_CLAIM_GUIDE = "PlayerPref_HyperBook_Content_Claim_Guide_{0}";

	public const string PLAYERPREF_SECOND_PAGE_GUIDE = "PlayerPref_HyperBook_Content_SecondPage_Guide_{0}";

	public const string PLAYERPREF_HIDDEN_PAGE_GUIDE = "PlayerPref_HyperBook_Content_HiddenPage_Guide_{0}";

	public const string PLAYERPREF_BOOK_ENTRANCE_GUIDE = "PlayerPref_HyperBook_Entrance_Guide_{0}_{1}";

	private readonly WaitingResponseHandler m_WaitingResponseHandler;

	private readonly Dictionary<uint, CollectionBookDesc> m_HyperBookDescDict;

	private readonly Dictionary<uint, HyperBookInfo> m_HyperBookInfoDict;

	private bool _003CPendingAutoUnlock_003Ek__BackingField;

	private uint _003CPendingAutoUnlockBookId_003Ek__BackingField;

	private Dictionary<string, bool> m_BookIDToPageIDRedTipsCachedDict;

	private Dictionary<uint, BaseItemInfo> m_RemainExchangeBookIdToItemInfoDict;

	private Dictionary<uint, CollectionBookItemDesc> m_ItemIdToHyperBookDescDict;

	private Dictionary<uint, List<uint>> m_BookIdToPageItemIDDict;

	private uint _003CGeneralTokenId_003Ek__BackingField;

	public bool PendingAutoUnlock
	{
		get
		{
			return _003CPendingAutoUnlock_003Ek__BackingField;
		}
		set
		{
			_003CPendingAutoUnlock_003Ek__BackingField = value;
		}
	}

	public uint PendingAutoUnlockBookId
	{
		get
		{
			return _003CPendingAutoUnlockBookId_003Ek__BackingField;
		}
		set
		{
			_003CPendingAutoUnlockBookId_003Ek__BackingField = value;
		}
	}

	private byte ReadyFlag
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool IsReady => false;

	public Dictionary<uint, BaseItemInfo> RemainExchangeBookIdToItemInfoDict => null;

	public uint GeneralTokenId
	{
		get
		{
			return _003CGeneralTokenId_003Ek__BackingField;
		}
		set
		{
			_003CGeneralTokenId_003Ek__BackingField = value;
		}
	}

	public CollectionBookDesc GetCollectionBookDesc(uint bookID)
	{
		return null;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestHyperBookSetting(bool silence, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void OnRequestHyperBookSettingFinished(HttpErrorCode errorCode, object result)
	{
	}

	public void RequestHyperBookInfo(bool silence, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void OnRequestHyperBookInfoFinished(HttpErrorCode errorCode, object result)
	{
	}

	public void RequestAutoUnlockOwnedPages(uint bookID, List<uint> sort_ids)
	{
	}

	public void RequestUnlockHyperBookPage(uint bookID, int pageIdx)
	{
	}

	private void OnRequestUnlockHyperBookPageFinished(HttpErrorCode errorCode, object result)
	{
	}

	public void RequestSpinHyperBookHiddenPage(uint bookID)
	{
	}

	private void OnRequestSpinHyperBookHiddenPageFinished(HttpErrorCode errorCode, object result)
	{
	}

	public bool ResendRequestIfPreviousFailed()
	{
		return false;
	}

	public void OnInventoryNewItemsNtf(InventoryChangeMessage message)
	{
	}

	private void CheckIsNeedtUnlockHyperBookByBookId(HashSet<uint> bookIdList)
	{
	}

	private static void LogSpinHyperBookHiddenPageResult(uint bookID, int pageIdx, CSSpinHyperBookHiddenPageRes res)
	{
	}

	private HyperBookState GetHyperBookStateInternal(uint bookID)
	{
		return HyperBookState.Unknown;
	}

	private bool GetHyperBookPageDescInternal(uint bookID, int pageIdx, out CollectionBookItemDesc itemDesc)
	{
		itemDesc = null;
		return false;
	}

	private bool GetHyperBookPageInfoInternal(uint bookID, int pageIdx, out HyperBookPage pageInfo)
	{
		pageInfo = null;
		return false;
	}

	private int GetFirstLockedPageIdxInternal(uint bookID)
	{
		return 0;
	}

	private int GetHyperBookPageGeneralTokenNumInternal(uint bookID, int pageIdx)
	{
		return 0;
	}

	private int GetHyperBookPageTokenNumInternal(uint bookID, int pageIdx)
	{
		return 0;
	}

	private int GetHyperBookRemainSpinNumInternal(uint bookID)
	{
		return 0;
	}

	private bool IsHyperBookVisibleInternal(uint bookID)
	{
		return false;
	}

	private bool IsHyperBookContentAvailableInternal(uint bookID)
	{
		return false;
	}

	private bool IsHyperBookOwnedInternal(uint bookID)
	{
		return false;
	}

	private bool IsSpecialBook(uint bookID)
	{
		return false;
	}

	public bool IsSystemAvailable()
	{
		return false;
	}

	public bool IsHyperBookContentAvailable(uint bookID)
	{
		return false;
	}

	public bool IsHyperBookOwned(uint bookID)
	{
		return false;
	}

	public bool IsHasOwnAllItemInHyperBook(uint boolID)
	{
		return false;
	}

	public bool IsHasOwnOneItemInHyperBook(uint boolID)
	{
		return false;
	}

	public bool IsHyperBookHiddenPage(uint bookID, int pageIdx)
	{
		return false;
	}

	public bool IsHyperBookPageUnlocked(uint bookID, int pageIdx)
	{
		return false;
	}

	public HyperBookState GetHyperBookState(uint bookID)
	{
		return HyperBookState.Unknown;
	}

	public bool GetHyperBookType(uint bookID, out EStore.HyperBookType bookType)
	{
		bookType = default(EStore.HyperBookType);
		return false;
	}

	public int GetHyperBookPageCount(uint bookID)
	{
		return 0;
	}

	public int GetHyperBookUnlockCount(uint bookID)
	{
		return 0;
	}

	public bool IsBookUnlockEntirelyExceptBigPrize(uint bookID)
	{
		return false;
	}

	public int GetFirstLockedPageIdx(uint bookID)
	{
		return 0;
	}

	public int GetHyperBookRemainSpinNum(uint bookID)
	{
		return 0;
	}

	public int GetHyperBookHiddenPageIdx(uint bookID)
	{
		return 0;
	}

	public HyperBookPageState GetHyperBookPageState(uint bookID, int pageIdx)
	{
		return HyperBookPageState.Unknown;
	}

	public bool GetHyperBookPageDesc(uint bookID, int pageIdx, out CollectionBookItemDesc itemDesc)
	{
		itemDesc = null;
		return false;
	}

	public bool GetHyperBookPageInfo(uint bookID, int pageIdx, out HyperBookPage pageInfo)
	{
		pageInfo = null;
		return false;
	}

	public int GetHyperBookPageTokenNum(uint bookID, int pageIdx)
	{
		return 0;
	}

	public int GetHyperBookPageGeneralTokenNum(uint bookID, int pageIdx)
	{
		return 0;
	}

	public int GetMaximumTokenNum(uint bookID, int curPageIdx)
	{
		return 0;
	}

	public bool GetHyperBookPageItemBelongsTo(uint itemID, out uint bookID, out int pageIdx)
	{
		bookID = default(uint);
		pageIdx = default(int);
		return false;
	}

	public uint[] GetVisibleHyperBookIDArray()
	{
		return null;
	}

	public void AutoExchangeRemainToken(uint bookID)
	{
	}

	public void RequestExchangeBookUnlockToken(List<uint> bookIds, bool isAuto = false)
	{
	}

	public void RequestUnlockHyperBookHavingAllItems(uint bookId)
	{
	}

	public void RefreshRemainTokenForAllBooks()
	{
	}

	public uint[] GetVisibleSortedHyperBookIDArray()
	{
		return null;
	}

	public bool GetHyperBookAwardList(uint bookID, out List<AwardDesc> awardDesc)
	{
		awardDesc = null;
		return false;
	}

	public bool GetHyperBookPageAward(uint bookID, int pageIdx, out AwardDesc awardDesc)
	{
		awardDesc = null;
		return false;
	}

	public bool GetHyperBookOpenEndTimeByID(uint bookID)
	{
		return false;
	}

	public bool GetHyperBookHiddenPageSpinProbability(uint bookID, int pageID, out string probability)
	{
		probability = null;
		return false;
	}

	public bool GetHyperBookUnlockGopos(uint bookID, out uint goPos, out string subGoPos)
	{
		goPos = default(uint);
		subGoPos = null;
		return false;
	}

	public bool GetHyperBookObtainGoPos(uint bookID, out uint goPos, out string subGoPos)
	{
		goPos = default(uint);
		subGoPos = null;
		return false;
	}

	public bool CheckIsHyperBookItem(uint itemId)
	{
		return false;
	}

	public bool CheckIsHyperBook(uint itemId)
	{
		return false;
	}

	public void GotoHyperBook(uint itemId)
	{
	}

	public void HyperBookFasterEquip(uint itemID)
	{
	}

	private void UpdateBookUnlockAvailableRedTipsInternal(uint bookID)
	{
	}

	public void UpdateUnlockAvailableRedTips()
	{
	}

	private void UpdateUnlockRedtipsAfterUnlockSucess(uint bookID, int pageIdx)
	{
	}

	private void UpdateDrawRedTips(uint bookID, int remainNum, bool hiddenPageUnlocked = false)
	{
	}

	private void UpdateDrawRedTipsAfterUnlock(uint bookID, int remainNum)
	{
	}

	private void _003CRequestExchangeBookUnlockToken_003Eb__98_0(HttpErrorCode errorCode, object res)
	{
	}

	private int _003CGetVisibleSortedHyperBookIDArray_003Eb__101_0(uint bookA, uint bookB)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
