extends Node3D;

@export var maximum_refresh_rate : int = 90

var xr_interface : XRInterface;

func _ready():
	xr_interface = XRServer.find_interface("OpenXR");
	if xr_interface and xr_interface.is_initialized():
		print("OpenXR initialized successfully");
		
		DisplayServer.window_set_vsync_mode(DisplayServer.VSYNC_DISABLED);
		get_viewport().use_xr = true;
		
		xr_interface.session_begun.connect(_on_openxr_session_begun);
		
	else:
		print("OpenXR failed to initialize, check headset connection.");

func _on_openxr_session_begun() -> void:
	var current_refresh_rate = xr_interface.get_display_refresh_rate()
	if current_refresh_rate > 0:
		print("OpenXR: Refresh rate reported as ", str(current_refresh_rate))
	else:
		print("OpenXR: No refresh rate given by XR runtime")

	var new_rate = current_refresh_rate
	var available_rates : Array = xr_interface.get_available_display_refresh_rates()
	if available_rates.size() == 0:
		print("OpenXR: Target does not support refresh rate extension")
	elif available_rates.size() == 1:
		new_rate = available_rates[0]
	else:
		for rate in available_rates:
			if rate > new_rate and rate <= maximum_refresh_rate:
				new_rate = rate

	if current_refresh_rate != new_rate:
		print("OpenXR: Setting refresh rate to ", str(new_rate))
		xr_interface.set_display_refresh_rate(new_rate)
		current_refresh_rate = new_rate
		
	Engine.physics_ticks_per_second = current_refresh_rate
