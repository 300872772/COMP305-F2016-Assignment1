#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Transform
struct Transform_t1659122786;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// blackworldController
struct  blackworldController_t1415454447  : public MonoBehaviour_t667441552
{
public:
	// System.Int32 blackworldController::_speed
	int32_t ____speed_2;
	// UnityEngine.Transform blackworldController::_transform
	Transform_t1659122786 * ____transform_3;

public:
	inline static int32_t get_offset_of__speed_2() { return static_cast<int32_t>(offsetof(blackworldController_t1415454447, ____speed_2)); }
	inline int32_t get__speed_2() const { return ____speed_2; }
	inline int32_t* get_address_of__speed_2() { return &____speed_2; }
	inline void set__speed_2(int32_t value)
	{
		____speed_2 = value;
	}

	inline static int32_t get_offset_of__transform_3() { return static_cast<int32_t>(offsetof(blackworldController_t1415454447, ____transform_3)); }
	inline Transform_t1659122786 * get__transform_3() const { return ____transform_3; }
	inline Transform_t1659122786 ** get_address_of__transform_3() { return &____transform_3; }
	inline void set__transform_3(Transform_t1659122786 * value)
	{
		____transform_3 = value;
		Il2CppCodeGenWriteBarrier(&____transform_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
