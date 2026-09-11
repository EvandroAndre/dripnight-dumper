using System.Collections.Generic;

namespace proto;

public class CSGetDigitaluniverseBPlayReviewRes
{
	public class EventReviewData
	{
		public uint event_id;

		public uint signin_reward_times;

		public uint peakday_reward_times;

		public uint[] event_data;
	}

	public class CollectionReviewData
	{
		public uint collection_id;

		public uint kills;

		public uint match_cnt;

		public uint booyah_cnt;

		public uint headshot_cnt;
	}

	public class ClothReviewData
	{
		public uint anniversary_order;

		public bool owned;
	}

	public List<EventReviewData> event_review;

	public List<CollectionReviewData> collection_review;

	public List<ClothReviewData> cloth_review;
}
