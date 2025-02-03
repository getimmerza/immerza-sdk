
#include "xr_breathing_detection.h"

#include <godot_cpp/core/object.hpp>
#include <godot_cpp/core/class_db.hpp>
#include <godot_cpp/variant/utility_functions.hpp>
#include <godot_cpp/classes/time.hpp>
#include <godot_cpp/classes/object.hpp>

void XRBreathingDetection::_ready()
{

}

void XRBreathingDetection::_process(double delta)
{
	Node* source_vr_node = get_node_or_null(vr_controller);
	XRController3D* vr_controller_node = Object::cast_to<XRController3D>(source_vr_node);

	if(vr_controller_node == nullptr)
	{
		return;
	}

	// Get current vertical position
	double current_y_position = vr_controller_node->get_global_transform().origin.y;

	// Smooth motion changes to reduce noise
	double delta_y = current_y_position - last_y_position;
	smoothed_motion = Math::abs(Math::lerp(smoothed_motion, delta_y, SAMPLE_SMOOTHING));

	// Detect breathing patterns
	detect_breathing(delta);

	// Update last position
	last_y_position = current_y_position;
}

void XRBreathingDetection::detect_breathing(double delta)
{
	double current_time = Time::get_singleton()->get_ticks_msec() / 1000.0;

	// Detect peaks in motion (breathing cycle)
	if(state_trans_delay_val >= 0.0)
	{
		state_trans_delay_val -= delta;
	}

	if(state_trans_delay_val <= 0.0)
	{

		if(crt_state == BREATHING_STATES::NONE)
		{
			handle_none();
		}
		if(crt_state == BREATHING_STATES::BREATHING_IN)
		{
			handle_breathing_in();
		}
		if(crt_state == BREATHING_STATES::HOLD)
		{
			handle_hold();
		}
		if(crt_state == BREATHING_STATES::BREATHING_OUT)
		{
			handle_breathing_out();
		}
	}
}

void XRBreathingDetection::handle_none()
{
	if(smoothed_motion > BREATHING_THRESHOLD)
	{
		crt_state = BREATHING_STATES::BREATHING_IN;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		emit_signal("breathing_detected", crt_state);
		UtilityFunctions::print("BREATHING_IN");
	}
}

void XRBreathingDetection::handle_breathing_in()
{
	if(smoothed_motion < BREATHING_HOLD_THRESHOLD)
	{
		crt_state = BREATHING_STATES::HOLD;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		emit_signal("breathing_detected", crt_state);
		UtilityFunctions::print("HOLD");
	}
}

void XRBreathingDetection::handle_hold()
{
	if(smoothed_motion > BREATHING_THRESHOLD)
	{
		crt_state = BREATHING_STATES::BREATHING_OUT;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		emit_signal("breathing_detected", crt_state);
		UtilityFunctions::print("BREATHING_OUT");
	}
}

void XRBreathingDetection::handle_breathing_out()
{
	if(smoothed_motion < BREATHING_HOLD_THRESHOLD)
	{
		crt_state = BREATHING_STATES::NONE;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		emit_signal("breathing_detected", crt_state);
		UtilityFunctions::print("NONE");
	}
}

const NodePath& XRBreathingDetection::get_vr_controller() const 
{
	return vr_controller;
}

void XRBreathingDetection::set_vr_controller(const NodePath &p_vr_controller)
{
	vr_controller = p_vr_controller;
}

void XRBreathingDetection::set_BREATHING_THRESHOLD(double value) 
{
	BREATHING_THRESHOLD = value;
}

double XRBreathingDetection::get_BREATHING_THRESHOLD() 
{
	return BREATHING_THRESHOLD;
}

void XRBreathingDetection::set_BREATHING_HOLD_THRESHOLD(double value) 
{
	BREATHING_HOLD_THRESHOLD = value;
}

double XRBreathingDetection::get_BREATHING_HOLD_THRESHOLD() 
{
	return BREATHING_HOLD_THRESHOLD;
}

void XRBreathingDetection::set_STATE_TRANSITION_DELAY(double value) 
{
	STATE_TRANSITION_DELAY = value;
}

double XRBreathingDetection::get_STATE_TRANSITION_DELAY() 
{
	return STATE_TRANSITION_DELAY;
}

void XRBreathingDetection::set_SAMPLE_SMOOTHING(double value) 
{
	SAMPLE_SMOOTHING = value;
}

double XRBreathingDetection::get_SAMPLE_SMOOTHING() 
{
	return SAMPLE_SMOOTHING;
}

void XRBreathingDetection::_bind_methods() 
{
	ClassDB::bind_method(D_METHOD("detect_breathing", "delta"), &XRBreathingDetection::detect_breathing);
	ClassDB::bind_method(D_METHOD("handle_none"), &XRBreathingDetection::handle_none);
	ClassDB::bind_method(D_METHOD("handle_breathing_in"), &XRBreathingDetection::handle_breathing_in);
	ClassDB::bind_method(D_METHOD("handle_hold"), &XRBreathingDetection::handle_hold);
	ClassDB::bind_method(D_METHOD("handle_breathing_out"), &XRBreathingDetection::handle_breathing_out);
	ClassDB::bind_method(D_METHOD("set_vr_controller", "value"), &XRBreathingDetection::set_vr_controller);
	ClassDB::bind_method(D_METHOD("get_vr_controller"), &XRBreathingDetection::get_vr_controller);
	ClassDB::bind_method(D_METHOD("set_BREATHING_THRESHOLD", "value"), &XRBreathingDetection::set_BREATHING_THRESHOLD);
	ClassDB::bind_method(D_METHOD("get_BREATHING_THRESHOLD"), &XRBreathingDetection::get_BREATHING_THRESHOLD);
	ClassDB::bind_method(D_METHOD("set_BREATHING_HOLD_THRESHOLD", "value"), &XRBreathingDetection::set_BREATHING_HOLD_THRESHOLD);
	ClassDB::bind_method(D_METHOD("get_BREATHING_HOLD_THRESHOLD"), &XRBreathingDetection::get_BREATHING_HOLD_THRESHOLD);
	ClassDB::bind_method(D_METHOD("set_STATE_TRANSITION_DELAY", "value"), &XRBreathingDetection::set_STATE_TRANSITION_DELAY);
	ClassDB::bind_method(D_METHOD("get_STATE_TRANSITION_DELAY"), &XRBreathingDetection::get_STATE_TRANSITION_DELAY);
	ClassDB::bind_method(D_METHOD("set_SAMPLE_SMOOTHING", "value"), &XRBreathingDetection::set_SAMPLE_SMOOTHING);
	ClassDB::bind_method(D_METHOD("get_SAMPLE_SMOOTHING"), &XRBreathingDetection::get_SAMPLE_SMOOTHING);
	ClassDB::bind_integer_constant(get_class_static(), _gde_constant_get_enum_name(NONE, "NONE"), "NONE", NONE);
	ClassDB::bind_integer_constant(get_class_static(), _gde_constant_get_enum_name(BREATHING_IN, "BREATHING_IN"), "BREATHING_IN", BREATHING_IN);
	ClassDB::bind_integer_constant(get_class_static(), _gde_constant_get_enum_name(HOLD, "HOLD"), "HOLD", HOLD);
	ClassDB::bind_integer_constant(get_class_static(), _gde_constant_get_enum_name(BREATHING_OUT, "BREATHING_OUT"), "BREATHING_OUT", BREATHING_OUT);
	ClassDB::add_property(get_class_static(), PropertyInfo(Variant::NODE_PATH, "vr_controller", PROPERTY_HINT_NODE_PATH_VALID_TYPES, "XRController3D"), "set_vr_controller", "get_vr_controller");
	ClassDB::add_property(get_class_static(), PropertyInfo(Variant::FLOAT, "BREATHING_THRESHOLD"), "set_BREATHING_THRESHOLD", "get_BREATHING_THRESHOLD");
	ClassDB::add_property(get_class_static(), PropertyInfo(Variant::FLOAT, "BREATHING_HOLD_THRESHOLD"), "set_BREATHING_HOLD_THRESHOLD", "get_BREATHING_HOLD_THRESHOLD");
	ClassDB::add_property(get_class_static(), PropertyInfo(Variant::FLOAT, "STATE_TRANSITION_DELAY"), "set_STATE_TRANSITION_DELAY", "get_STATE_TRANSITION_DELAY");
	ClassDB::add_property(get_class_static(), PropertyInfo(Variant::FLOAT, "SAMPLE_SMOOTHING"), "set_SAMPLE_SMOOTHING", "get_SAMPLE_SMOOTHING");
	ClassDB::add_signal(get_class_static(), MethodInfo("breathing_detected", PropertyInfo(Variant::OBJECT, "state")));
}

