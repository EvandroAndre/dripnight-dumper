using System.Collections.Generic;

namespace COW;

public class AssistHighlightMomentInfo : IGameAssistItemData
{
	private ELobbyAssistDataType m_SubType;

	private ulong m_AssistId;

	private bool m_AggregatedHasRead;

	private bool m_NeedHideLine;

	private ulong m_DisplayMatchId;

	private bool m_HasHighlight;

	private bool m_HasPostReview;

	private bool m_HighlightHasRead;

	private bool m_PostReviewHasRead;

	private long m_SortTimestamp;

	private long m_PostReviewMatchDurationMs;

	private uint m_PostReviewGameMode;

	private uint m_PostReviewMatchMode;

	public bool HasRead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NeedHideLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ELobbyAssistDataType SubType
	{
		get
		{
			return ELobbyAssistDataType.None;
		}
		set
		{
		}
	}

	public ulong DisplayMatchId
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public bool HasHighlight
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasPostReview
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HighlightHasRead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool PostReviewHasRead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public long SortTimestamp
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public long PostReviewMatchDurationMs
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public uint PostReviewGameMode
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint PostReviewMatchMode
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public ulong Assist_Id
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public void RefreshReadState()
	{
	}

	public bool CheckAssistStateIsFit(bool checkNewMessage)
	{
		return false;
	}

	public bool CheckCanAddToList()
	{
		return false;
	}

	public bool IsUnreadHighlightForBubble()
	{
		return false;
	}

	public bool IsUnreadPostReviewForBubble(long minDurationMs)
	{
		return false;
	}

	public void AddDataToViewList(uint index, List<IGameAssistItemData> list)
	{
	}
}
