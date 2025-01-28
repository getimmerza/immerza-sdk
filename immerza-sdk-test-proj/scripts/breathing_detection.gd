class_name XRBreathingDetectionGDScript extends Node;

signal breathing_detected(state : BREATHING_STATES);

@export var vr_controller: XRController3D;

## Minimum amplitude for breathing detection
@export var BREATHING_THRESHOLD : float = 0.0004; 
## Max amplitude for considering values to corresponding to holding or none
@export var BREATHING_HOLD_THRESHOLD : float = 0.00008;
## Delay between state changes, can be adjusted to fix to aggressive detection
@export var STATE_TRANSITION_DELAY : float = 1.2;
## Lerp value, can be adjusted to set the average that is going to be taken from the amplitudes
@export var SAMPLE_SMOOTHING : float = 0.9;

var last_y_position: float = 0.0; # Previous Y position of the controller
var smoothed_motion: float = 0.0; # Smoothed motion value
var should_plot : bool = false;

enum BREATHING_STATES
{
	NONE,
	BREATHING_IN,
	HOLD,
	BREATHING_OUT
};

var crt_state : BREATHING_STATES = BREATHING_STATES.NONE;

var state_trans_delay_val : float = 0.0;

func _ready():
	await get_tree().create_timer(2.0).timeout;
	should_plot = true;

func _process(delta: float):
	if vr_controller == null:
		return;

	# Get current vertical position
	var current_y_position = vr_controller.global_transform.origin.y;

	# Smooth motion changes to reduce noise
	var delta_y = current_y_position - last_y_position;
	smoothed_motion = abs(lerp(smoothed_motion, delta_y, SAMPLE_SMOOTHING));

	# Detect breathing patterns
	detect_breathing(delta);

	# Update last position
	last_y_position = current_y_position;

func detect_breathing(delta: float):
	var current_time = Time.get_ticks_msec() / 1000.0;
	
	if should_plot:
		EventBus.add_data_to_graph.emit(current_time, smoothed_motion);
	# Detect peaks in motion (breathing cycle)
	
	if state_trans_delay_val >= 0.0:
		state_trans_delay_val -= delta;
	
	if state_trans_delay_val <= 0.0:
		match crt_state:
			BREATHING_STATES.NONE:
				handle_none();
			BREATHING_STATES.BREATHING_IN:
				handle_breathing_in();
			BREATHING_STATES.HOLD:
				handle_hold();
			BREATHING_STATES.BREATHING_OUT:
				handle_breathing_out();
				
	

func handle_none() -> void:
	if smoothed_motion > BREATHING_THRESHOLD:
		crt_state = BREATHING_STATES.BREATHING_IN;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		breathing_detected.emit(crt_state);
		print("BREATHING_IN");
	
func handle_breathing_in() -> void:
	if smoothed_motion < BREATHING_HOLD_THRESHOLD:
		crt_state = BREATHING_STATES.HOLD;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		breathing_detected.emit(crt_state);
		print("HOLD");
	
func handle_hold() -> void:
	if smoothed_motion > BREATHING_THRESHOLD:
		crt_state = BREATHING_STATES.BREATHING_OUT;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		breathing_detected.emit(crt_state);
		print("BREATHING_OUT");
	
func handle_breathing_out() -> void:
	if smoothed_motion < BREATHING_HOLD_THRESHOLD:
		crt_state = BREATHING_STATES.NONE;
		state_trans_delay_val = STATE_TRANSITION_DELAY;
		breathing_detected.emit(crt_state);
		print("NONE");
