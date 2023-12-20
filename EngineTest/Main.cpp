#pragma once
#include "TestEntityComponents.h"

#define TEST_ENTITY_COMPONENTS 1

#if TEST_ENTITY_COMPONENTS


#else
#error One of the tests need to be enabled

#endif

int main() {

	engine_test test{};

	if (test.initialize()) {
		test.run();
	}

	test.shutdown();
}