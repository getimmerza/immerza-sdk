#pragma once

#include <godot_cpp/godot.hpp>
#include <godot_cpp/variant/array.hpp>
#include <godot_cpp/variant/dictionary.hpp>
#include <godot_cpp/classes/node.hpp>
#include <godot_cpp/classes/xr_controller3d.hpp>

using namespace godot;

class XRBreathingDetection : public Node 
{
	GDCLASS(XRBreathingDetection, Node);
public:
	/* signal breathing_detected(Ref<BREATHING_STATES> state) */

protected:
	NodePath vr_controller;

//# Minimum amplitude for breathing detection
	double BREATHING_THRESHOLD = 0.0004;

//# Max amplitude for considering values to corresponding to holding or none
	double BREATHING_HOLD_THRESHOLD = 8e-05;

//# Delay between state changes, can be adjusted to fix to aggressive detection
	double STATE_TRANSITION_DELAY = 1.2;

//# Lerp value, can be adjusted to set the average that is going to be taken from the amplitudes
	double SAMPLE_SMOOTHING = 0.9;

	double last_y_position = 0.0;
// Previous Y position of the controller
	double smoothed_motion = 0.0;

public:
	enum BREATHING_STATES { NONE, BREATHING_IN, HOLD, BREATHING_OUT };

protected:
	enum BREATHING_STATES crt_state = BREATHING_STATES::NONE;

	double state_trans_delay_val = 0.0;

public:
	void _ready() override;

	void _process(double delta) override;

	void detect_breathing(double delta);

	void handle_none();

	void handle_breathing_in();

	void handle_hold();

	void handle_breathing_out();
	void set_vr_controller(const NodePath &p_vr_controller);
	const NodePath& get_vr_controller() const;
	void set_BREATHING_THRESHOLD(double value);
	double get_BREATHING_THRESHOLD();
	void set_BREATHING_HOLD_THRESHOLD(double value);
	double get_BREATHING_HOLD_THRESHOLD();
	void set_STATE_TRANSITION_DELAY(double value);
	double get_STATE_TRANSITION_DELAY();
	void set_SAMPLE_SMOOTHING(double value);
	double get_SAMPLE_SMOOTHING();

	static void _bind_methods();
};

VARIANT_ENUM_CAST(XRBreathingDetection::BREATHING_STATES);