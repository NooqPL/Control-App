#!/usr/bin/env python3
import time
from tcpserver.server import TCPServer
from tcpserver.hardware import HardwareController

def main():

    print("=== ControlApp – TCP duplex server starting ===")

    hw = HardwareController()

    server = TCPServer(
        host="0.0.0.0",
        port=9000,
        hw_controller=hw,
        telemetry_interval=0.05  # 50ms = 20Hz telemetria
    )

    server.start_blocking()  # działa non-stop

if __name__ == "__main__":
    main()
