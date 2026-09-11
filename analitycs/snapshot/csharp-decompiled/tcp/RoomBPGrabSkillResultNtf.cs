using System.Collections.Generic;

namespace tcp;

public class RoomBPGrabSkillResultNtf
{
	public ulong room_id;

	public ulong requester_id;

	public ulong receiver_id;

	public List<RoomBPPlayerPickedSkill> picked_skills;

	public List<RoomBPOrderInfo> pick_order;
}
