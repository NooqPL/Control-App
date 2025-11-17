try:
    import pigpio
    HARDWARE_AVAILABLE = True
except Exception as e:
    print("[HARDWARE] pigpio not available:", e)
    HARDWARE_AVAILABLE = False


class HardwareController:
    def __init__(self):
        if HARDWARE_AVAILABLE:
            self.pi = pigpio.pi()
            if not self.pi.connected:
                print("[HARDWARE] pigpio daemon not connected! Running in NO-HARDWARE mode.")
                self.pi = None
                self.hw_ready = False
            else:
                print("[HARDWARE] pigpio initialized")
                self.hw_ready = True
        else:
            self.pi = None
            self.hw_ready = False

        # Example servo outputs:
        self.servo_pins = {
            "servo1": 17,
            "servo2": 27,
        }

    def set_servo_angle(self, name, angle):
        if not self.hw_ready:
            print(f"[HARDWARE] NO-HARDWARE MODE → ignoring servo command {name} = {angle}")
            return

        pin = self.servo_pins.get(name)
        if pin is None:
            print(f"[HARDWARE] Unknown servo {name}")
            return

        pulse = int(500 + (angle / 180.0) * 2000)
        self.pi.set_servo_pulsewidth(pin, pulse)

    def read_sensor(self):
        if not self.hw_ready:
            return 0  # fake sensor value
        # TODO: add real sensor code here
        return 123
