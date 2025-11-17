import socket
import threading
import time
from .commands import process_command

class TCPServer:
    def __init__(self, host, port, hw_controller, telemetry_interval=0.1):
        self.host = host
        self.port = port
        self.hw = hw_controller
        self.telemetry_interval = telemetry_interval
        self.server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.server_socket.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)

    def start_blocking(self):
        self.server_socket.bind((self.host, self.port))
        self.server_socket.listen()

        print(f"[TCP] Listening on {self.host}:{self.port}")

        while True:
            conn, addr = self.server_socket.accept()
            print(f"[TCP] Client connected: {addr}")

            # 2 wątki dla jednego klienta
            threading.Thread(
                target=self.receive_thread,
                args=(conn, addr),
                daemon=True
            ).start()

            threading.Thread(
                target=self.telemetry_thread,
                args=(conn, addr),
                daemon=True
            ).start()

    # === Commands Recive ===
    def receive_thread(self, conn, addr):
        try:
            while True:
                data = conn.recv(1024).decode().strip()
                if not data:
                    break

                print(f"[RX] {addr}: {data}")

                response = process_command(data, self.hw)
                conn.sendall((response + "\n").encode())

        except Exception as e:
            print(f"[ERROR RX] {addr}: {e}")
        finally:
            print(f"[DISCONNECTED] {addr}")
            conn.close()

    # === TELEMETRY SENDING===
    def telemetry_thread(self, conn, addr):
        try:
            while True:
                # sending your data
                telemetry_value = self.hw.get_telemetry()

                msg = f"TEL:{telemetry_value}\n"
                conn.sendall(msg.encode())

                time.sleep(self.telemetry_interval)

        except Exception as e:
            print(f"[ERROR TX] {addr}: {e}")
        finally:
            conn.close()
