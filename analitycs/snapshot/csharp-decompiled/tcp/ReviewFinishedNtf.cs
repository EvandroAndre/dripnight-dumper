namespace tcp;

public class ReviewFinishedNtf
{
	public uint slot_id;

	public uint slot_type;

	public uint reward_general_times;

	public uint remain_reward_count;

	public long update_time;

	public string workshop_code;

	public WorkshopReviewResult review_result;

	public uint slot_state;

	public bool is_map_cover_detect_failed;

	public string original_workshop_code;
}
