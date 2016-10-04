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

// RelicController2
struct  RelicController2_t3364053699  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.Transform RelicController2::_transform
	Transform_t1659122786 * ____transform_2;
	// System.Boolean RelicController2::_direction
	bool ____direction_3;
	// System.Int32 RelicController2::_speed
	int32_t ____speed_4;
	// System.Int32 RelicController2::_drift
	int32_t ____drift_5;

public:
	inline static int32_t get_offset_of__transform_2() { return static_cast<int32_t>(offsetof(RelicController2_t3364053699, ____transform_2)); }
	inline Transform_t1659122786 * get__transform_2() const { return ____transform_2; }
	inline Transform_t1659122786 ** get_address_of__transform_2() { return &____transform_2; }
	inline void set__transform_2(Transform_t1659122786 * value)
	{
		____transform_2 = value;
		Il2CppCodeGenWriteBarrier(&____transform_2, value);
	}

	inline static int32_t get_offset_of__direction_3() { return static_cast<int32_t>(offsetof(RelicController2_t3364053699, ____direction_3)); }
	inline bool get__direction_3() const { return ____direction_3; }
	inline bool* get_address_of__direction_3() { return &____direction_3; }
	inline void set__direction_3(bool value)
	{
		____direction_3 = value;
	}

	inline static int32_t get_offset_of__speed_4() { return static_cast<int32_t>(offsetof(RelicController2_t3364053699, ____speed_4)); }
	inline int32_t get__speed_4() const { return ____speed_4; }
	inline int32_t* get_address_of__speed_4() { return &____speed_4; }
	inline void set__speed_4(int32_t value)
	{
		____speed_4 = value;
	}

	inline static int32_t get_offset_of__drift_5() { return static_cast<int32_t>(offsetof(RelicController2_t3364053699, ____drift_5)); }
	inline int32_t get__drift_5() const { return ____drift_5; }
	inline int32_t* get_address_of__drift_5() { return &____drift_5; }
	inline void set__drift_5(int32_t value)
	{
		____drift_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
