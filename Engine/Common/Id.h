#pragma once

#include "CommonHeaders.h"

namespace primal::id {
	using id_type = u32;

	constexpr u32 generation_bits{ 8 };
	constexpr u32 index_bit{ sizeof(id_type) * 8 - generation_bits };
	constexpr id_type index_mask{ (id_type{1} << index_bit) - 1 };
	constexpr id_type generation_mask{ (id_type{1} << generation_bits) - 1 };
	constexpr id_type id_mask{ id_type{-1} };

	using generation_type = std::conditional_t<generation_bits <= 16, std::conditional_t<generation_bits <= 8, u8, u16>, u32>;
}

