from tcpserver.server import TCPServer
from tcpserver.hardware import HardwareController
import time

def main():
    hw = HardwareController()
    server = TCPServer(hw)

    print("[MAIN] Starting TCP server...")

    try:
        server.start()
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        print("[MAIN] Shutting down server...")
    except Exception as e:
        print("[MAIN] ERROR:", e)
    finally:
        server.stop()


if __name__ == "__main__":
    main()
