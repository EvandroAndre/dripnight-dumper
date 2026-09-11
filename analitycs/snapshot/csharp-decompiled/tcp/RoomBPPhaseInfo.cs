using System.Collections.Generic;

namespace tcp;

public class RoomBPPhaseInfo
{
	public ERoom.BPPhase phase;

	public uint current_round;

	public ulong end_time;

	public List<RoomBPBannedSkillInfo> banned_skills;

	public List<RoomBPPlayerPickedSkill> picked_skills;

	public List<RoomBPOrderInfo> ban_order;

	public List<RoomBPOrderInfo> pick_order;

	public List<RoomBPPlayerPreSelectInfo> pre_selects;
}
