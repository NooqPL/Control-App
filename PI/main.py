from tcpserver.server import TCPServer
from tcpserver.hardware import HardwareController
import time

def main():
    hw = HardwareController()

    HOST = "0.0.0.0"
    PORT = 5000  # use the same port as windows form

    
    server = TCPServer(HOST, PORT, hw)

    print(f"[MAIN] Starting TCP server on {HOST}:{PORT}...")

    try:
        server.start_blocking()   
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        print("[MAIN] Shutting down...")
    except Exception as e:
        print("[MAIN ERROR]", e)
    finally:
        pass  

if __name__ == "__main__":
    main()
