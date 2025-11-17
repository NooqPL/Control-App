import pigpio
import time

class HardwareController:
    def __init__(self):
        self.pi = pigpio.pi()
        if not self.pi.connected:
            raise RuntimeError("pigpid not running")

        # Your servos
        self.servo_pins = {0: 17}

        # Your sensors
        self.sensor_map = {}

    def set_servo(self, servo_id, value):
        if servo_id not in self.servo_pins:
            return

        pin = self.servo_pins[servo_id]
        pulse = int(1500 + value * 500)  # -1..1 -> 1000–2000us
        self.pi.set_servo_pulsewidth(pin, pulse)

    def read_sensor(self, sensor_id):
        return 0.0  # TODO

    def get_telemetry(self):
        """
        give back string or number – this will be send in the CONSTANT STREAM.
        """
        # TODO -> np. speed readings, position, voltages, temperaturs etc.
        return "0,0,0"
