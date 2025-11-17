from tcpserver.server import TCPServer
from tcpserver.hardware import HardwareController
from tcpserver.discovery import DiscoveryBroadcaster
import time

def main():
    hw = HardwareController()

    HOST = "0.0.0.0"
    PORT = 5000

    server = TCPServer(HOST, PORT, hw)

    # Start broadcast
    broadcaster = DiscoveryBroadcaster(server_ip="192.168.100.145", server_port=PORT)
    broadcaster.start()

    print(f"[MAIN] Starting TCP server on {HOST}:{PORT}...")

    try:
        server.start_blocking()
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        print("[MAIN] Shutting down...")
