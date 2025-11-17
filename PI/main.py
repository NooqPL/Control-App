from tcpserver.server import TCPServer
from tcpserver.hardware import HardwareController
import time

def main():
    hw = HardwareController()

    PORT = 5000  # use the same port as windows form
    server = TCPServer(PORT, hw)

    print(f"[MAIN] Starting TCP server on port {PORT}...")

    try:
        server.start()
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        print("[MAIN] Shutting down...")
    except Exception as e:
        print("[MAIN ERROR]", e)
    finally:
        server.stop()


if __name__ == "__main__":
    main()
