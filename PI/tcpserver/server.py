import socket
import threading

HOST = "0.0.0.0"
PORT = 5000

clients = []

def handle_client(conn, addr):
    print(f"[PI] Client connected from {addr}")

    while True:
        try:
            data = conn.recv(1024)
            if not data:
                break

            msg = data.decode().strip()
            print("[RX]", msg)

            # → tu możesz obsłużyć komendy z Windows
            response = f"PI_ECHO: {msg}\n"
            conn.sendall(response.encode())

        except:
            break

    print("[PI] Client disconnected", addr)
    conn.close()
    clients.remove(conn)


def start():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    sock.bind((HOST, PORT))
    sock.listen(5)

    print(f"[PI] TCP server listening on {PORT}")

    while True:
        conn, addr = sock.accept()
        clients.append(conn)
        threading.Thread(target=handle_client, args=(conn, addr), daemon=True).start()


if __name__ == "__main__":
    start()
