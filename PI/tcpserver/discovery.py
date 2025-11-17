import socket
import threading
import time

class DiscoveryBroadcaster:
    def __init__(self, server_ip, server_port, interval=3):
        self.server_ip = server_ip
        self.server_port = server_port
        self.interval = interval
        self.running = False

    def start(self):
        self.running = True
        threading.Thread(target=self.broadcast_loop, daemon=True).start()

    def broadcast_loop(self):
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        sock.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)

        while self.running:
            msg = f"PI-ONLINE;IP={self.server_ip};PORT={self.server_port}"
            sock.sendto(msg.encode(), ('255.255.255.255', 5001))
            time.sleep(self.interval)
