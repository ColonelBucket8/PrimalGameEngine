#include "Entity.h"

namespace primal::game_entity {
	namespace {
		utl::vector<id::generation_type> generations;
	} // anonymous namespace


	entity_id create_game_entity(const entity_info& info) {

		assert(info.transform);
		if (!info.transform) return entity_id{};
	}
}

